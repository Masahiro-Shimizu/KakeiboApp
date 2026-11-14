using Microsoft.VisualBasic;
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
            recordsDataGridView.DataSource = records;
            // 列名が英語のままなので日本語にする
            SetupColumns();

            // JSONファイルからデータを読み込む
            LoadRecords();

            // 読み込んだデータで合計を表示する
            UpdateSummary();
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
                IsIncome = incomeRadioButton.Checked,
                Memo = memoTextBox.Text
            };
            records.Add(record);

            // 入力欄をクリア
            amountTextBox.Clear();
            memoTextBox.Clear();
            amountTextBox.Focus();

            // 追加したらすぐに保存する
            SaveRecords();

            // 収入や支出の合計を計算しなおす
            UpdateSummary();
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

            // 収入や支出の合計を計算しなおす
            UpdateSummary();
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
        }

        // 収入・支出・残高を計算して表示
        private void UpdateSummary()
        {
            // records.Where(r => r.IsIncome)は「帳簿から収入の行だけ取り出す」、.Sum(r => r.Amount)はその金額を合計する
            // r => ... は「1件ずつ r と呼んで、こう判定・計算する」という書き方(ラムダ式)
            int income = records.Where(r => r.IsIncome).Sum(r => r.Amount);
            int expense = records.Where(r => !r.IsIncome).Sum(r => r.Amount);
            int balance = income - expense;

            summaryLabel.Text = $"収入 {income:N0}円 支出 {expense:N0}円 残高 {balance:N0}円";
        }

        // 月別の絞り込み集計
        // 画面にどんな部品があるか　

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
            
            foreach(var record in loadedRecords)
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
    }
}
