namespace SimpleMoneyTracker.WinForms
{
    partial class CreateProjectForm
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
            this.radButtonCreateProject = new Telerik.WinControls.UI.RadButton();
            this.radTextBoxProjectName = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxProjectBalance = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCreateProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxProjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxProjectBalance)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radButtonCreateProject
            // 
            this.radButtonCreateProject.BackColor = System.Drawing.SystemColors.Highlight;
            this.radButtonCreateProject.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonCreateProject.ForeColor = System.Drawing.Color.White;
            this.radButtonCreateProject.Location = new System.Drawing.Point(147, 235);
            this.radButtonCreateProject.Name = "radButtonCreateProject";
            this.radButtonCreateProject.Size = new System.Drawing.Size(140, 37);
            this.radButtonCreateProject.TabIndex = 0;
            this.radButtonCreateProject.Text = "Создать";
            this.radButtonCreateProject.Click += new System.EventHandler(this.radButtonCreateProject_Click);
            // 
            // radTextBoxProjectName
            // 
            this.radTextBoxProjectName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radTextBoxProjectName.Location = new System.Drawing.Point(78, 110);
            this.radTextBoxProjectName.Name = "radTextBoxProjectName";
            this.radTextBoxProjectName.Size = new System.Drawing.Size(291, 31);
            this.radTextBoxProjectName.TabIndex = 1;
            this.radTextBoxProjectName.Text = "Новый проект";
            // 
            // radTextBoxProjectBalance
            // 
            this.radTextBoxProjectBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radTextBoxProjectBalance.Location = new System.Drawing.Point(78, 182);
            this.radTextBoxProjectBalance.Name = "radTextBoxProjectBalance";
            this.radTextBoxProjectBalance.Size = new System.Drawing.Size(291, 31);
            this.radTextBoxProjectBalance.TabIndex = 1;
            this.radTextBoxProjectBalance.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите название проекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите бюджет проекта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Создание проекта";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 56);
            this.panel1.TabIndex = 5;
            // 
            // CreateProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(442, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radTextBoxProjectBalance);
            this.Controls.Add(this.radTextBoxProjectName);
            this.Controls.Add(this.radButtonCreateProject);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateProjectForm";
            this.Text = "Создание проекта";
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCreateProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxProjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxProjectBalance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonCreateProject;
        private Telerik.WinControls.UI.RadTextBox radTextBoxProjectName;
        private Telerik.WinControls.UI.RadTextBox radTextBoxProjectBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}