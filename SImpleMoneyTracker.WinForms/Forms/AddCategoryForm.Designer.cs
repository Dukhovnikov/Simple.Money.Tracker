namespace SImpleMoneyTracker.WinForms.Forms
{
    partial class AddCategoryForm
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
            this.radButtonAddCategory = new Telerik.WinControls.UI.RadButton();
            this.radTextBoxCategoryName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxCategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonAddCategory
            // 
            this.radButtonAddCategory.BackColor = System.Drawing.SystemColors.Highlight;
            this.radButtonAddCategory.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonAddCategory.ForeColor = System.Drawing.Color.White;
            this.radButtonAddCategory.Location = new System.Drawing.Point(135, 156);
            this.radButtonAddCategory.Name = "radButtonAddCategory";
            this.radButtonAddCategory.Size = new System.Drawing.Size(167, 38);
            this.radButtonAddCategory.TabIndex = 0;
            this.radButtonAddCategory.Text = "Сохранить";
            this.radButtonAddCategory.Click += new System.EventHandler(this.radButtonAddCategory_Click);
            // 
            // radTextBoxCategoryName
            // 
            this.radTextBoxCategoryName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radTextBoxCategoryName.Location = new System.Drawing.Point(49, 109);
            this.radTextBoxCategoryName.Name = "radTextBoxCategoryName";
            this.radTextBoxCategoryName.Size = new System.Drawing.Size(336, 31);
            this.radTextBoxCategoryName.TabIndex = 2;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel1.Location = new System.Drawing.Point(83, 77);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(266, 30);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Введите название категории";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabel2.Location = new System.Drawing.Point(104, 4);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(238, 33);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Добавление категории";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 41);
            this.panel1.TabIndex = 4;
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(440, 235);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radTextBoxCategoryName);
            this.Controls.Add(this.radButtonAddCategory);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddCategoryForm";
            this.Text = "Добавление категорию";
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxCategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonAddCategory;
        private Telerik.WinControls.UI.RadTextBox radTextBoxCategoryName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.Panel panel1;
    }
}