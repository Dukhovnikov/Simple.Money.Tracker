namespace SimpleMoneyTracker.WinForms
{
    partial class AddTransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTransactionAmount = new System.Windows.Forms.TextBox();
            this.comboBoxSelectCategory = new System.Windows.Forms.ComboBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.monthCalendarForTransaction = new System.Windows.Forms.MonthCalendar();
            this.textBoxTransactionComment = new System.Windows.Forms.TextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButtonAddTransaction = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTransactionAmount
            // 
            this.textBoxTransactionAmount.Location = new System.Drawing.Point(154, 78);
            this.textBoxTransactionAmount.Name = "textBoxTransactionAmount";
            this.textBoxTransactionAmount.Size = new System.Drawing.Size(225, 29);
            this.textBoxTransactionAmount.TabIndex = 1;
            // 
            // comboBoxSelectCategory
            // 
            this.comboBoxSelectCategory.FormattingEnabled = true;
            this.comboBoxSelectCategory.Location = new System.Drawing.Point(154, 123);
            this.comboBoxSelectCategory.Name = "comboBoxSelectCategory";
            this.comboBoxSelectCategory.Size = new System.Drawing.Size(225, 29);
            this.comboBoxSelectCategory.TabIndex = 2;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel2.Location = new System.Drawing.Point(85, 76);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(71, 31);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Сумма";
            this.radLabel2.ThemeName = "ControlDefault";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel3.Location = new System.Drawing.Point(52, 123);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(105, 31);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Категория";
            this.radLabel3.ThemeName = "ControlDefault";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel4.Location = new System.Drawing.Point(101, 169);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(53, 31);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "Дата";
            this.radLabel4.ThemeName = "ControlDefault";
            // 
            // monthCalendarForTransaction
            // 
            this.monthCalendarForTransaction.Location = new System.Drawing.Point(152, 165);
            this.monthCalendarForTransaction.Name = "monthCalendarForTransaction";
            this.monthCalendarForTransaction.TabIndex = 3;
            // 
            // textBoxTransactionComment
            // 
            this.textBoxTransactionComment.Location = new System.Drawing.Point(152, 348);
            this.textBoxTransactionComment.Multiline = true;
            this.textBoxTransactionComment.Name = "textBoxTransactionComment";
            this.textBoxTransactionComment.Size = new System.Drawing.Size(227, 104);
            this.textBoxTransactionComment.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel1.Location = new System.Drawing.Point(17, 351);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(139, 31);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Комментарий";
            this.radLabel1.ThemeName = "ControlDefault";
            // 
            // radButtonAddTransaction
            // 
            this.radButtonAddTransaction.BackColor = System.Drawing.SystemColors.Highlight;
            this.radButtonAddTransaction.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonAddTransaction.ForeColor = System.Drawing.Color.White;
            this.radButtonAddTransaction.Location = new System.Drawing.Point(152, 467);
            this.radButtonAddTransaction.Name = "radButtonAddTransaction";
            this.radButtonAddTransaction.Size = new System.Drawing.Size(151, 42);
            this.radButtonAddTransaction.TabIndex = 4;
            this.radButtonAddTransaction.TabStop = false;
            this.radButtonAddTransaction.Text = "Сохранить";
            this.radButtonAddTransaction.Click += new System.EventHandler(this.radButtonAddTransaction_Click);
            // 
            // radLabel5
            // 
            this.radLabel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(90, 5);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(264, 34);
            this.radLabel5.TabIndex = 1;
            this.radLabel5.Text = "Добавление транзакции";
            this.radLabel5.ThemeName = "ControlDefault";
            this.radLabel5.Click += new System.EventHandler(this.radLabel5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 45);
            this.panel1.TabIndex = 5;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(440, 533);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radButtonAddTransaction);
            this.Controls.Add(this.monthCalendarForTransaction);
            this.Controls.Add(this.comboBoxSelectCategory);
            this.Controls.Add(this.textBoxTransactionComment);
            this.Controls.Add(this.textBoxTransactionAmount);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTransactionForm";
            this.Text = "Добавление транзакции";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTransactionAmount;
        private System.Windows.Forms.ComboBox comboBoxSelectCategory;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.MonthCalendar monthCalendarForTransaction;
        private System.Windows.Forms.TextBox textBoxTransactionComment;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButtonAddTransaction;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.Panel panel1;
    }
}