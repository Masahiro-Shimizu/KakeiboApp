namespace KakeiboApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dateLabel = new Label();
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            categoryComboBox = new ComboBox();
            categoryLabel = new Label();
            memoLabel = new Label();
            memoTextBox = new TextBox();
            incomeRadioButton = new RadioButton();
            expenseRadioButton = new RadioButton();
            recordsDataGridView = new DataGridView();
            dateTimePicker = new DateTimePicker();
            addButton = new Button();
            summaryLabel = new Label();
            amountLabel = new Label();
            amountTextBox = new TextBox();
            deleteButton = new Button();
            prevMonthButton = new Button();
            monthPicker = new DateTimePicker();
            nextMonthButton = new Button();
            totalSummaryLabel = new Label();
            orderLabel = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recordsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateLabel.Location = new Point(24, 266);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(136, 71);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "日付";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, 設定ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2052, 67);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(168, 63);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(131, 63);
            設定ToolStripMenuItem.Text = "設定";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "食費", "日用品", "交通費", "光熱費", "通信費", "娯楽", "給料", "その他" });
            categoryComboBox.Location = new Point(657, 338);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(428, 73);
            categoryComboBox.TabIndex = 4;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Yu Gothic UI", 19.875F);
            categoryLabel.Location = new Point(657, 273);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(218, 71);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "カテゴリー";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Font = new Font("Yu Gothic UI", 19.875F);
            memoLabel.Location = new Point(1671, 264);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new Size(106, 71);
            memoLabel.TabIndex = 8;
            memoLabel.Text = "メモ";
            // 
            // memoTextBox
            // 
            memoTextBox.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            memoTextBox.Location = new Point(1671, 338);
            memoTextBox.Name = "memoTextBox";
            memoTextBox.Size = new Size(336, 71);
            memoTextBox.TabIndex = 9;
            // 
            // incomeRadioButton
            // 
            incomeRadioButton.AutoSize = true;
            incomeRadioButton.Font = new Font("Yu Gothic UI", 18F);
            incomeRadioButton.Location = new Point(31, 439);
            incomeRadioButton.Name = "incomeRadioButton";
            incomeRadioButton.Size = new Size(155, 69);
            incomeRadioButton.TabIndex = 10;
            incomeRadioButton.Text = "収入";
            incomeRadioButton.UseVisualStyleBackColor = true;
            // 
            // expenseRadioButton
            // 
            expenseRadioButton.AutoSize = true;
            expenseRadioButton.Checked = true;
            expenseRadioButton.Font = new Font("Yu Gothic UI", 18F);
            expenseRadioButton.Location = new Point(263, 439);
            expenseRadioButton.Name = "expenseRadioButton";
            expenseRadioButton.Size = new Size(155, 69);
            expenseRadioButton.TabIndex = 11;
            expenseRadioButton.TabStop = true;
            expenseRadioButton.Text = "支出";
            expenseRadioButton.UseVisualStyleBackColor = true;
            // 
            // recordsDataGridView
            // 
            recordsDataGridView.AllowUserToAddRows = false;
            recordsDataGridView.AllowUserToOrderColumns = true;
            recordsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recordsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            recordsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            recordsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Yu Gothic UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            recordsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            recordsDataGridView.Location = new Point(23, 665);
            recordsDataGridView.Name = "recordsDataGridView";
            recordsDataGridView.ReadOnly = true;
            recordsDataGridView.RowHeadersWidth = 82;
            recordsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recordsDataGridView.Size = new Size(1972, 661);
            recordsDataGridView.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Yu Gothic UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateTimePicker.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateTimePicker.Location = new Point(31, 340);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(512, 71);
            dateTimePicker.TabIndex = 13;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            addButton.Location = new Point(1780, 439);
            addButton.Name = "addButton";
            addButton.Size = new Size(227, 76);
            addButton.TabIndex = 14;
            addButton.Text = "追加";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // summaryLabel
            // 
            summaryLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            summaryLabel.Location = new Point(19, 1373);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(136, 71);
            summaryLabel.TabIndex = 15;
            summaryLabel.Text = "今月";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            amountLabel.Location = new Point(1204, 273);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(136, 71);
            amountLabel.TabIndex = 16;
            amountLabel.Text = "金額";
            // 
            // amountTextBox
            // 
            amountTextBox.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            amountTextBox.Location = new Point(1204, 340);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(360, 71);
            amountTextBox.TabIndex = 17;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            deleteButton.Location = new Point(1465, 439);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(225, 75);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "削除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // prevMonthButton
            // 
            prevMonthButton.Anchor = AnchorStyles.Top;
            prevMonthButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            prevMonthButton.Location = new Point(744, 549);
            prevMonthButton.Name = "prevMonthButton";
            prevMonthButton.Size = new Size(131, 75);
            prevMonthButton.TabIndex = 19;
            prevMonthButton.Text = "◀";
            prevMonthButton.UseVisualStyleBackColor = true;
            // 
            // monthPicker
            // 
            monthPicker.Anchor = AnchorStyles.Top;
            monthPicker.CustomFormat = "yyyy年MM月";
            monthPicker.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            monthPicker.Format = DateTimePickerFormat.Custom;
            monthPicker.Location = new Point(918, 569);
            monthPicker.Name = "monthPicker";
            monthPicker.Size = new Size(223, 50);
            monthPicker.TabIndex = 20;
            // 
            // nextMonthButton
            // 
            nextMonthButton.Anchor = AnchorStyles.Top;
            nextMonthButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nextMonthButton.Location = new Point(1195, 549);
            nextMonthButton.Name = "nextMonthButton";
            nextMonthButton.Size = new Size(131, 75);
            nextMonthButton.TabIndex = 21;
            nextMonthButton.Text = "▶";
            nextMonthButton.UseVisualStyleBackColor = true;
            // 
            // totalSummaryLabel
            // 
            totalSummaryLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            totalSummaryLabel.AutoSize = true;
            totalSummaryLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            totalSummaryLabel.Location = new Point(12, 1553);
            totalSummaryLabel.Name = "totalSummaryLabel";
            totalSummaryLabel.Size = new Size(189, 71);
            totalSummaryLabel.TabIndex = 22;
            totalSummaryLabel.Text = "全期間";
            // 
            // orderLabel
            // 
            orderLabel.BackColor = Color.Aquamarine;
            orderLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            orderLabel.Location = new Point(-59, 82);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(2178, 106);
            orderLabel.TabIndex = 23;
            orderLabel.Text = "ここで何をするか説明を入れる(例：日付を選択してください)";
            orderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2052, 1732);
            Controls.Add(orderLabel);
            Controls.Add(totalSummaryLabel);
            Controls.Add(nextMonthButton);
            Controls.Add(monthPicker);
            Controls.Add(prevMonthButton);
            Controls.Add(deleteButton);
            Controls.Add(amountTextBox);
            Controls.Add(amountLabel);
            Controls.Add(summaryLabel);
            Controls.Add(addButton);
            Controls.Add(dateTimePicker);
            Controls.Add(recordsDataGridView);
            Controls.Add(expenseRadioButton);
            Controls.Add(incomeRadioButton);
            Controls.Add(memoTextBox);
            Controls.Add(memoLabel);
            Controls.Add(categoryLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(dateLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "家計簿";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recordsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ComboBox categoryComboBox;
        private Label categoryLabel;
        private Label memoLabel;
        private TextBox memoTextBox;
        private RadioButton incomeRadioButton;
        private RadioButton expenseRadioButton;
        private DataGridView recordsDataGridView;
        private DateTimePicker dateTimePicker;
        private Button addButton;
        private Label summaryLabel;
        private Label amountLabel;
        private TextBox amountTextBox;
        private Button deleteButton;
        private Button prevMonthButton;
        private DateTimePicker monthPicker;
        private Button nextMonthButton;
        private Label totalSummaryLabel;
        private Label orderLabel;
    }
}
