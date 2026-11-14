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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recordsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateLabel.Location = new Point(12, 60);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(84, 45);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "日付";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, 設定ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1615, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(102, 36);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(82, 36);
            設定ToolStripMenuItem.Text = "設定";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "食費", "日用品", "交通費", "光熱費", "通信費", "娯楽", "給料", "その他" });
            categoryComboBox.Location = new Point(381, 107);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(428, 53);
            categoryComboBox.TabIndex = 4;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            categoryLabel.Location = new Point(381, 60);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(134, 45);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "カテゴリー";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            memoLabel.Location = new Point(1211, 59);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new Size(67, 45);
            memoLabel.TabIndex = 8;
            memoLabel.Text = "メモ";
            // 
            // memoTextBox
            // 
            memoTextBox.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            memoTextBox.Location = new Point(1221, 107);
            memoTextBox.Name = "memoTextBox";
            memoTextBox.Size = new Size(336, 50);
            memoTextBox.TabIndex = 9;
            // 
            // incomeRadioButton
            // 
            incomeRadioButton.AutoSize = true;
            incomeRadioButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            incomeRadioButton.Location = new Point(23, 184);
            incomeRadioButton.Name = "incomeRadioButton";
            incomeRadioButton.Size = new Size(115, 49);
            incomeRadioButton.TabIndex = 10;
            incomeRadioButton.Text = "収入";
            incomeRadioButton.UseVisualStyleBackColor = true;
            // 
            // expenseRadioButton
            // 
            expenseRadioButton.AutoSize = true;
            expenseRadioButton.Checked = true;
            expenseRadioButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            expenseRadioButton.Location = new Point(156, 184);
            expenseRadioButton.Name = "expenseRadioButton";
            expenseRadioButton.Size = new Size(115, 49);
            expenseRadioButton.TabIndex = 11;
            expenseRadioButton.TabStop = true;
            expenseRadioButton.Text = "支出";
            expenseRadioButton.UseVisualStyleBackColor = true;
            // 
            // recordsDataGridView
            // 
            recordsDataGridView.AllowUserToAddRows = false;
            recordsDataGridView.AllowUserToOrderColumns = true;
            recordsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recordsDataGridView.Location = new Point(23, 253);
            recordsDataGridView.Name = "recordsDataGridView";
            recordsDataGridView.ReadOnly = true;
            recordsDataGridView.RowHeadersWidth = 82;
            recordsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recordsDataGridView.Size = new Size(1534, 533);
            recordsDataGridView.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Yu Gothic UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateTimePicker.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateTimePicker.Location = new Point(23, 107);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(340, 50);
            dateTimePicker.TabIndex = 13;
            // 
            // addButton
            // 
            addButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            addButton.Location = new Point(1343, 184);
            addButton.Name = "addButton";
            addButton.Size = new Size(214, 58);
            addButton.TabIndex = 14;
            addButton.Text = "追加";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            summaryLabel.Location = new Point(23, 811);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(84, 45);
            summaryLabel.TabIndex = 15;
            summaryLabel.Text = "合計";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            amountLabel.Location = new Point(829, 59);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(84, 45);
            amountLabel.TabIndex = 16;
            amountLabel.Text = "金額";
            // 
            // amountTextBox
            // 
            amountTextBox.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            amountTextBox.Location = new Point(838, 107);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(360, 50);
            amountTextBox.TabIndex = 17;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            deleteButton.Location = new Point(1096, 183);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(195, 57);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "削除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 985);
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
    }
}
