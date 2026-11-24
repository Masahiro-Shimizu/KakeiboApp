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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            guideLabel = new Label();
            yearSummaryLabel = new Label();
            shopLabel = new Label();
            shopTextBox = new TextBox();
            inputTableLayoutPanel = new TableLayoutPanel();
            updateButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recordsDataGridView).BeginInit();
            inputTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateLabel.Location = new Point(3, 0);
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
            menuStrip1.Size = new Size(2441, 67);
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
            categoryComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "食費", "生活用品費", "交際費", "交通費", "衣服費", "教養娯楽費", "医療費", "特別費", "通信費", "車両費", "住居費", "水道光熱費", "税金・社会保険料", "保険料", "給料", "年金", "その他の収入" });
            categoryComboBox.Location = new Point(477, 81);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(468, 73);
            categoryComboBox.TabIndex = 4;
            categoryComboBox.Enter += categoryComboBox_Enter;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Yu Gothic UI", 19.875F);
            categoryLabel.Location = new Point(477, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(218, 71);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "カテゴリー";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Font = new Font("Yu Gothic UI", 19.875F);
            memoLabel.Location = new Point(1899, 0);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new Size(106, 71);
            memoLabel.TabIndex = 8;
            memoLabel.Text = "メモ";
            // 
            // memoTextBox
            // 
            memoTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            memoTextBox.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            memoTextBox.Location = new Point(1899, 82);
            memoTextBox.Name = "memoTextBox";
            memoTextBox.Size = new Size(471, 71);
            memoTextBox.TabIndex = 9;
            memoTextBox.Enter += memoTextBox_Enter;
            // 
            // incomeRadioButton
            // 
            incomeRadioButton.AutoSize = true;
            incomeRadioButton.Font = new Font("Yu Gothic UI", 18F);
            incomeRadioButton.Location = new Point(23, 194);
            incomeRadioButton.Name = "incomeRadioButton";
            incomeRadioButton.Size = new Size(155, 69);
            incomeRadioButton.TabIndex = 10;
            incomeRadioButton.Text = "収入";
            incomeRadioButton.UseVisualStyleBackColor = true;
            incomeRadioButton.Enter += incomeRadioButton_Enter;
            // 
            // expenseRadioButton
            // 
            expenseRadioButton.AutoSize = true;
            expenseRadioButton.Checked = true;
            expenseRadioButton.Font = new Font("Yu Gothic UI", 18F);
            expenseRadioButton.Location = new Point(255, 194);
            expenseRadioButton.Name = "expenseRadioButton";
            expenseRadioButton.Size = new Size(155, 69);
            expenseRadioButton.TabIndex = 11;
            expenseRadioButton.TabStop = true;
            expenseRadioButton.Text = "支出";
            expenseRadioButton.UseVisualStyleBackColor = true;
            expenseRadioButton.Enter += incomeRadioButton_Enter;
            // 
            // recordsDataGridView
            // 
            recordsDataGridView.AllowUserToAddRows = false;
            recordsDataGridView.AllowUserToOrderColumns = true;
            recordsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recordsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            recordsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            recordsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            recordsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            recordsDataGridView.Location = new Point(23, 536);
            recordsDataGridView.Name = "recordsDataGridView";
            recordsDataGridView.ReadOnly = true;
            recordsDataGridView.RowHeadersWidth = 82;
            recordsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recordsDataGridView.Size = new Size(2361, 671);
            recordsDataGridView.TabIndex = 12;
            recordsDataGridView.CellClick += recordsDataGridView_CellClick;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.CalendarFont = new Font("Yu Gothic UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateTimePicker.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dateTimePicker.Location = new Point(3, 82);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(468, 71);
            dateTimePicker.TabIndex = 13;
            dateTimePicker.Enter += dateTimePicker_Enter;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            addButton.Location = new Point(2169, 439);
            addButton.Name = "addButton";
            addButton.Size = new Size(215, 76);
            addButton.TabIndex = 14;
            addButton.Text = "追加";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            addButton.Enter += addButton_Enter;
            // 
            // summaryLabel
            // 
            summaryLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            summaryLabel.Location = new Point(12, 1246);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(136, 71);
            summaryLabel.TabIndex = 15;
            summaryLabel.Text = "今月";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            amountLabel.Location = new Point(951, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(468, 71);
            amountLabel.TabIndex = 16;
            amountLabel.Text = "金額";
            // 
            // amountTextBox
            // 
            amountTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            amountTextBox.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            amountTextBox.Location = new Point(951, 82);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(468, 71);
            amountTextBox.TabIndex = 17;
            amountTextBox.Enter += amountTextBox_Enter;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            deleteButton.Location = new Point(1668, 438);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(225, 75);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "削除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // prevMonthButton
            // 
            prevMonthButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            prevMonthButton.Location = new Point(29, 436);
            prevMonthButton.Name = "prevMonthButton";
            prevMonthButton.Size = new Size(131, 78);
            prevMonthButton.TabIndex = 19;
            prevMonthButton.Text = "◀";
            prevMonthButton.UseVisualStyleBackColor = true;
            prevMonthButton.Click += prevMonthButton_Click;
            // 
            // monthPicker
            // 
            monthPicker.CalendarFont = new Font("Yu Gothic UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            monthPicker.CustomFormat = "yyyy年MM月";
            monthPicker.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            monthPicker.Format = DateTimePickerFormat.Custom;
            monthPicker.Location = new Point(203, 459);
            monthPicker.Name = "monthPicker";
            monthPicker.Size = new Size(223, 50);
            monthPicker.TabIndex = 20;
            monthPicker.ValueChanged += monthPicker_ValueChanged;
            // 
            // nextMonthButton
            // 
            nextMonthButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nextMonthButton.Location = new Point(480, 436);
            nextMonthButton.Name = "nextMonthButton";
            nextMonthButton.Size = new Size(131, 78);
            nextMonthButton.TabIndex = 21;
            nextMonthButton.Text = "▶";
            nextMonthButton.UseVisualStyleBackColor = true;
            nextMonthButton.Click += nextMonthButton_Click;
            // 
            // totalSummaryLabel
            // 
            totalSummaryLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            totalSummaryLabel.AutoSize = true;
            totalSummaryLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            totalSummaryLabel.Location = new Point(12, 1438);
            totalSummaryLabel.Name = "totalSummaryLabel";
            totalSummaryLabel.Size = new Size(189, 71);
            totalSummaryLabel.TabIndex = 22;
            totalSummaryLabel.Text = "全期間";
            // 
            // guideLabel
            // 
            guideLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guideLabel.BackColor = Color.Aquamarine;
            guideLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            guideLabel.Location = new Point(-60, 67);
            guideLabel.Name = "guideLabel";
            guideLabel.Size = new Size(2567, 106);
            guideLabel.TabIndex = 23;
            guideLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yearSummaryLabel
            // 
            yearSummaryLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            yearSummaryLabel.AutoSize = true;
            yearSummaryLabel.Font = new Font("Yu Gothic UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            yearSummaryLabel.Location = new Point(12, 1341);
            yearSummaryLabel.Name = "yearSummaryLabel";
            yearSummaryLabel.Size = new Size(136, 71);
            yearSummaryLabel.TabIndex = 24;
            yearSummaryLabel.Text = "今年";
            // 
            // shopLabel
            // 
            shopLabel.AutoSize = true;
            shopLabel.Font = new Font("Yu Gothic UI", 19.875F);
            shopLabel.Location = new Point(1425, 0);
            shopLabel.Name = "shopLabel";
            shopLabel.Size = new Size(126, 71);
            shopLabel.TabIndex = 25;
            shopLabel.Text = "お店";
            // 
            // shopTextBox
            // 
            shopTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            shopTextBox.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            shopTextBox.Location = new Point(1425, 82);
            shopTextBox.Name = "shopTextBox";
            shopTextBox.Size = new Size(468, 71);
            shopTextBox.TabIndex = 26;
            shopTextBox.Enter += shopTextBox_Enter;
            // 
            // inputTableLayoutPanel
            // 
            inputTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputTableLayoutPanel.ColumnCount = 5;
            inputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            inputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            inputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            inputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            inputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            inputTableLayoutPanel.Controls.Add(dateLabel, 0, 0);
            inputTableLayoutPanel.Controls.Add(shopTextBox, 3, 1);
            inputTableLayoutPanel.Controls.Add(categoryLabel, 1, 0);
            inputTableLayoutPanel.Controls.Add(amountLabel, 2, 0);
            inputTableLayoutPanel.Controls.Add(shopLabel, 3, 0);
            inputTableLayoutPanel.Controls.Add(memoLabel, 4, 0);
            inputTableLayoutPanel.Controls.Add(dateTimePicker, 0, 1);
            inputTableLayoutPanel.Controls.Add(categoryComboBox, 1, 1);
            inputTableLayoutPanel.Controls.Add(amountTextBox, 2, 1);
            inputTableLayoutPanel.Controls.Add(memoTextBox, 4, 1);
            inputTableLayoutPanel.Location = new Point(23, 269);
            inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            inputTableLayoutPanel.RowCount = 2;
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.Size = new Size(2373, 164);
            inputTableLayoutPanel.TabIndex = 27;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateButton.Enabled = false;
            updateButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            updateButton.Location = new Point(1922, 438);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(215, 76);
            updateButton.TabIndex = 28;
            updateButton.Text = "更新";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2441, 1556);
            Controls.Add(updateButton);
            Controls.Add(inputTableLayoutPanel);
            Controls.Add(yearSummaryLabel);
            Controls.Add(guideLabel);
            Controls.Add(totalSummaryLabel);
            Controls.Add(nextMonthButton);
            Controls.Add(monthPicker);
            Controls.Add(prevMonthButton);
            Controls.Add(deleteButton);
            Controls.Add(summaryLabel);
            Controls.Add(addButton);
            Controls.Add(recordsDataGridView);
            Controls.Add(expenseRadioButton);
            Controls.Add(incomeRadioButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(2467, 1627);
            Name = "MainForm";
            Text = "家計簿";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recordsDataGridView).EndInit();
            inputTableLayoutPanel.ResumeLayout(false);
            inputTableLayoutPanel.PerformLayout();
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
        private Label guideLabel;
        private Label yearSummaryLabel;
        private Label shopLabel;
        private TextBox shopTextBox;
        private TableLayoutPanel inputTableLayoutPanel;
        private Button updateButton;
    }
}
