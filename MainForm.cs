using System.ComponentModel;
using System.Text.Json;

namespace KakeiboApp
{
    public partial class MainForm : Form
    {
        #region フィールド
        // 収支のデータの一覧(追加すると画面にも反映される)
        // 普通のListだと、データを追加しても一覧が更新されないので、BindingListを使って画面に通知を出せるようにしている
        private readonly BindingList<Record> records = new BindingList<Record>();

        // 収支のデータの一覧のファイル名を入れておく定数(constなので)
        private const string RecordsFileName = "kakeiborecords.json";

        // 表示用の一覧：選んだ年月の分だけを入れておく箱。画面はこっちを映す
        private readonly BindingList<Record> selectedRecords = new BindingList<Record>();

        // 今月の1日を基準にする　＜＞ボタンで切り替える時の基準になる値 ここはむずかしかった
        private DateTime currentMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

        #endregion

        #region コンストラクタ
        // アプリ起動時に1回だけ動く準備の場所
        public MainForm()
        {
            InitializeComponent();
            // この画面はこの帳簿を映してね とつなぐ
            recordsDataGridView.DataSource = selectedRecords;
            // 列名が英語のままなので日本語にする
            SetupColumns();

            // JSONファイルからデータを読み込む
            LoadRecords();

            // 表示を「選んだ年月の分」に更新するメソッド
            RefreshDisplay();

            // 読み込んだデータで合計を表示する
            UpdateSummary();

            this.guideLabel.Text = "支出が選ばれています。お金が入ったときは『収入』を選んでください";
        }
        #endregion

        #region イベントハンドラ

        private void addButton_Click(object sender, EventArgs e)
        {
            // 入力チェック
            if (categoryComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("カテゴリを選択してください。");
                return;
            }

            // 文字を数値に変換出来たらtrue、できなかったらfalseで返す
            if (!int.TryParse(amountTextBox.Text, out int amount) || amount <= 0) // outは「結果をこの変数に入れて返すよ」という意味
            {
                MessageBox.Show("金額は1以上の数値を入力してください。");
                return;
            }

            // Recordを作って一覧に追加
            var record = new Record
            {
                Date = dateTimePicker.Value.Date,
                Category = categoryComboBox.Text,
                Amount = amount,
                Shop = shopTextBox.Text,
                IsIncome = incomeRadioButton.Checked,
                Memo = memoTextBox.Text
            };
            records.Add(record);

            //monthPicker.Value = dateTimePicker.Value.Date;
            monthPicker.Value = record.Date;

            // 入力欄をクリア
            amountTextBox.Clear();
            memoTextBox.Clear();
            amountTextBox.Focus();
            shopTextBox.Clear();

            // 追加したらすぐに保存する
            SaveRecords();

            RefreshDisplay();

            // 収入や支出の合計を計算しなおす
            UpdateSummary();

            this.guideLabel.Text = "追加しました。";

            updateButton.Enabled = false;
            cancelButton.Enabled = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // 削除する項目のチェック
            // 項目が選択されていなかったらメッセージを表示する
            // nullを調べる相手はCurrentRow
            if (recordsDataGridView.CurrentRow == null) //メモ Selectedはその行が選択されているかのtrue/falseで表すbool型 boolはnullにならないから常にfalseになる
            {
                MessageBox.Show("削除する項目を選択してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 下は自分が最初に書いたやつ。Selectedがいらない
            //if (recordsDataGridView.CurrentRow.Selected == null)
            //{
            //    MessageBox.Show("削除する項目を選択してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // 本当に削除するのか確認する
            DialogResult result = MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            // 下は自分が最初に書いたやつ。ifが先に来ていて、メッセージを出すのが後になっている。
            // もし帳票が選択されていて、削除ボタンが押されていたら～みたいに考えていたが、そもそも削除ボタン押したときの処理である
            //if (recordsDataGridView.SelectedRows(DialogResult.Yes || DialogResult.No))
            //    MessageBox.Show("本当に削除しますか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 項目が選択されている状態で削除ボタンを押したら、選択されている項目を帳簿から削除する
            // ステップ1 どこから取り出すか 「グリッドの→今選ばれている行の→映しているデータ」を.でたどる
            // 上記が「選ばれた行のデータ」
            // ステップ2 型を変換する ①はobject型(中身がわからない箱)として扱われる そのままだと帳簿(BindingList<Record>)から削除できないので、中身はRecordだと教える。それがas Record
            Record? selectedRecord = recordsDataGridView.CurrentRow.DataBoundItem as Record;
            // nullチェックを入れる場合
            //if(selectedRecord == null)
            //{
            //    MessageBox.Show("削除する項目を選択してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // ステップ3 帳簿から削除する
            // .Deleteかと思ってたけど違った
            // なぜRemoveを使うのか？ 「この物を帳簿から取り除く」という命令。Removeは取り除く対象を指定する。Deleteはメソッド自体が存在しない。
            records.Remove(selectedRecord);

            // 追加したらすぐに保存する
            SaveRecords();

            // 表示を「選んだ年月の分」に更新するメソッド
            RefreshDisplay();

            // 収入や支出の合計を計算しなおす
            UpdateSummary();

            this.guideLabel.Text = "削除しました。";

            addButton.Enabled = true;
            updateButton.Enabled = false;
            cancelButton.Enabled = false;
        }


        #endregion

        #region 画面表示

        // 列の見出しや表示形式を整える
        private void SetupColumns()
        {
            var cols = recordsDataGridView.Columns;
            cols["Date"].HeaderText = "日付";
            cols["Date"].DefaultCellStyle.Format = "yyyy/MM/dd";
            cols["Category"].HeaderText = "カテゴリー";
            cols["Amount"].HeaderText = "金額";
            cols["Amount"].DefaultCellStyle.Format = "N0";
            cols["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cols["IsIncome"].HeaderText = "収入";
            cols["Memo"].HeaderText = "メモ";
            cols["Kind"].HeaderText = "収支";
            cols["IsIncome"].Visible = false; // IsIncome列は非表示
            cols["Shop"].HeaderText = "お店";
        }

        // 収入・支出・残高を計算して表示
        private void UpdateSummary()
        {
            // 今月
            // selectedRecords.Where(r => r.IsIncome)は「帳簿から収入の行だけ取り出す」、.Sum(r => r.Amount)はその金額を合計する
            // r => ... は「1件ずつ r と呼んで、こう判定・計算する」という書き方(ラムダ式)
            int monthIncome = selectedRecords.Where(r => r.IsIncome).Sum(r => r.Amount);
            int monthExpense = selectedRecords.Where(r => !r.IsIncome).Sum(r => r.Amount);
            int monthBalance = monthIncome - monthExpense;

            summaryLabel.Text = $"今月　収入 {monthIncome:N0}円 支出 {monthExpense:N0}円 残高 {monthBalance:N0}円";

            // 今年　帳簿(records)から、日付の年が見ている月(currentMonth)の年と同じものを拾う
            //var monthRecords = records.Where(r => r.Date.Year == currentMonth.Year)
            //int yearIncome = records.Where(r => r.Date.Year == currentMonth.Year).Where(r => r.IsIncome).Sum(r => r.Amount);
            //int yearExpense = records.Where(r => r.Date.Year == currentMonth.Year).Where(r => !r.IsIncome).Sum(r => r.Amount);

            // 上でもいいが、下のほうが短くて読みやすい
            // まず、帳簿からその年の分だけを拾って箱に入れておく
            var yearsRecords = records.Where(r => r.Date.Year == currentMonth.Year);
            // その箱から、収入だけ・支出だけを拾って合計する
            int yearIncome = yearsRecords.Where(r => r.IsIncome).Sum(r => r.Amount);
            int yearExpense = yearsRecords.Where(r => !r.IsIncome).Sum(r => r.Amount);
            int yearBalance = yearIncome - yearExpense;

            yearSummaryLabel.Text = $"{currentMonth.Year}年　収入 {yearIncome:N0}円 支出 {yearExpense:N0}円 残高 {yearBalance:N0}円";

            // 全期間
            int totalIncome = records.Where(r => r.IsIncome).Sum(r => r.Amount);
            int totalExpense = records.Where(r => !r.IsIncome).Sum(r => r.Amount);
            int totalBalance = totalIncome - totalExpense;

            totalSummaryLabel.Text = $"全期間　収入 {totalIncome:N0}円 支出 {totalExpense:N0}円 残高 {totalBalance:N0}円";


        }

        // 表示を「選んだ年月の分」に更新するメソッド
        private void RefreshDisplay()
        {
            // 表示用の一覧をクリアする
            selectedRecords.Clear();

            // 帳簿から選んだ年月の分を拾ってくる
            // 「r の日付の年 == 今見ている月の年 かつ r の日付の月 == 今見ている月の月」
            var monthRecords = records.Where(r => r.Date.Year == currentMonth.Year && r.Date.Month == currentMonth.Month)
            // 拾って来た中身を日付順に並び変える
            // records.Where(条件).OrderBy(何の順番か)
            .OrderBy(r => r.Date);
            // 表示用の一覧に入れなおす
            foreach (var item in monthRecords)
            {
                selectedRecords.Add(item);
            }
        }

        #endregion

        #region 保存・読み込み

        // 読み込み用のメソッド
        private void LoadRecords()
        {
            //  読み込むファイルのパスにファイルがあるかをチェックする
            if (!File.Exists(RecordsFileName))
            {
                //  もしファイルがなければ処理を終了する
                return;
            }

            //  ファイルがあれば、ファイルの中身を読みこむ
            string jsonString = File.ReadAllText(RecordsFileName);
            //  Recordの一覧に戻す
            var loadedRecords = JsonSerializer.Deserialize<List<Record>>(jsonString);

            //　1件ずつ帳簿に入れる nullだったら処理を終了する
            if (loadedRecords == null)
            {
                return;
            }

            foreach (var record in loadedRecords)
            {
                records.Add(record);
            }

        }

        // 保存用のメソッド
        private void SaveRecords()
        {
            // 帳簿全体を文字に変換する
            string jsonString = JsonSerializer.Serialize(records);
            // 文字をファイルに書き込む
            File.WriteAllText(RecordsFileName, jsonString);
        }

        #endregion

        #region 
        #endregion

        // 日づけを選択した時の処理
        private void monthPicker_ValueChanged(object sender, EventArgs e)
        {
            // ピッカーで選ばれた年月を currentMonth に入れる(1日にそろえる)→ RefreshDisplay → 合計も更新
            currentMonth = new DateTime(monthPicker.Value.Year, monthPicker.Value.Month, 1);

            // 表示を「選んだ年月の分」に更新するメソッド
            RefreshDisplay();

            // 収入や支出の合計を計算しなおす
            UpdateSummary();
        }

        private void prevMonthButton_Click(object sender, EventArgs e)
        {
            monthPicker.Value = monthPicker.Value.AddMonths(-1);
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            monthPicker.Value = monthPicker.Value.AddMonths(1);
        }

        private void dateTimePicker_Enter(object sender, EventArgs e)
        {
            this.guideLabel.Text = "カレンダーマークを押して日付を選択してね。";
        }

        private void categoryComboBox_Enter(object sender, EventArgs e)
        {
            this.guideLabel.Text = "支出なら何に使ったか(食費、生活用品等)、収入ならどこから入ったかを選択してね。";
        }

        private void amountTextBox_Enter(object sender, EventArgs e)
        {
            this.guideLabel.Text = "金額を数字で入力してね。";
        }

        private void shopTextBox_Enter(object sender, EventArgs e)
        {
            this.guideLabel.Text = "お店の名前を入力してね。(書かなくても大丈夫)";
        }

        private void memoTextBox_Enter(object sender, EventArgs e)
        {
            this.guideLabel.Text = "メモしておきたい事を入力してね。(書かなくても大丈夫)";
        }

        private void addButton_Enter(object sender, EventArgs e)
        {
            this.guideLabel.Text = "入力内容に間違えがなければ『追加』を押してね。";
        }

        private void incomeRadioButton_Enter(object sender, EventArgs e)
        {
            this.guideLabel.Text = "お金が入ったときは『収入』、使ったときは『支出』を選んでね";
        }

        private void recordsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (recordsDataGridView.CurrentRow == null) //メモ Selectedはその行が選択されているかのtrue/falseで表すbool型 boolはnullにならないから常にfalseになる
            {
                return;
            }

            // 選択した行の値が各入力欄に表示される
            Record? selectedRecord = recordsDataGridView.CurrentRow.DataBoundItem as Record;
            // nullチェックを入れる場合
            if (selectedRecord == null)
            {
                return;
            }

            // レコードの中身を書き換える
            //Date = dateTimePicker.Value.Date,
            dateTimePicker.Value = selectedRecord.Date;
            //Category = categoryComboBox.Text,
            categoryComboBox.Text = selectedRecord.Category;
            //Amount = amount,
            amountTextBox.Text = selectedRecord.Amount.ToString();
            //Shop = shopTextBox.Text,
            shopTextBox.Text = selectedRecord.Shop;
            //IsIncome = incomeRadioButton.Checked,
            incomeRadioButton.Checked = selectedRecord.IsIncome;
            expenseRadioButton.Checked = !selectedRecord.IsIncome;

            //Memo = memoTextBox.Text
            memoTextBox.Text = selectedRecord.Memo;

            addButton.Enabled = false;
            updateButton.Enabled = true;
            cancelButton.Enabled = true;

            this.guideLabel.Text = "編集中だよ。直したら『更新』、やめるときは『入力をやめる』を押してね";

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // 行が選ばれているかチェック
            if (recordsDataGridView.CurrentRow == null) //メモ Selectedはその行が選択されているかのtrue/falseで表すbool型 boolはnullにならないから常にfalseになる
            {
                MessageBox.Show("更新する項目を選択してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 選ばれた行のRecordを取り出す
            Record? selectedRecord = recordsDataGridView.CurrentRow.DataBoundItem as Record;

            // nullチェックを入れる
            if (selectedRecord == null)
            {
                MessageBox.Show("更新する項目を選択してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 入力チェック:カテゴリーと金額
            if (categoryComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("カテゴリを選択してください。");
                return;
            }

            // 文字を数値に変換出来たらtrue、できなかったらfalseで返す
            if (!int.TryParse(amountTextBox.Text, out int amount) || amount <= 0) // outは「結果をこの変数に入れて返すよ」という意味
            {
                return;
            }

            //if (amountTextBox.Text == null)
            //{
            //    MessageBox.Show("金額を入力してください。");
            //    return;
            //}

            // 取り出したRecordの中身を、入力欄の値で書き換える
            // 行をクリックしたとき:入力欄 = selectedRecord.プロパティ;
            //更新ボタン: selectedRecord.プロパティ = 入力欄;
            //Date = dateTimePicker.Value.Date,
            selectedRecord.Date = dateTimePicker.Value.Date;
            //Category = categoryComboBox.Text,
            selectedRecord.Category = categoryComboBox.Text;
            //Amount = amount,
            selectedRecord.Amount = amount;
            //Shop = shopTextBox.Text,
            selectedRecord.Shop = shopTextBox.Text;
            //IsIncome = incomeRadioButton.Checked,
            selectedRecord.IsIncome = incomeRadioButton.Checked;
            //!selectedRecord.IsIncome = expenseRadioButton.Checked;
            //Memo = memoTextBox.Text
            selectedRecord.Memo = memoTextBox.Text;

            monthPicker.Value = selectedRecord.Date;

            // 入力欄をクリア
            amountTextBox.Clear();
            memoTextBox.Clear();
            amountTextBox.Focus();
            shopTextBox.Clear();

            // 更新したらすぐに保存する
            SaveRecords();

            RefreshDisplay();

            // 収入や支出の合計を計算しなおす
            UpdateSummary();

            this.guideLabel.Text = "更新しました。";

            addButton.Enabled = true;
            updateButton.Enabled = false;
            cancelButton.Enabled = false;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // 入力欄をクリア
            amountTextBox.Clear();
            memoTextBox.Clear();
            amountTextBox.Focus();
            shopTextBox.Clear();

            // ボタンを元に戻す
            addButton.Enabled = true;
            updateButton.Enabled = false;
            cancelButton.Enabled = false;

            // 日付を今日の日付に戻す
            dateTimePicker.Value = DateTime.Today;

            // カテゴリーをクリアする
            categoryComboBox.SelectedIndex = -1;
            // 収入 / 支出:支出に戻す
            expenseRadioButton.Checked = true;

            // 案内ラベルに表示する
            this.guideLabel.Text = "編集モードを取り消したよ";
        }
    }
}
