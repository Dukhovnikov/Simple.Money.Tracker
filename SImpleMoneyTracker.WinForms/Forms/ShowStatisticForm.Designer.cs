namespace SimpleMoneyTracker.WinForms
{
    partial class ShowStatisticForm
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
            this.radButtonAddTransaction = new Telerik.WinControls.UI.RadButton();
            this.radButtonAddCategory = new Telerik.WinControls.UI.RadButton();
            this.radTreeViewCategories = new Telerik.WinControls.UI.RadTreeView();
            this.radChartViewCategories = new Telerik.WinControls.UI.RadChartView();
            this.radLabelSpeedName = new Telerik.WinControls.UI.RadLabel();
            this.radLabelProjectName = new Telerik.WinControls.UI.RadLabel();
            this.radLabelCurrentBalance = new Telerik.WinControls.UI.RadLabel();
            this.radLabelSpend = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxSpend = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxCurrentBalance = new Telerik.WinControls.UI.RadTextBox();
            this.radRadialGaugeCurrentMoney = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc1 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc2 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle1 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeLabels1 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeSingleLabel1 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.radButtonShowSpendingGraph = new Telerik.WinControls.UI.RadButton();
            this.radButtonRemoveTransaction = new Telerik.WinControls.UI.RadButton();
            this.radButtonRemoveCategory = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radLabelDonutName = new Telerik.WinControls.UI.RadLabel();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartViewCategories)).BeginInit();
            this.radChartViewCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSpeedName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelProjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCurrentBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSpend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSpend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxCurrentBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGaugeCurrentMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonShowSpendingGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemoveTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemoveCategory)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDonutName)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonAddTransaction
            // 
            this.radButtonAddTransaction.AllowDrop = true;
            this.radButtonAddTransaction.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.radButtonAddTransaction.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radButtonAddTransaction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButtonAddTransaction.ForeColor = System.Drawing.Color.White;
            this.radButtonAddTransaction.Location = new System.Drawing.Point(25, 96);
            this.radButtonAddTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.radButtonAddTransaction.Name = "radButtonAddTransaction";
            this.radButtonAddTransaction.Size = new System.Drawing.Size(306, 51);
            this.radButtonAddTransaction.TabIndex = 0;
            this.radButtonAddTransaction.Text = "Добавить транзакцию";
            this.radButtonAddTransaction.Click += new System.EventHandler(this.radButtonAddTransaction_Click);
            // 
            // radButtonAddCategory
            // 
            this.radButtonAddCategory.AllowDrop = true;
            this.radButtonAddCategory.BackColor = System.Drawing.SystemColors.Highlight;
            this.radButtonAddCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButtonAddCategory.ForeColor = System.Drawing.Color.White;
            this.radButtonAddCategory.Location = new System.Drawing.Point(25, 163);
            this.radButtonAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.radButtonAddCategory.Name = "radButtonAddCategory";
            this.radButtonAddCategory.Size = new System.Drawing.Size(306, 51);
            this.radButtonAddCategory.TabIndex = 1;
            this.radButtonAddCategory.Text = "Добавить категорию";
            this.radButtonAddCategory.Click += new System.EventHandler(this.radButtonAddCategory_Click);
            // 
            // radTreeViewCategories
            // 
            this.radTreeViewCategories.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radTreeViewCategories.ItemHeight = 25;
            this.radTreeViewCategories.Location = new System.Drawing.Point(361, 96);
            this.radTreeViewCategories.Margin = new System.Windows.Forms.Padding(4);
            this.radTreeViewCategories.Name = "radTreeViewCategories";
            // 
            // 
            // 
            this.radTreeViewCategories.RootElement.BorderHighlightColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radTreeViewCategories.RootElement.BorderHighlightThickness = 1;
            this.radTreeViewCategories.Size = new System.Drawing.Size(357, 562);
            this.radTreeViewCategories.SpacingBetweenNodes = -1;
            this.radTreeViewCategories.TabIndex = 2;
            this.radTreeViewCategories.TreeIndent = 24;
            this.radTreeViewCategories.SelectedNodeChanged += new Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(this.radTreeViewCategories_SelectedNodeChanged);
            // 
            // radChartViewCategories
            // 
            this.radChartViewCategories.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            this.radChartViewCategories.Controls.Add(this.radLabelSpeedName);
            this.radChartViewCategories.Location = new System.Drawing.Point(752, 123);
            this.radChartViewCategories.Margin = new System.Windows.Forms.Padding(4);
            this.radChartViewCategories.Name = "radChartViewCategories";
            this.radChartViewCategories.ShowGrid = false;
            this.radChartViewCategories.ShowPanZoom = true;
            this.radChartViewCategories.ShowToolTip = true;
            this.radChartViewCategories.ShowTrackBall = true;
            this.radChartViewCategories.Size = new System.Drawing.Size(343, 312);
            this.radChartViewCategories.TabIndex = 3;
            // 
            // radLabelSpeedName
            // 
            this.radLabelSpeedName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabelSpeedName.Location = new System.Drawing.Point(89, 279);
            this.radLabelSpeedName.Name = "radLabelSpeedName";
            this.radLabelSpeedName.Size = new System.Drawing.Size(169, 30);
            this.radLabelSpeedName.TabIndex = 8;
            this.radLabelSpeedName.Text = "Доступно средств";
            // 
            // radLabelProjectName
            // 
            this.radLabelProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelProjectName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radLabelProjectName.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelProjectName.Location = new System.Drawing.Point(13, 9);
            this.radLabelProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.radLabelProjectName.Name = "radLabelProjectName";
            this.radLabelProjectName.Size = new System.Drawing.Size(272, 41);
            this.radLabelProjectName.TabIndex = 4;
            this.radLabelProjectName.Text = "Название проекта";
            // 
            // radLabelCurrentBalance
            // 
            this.radLabelCurrentBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelCurrentBalance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radLabelCurrentBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabelCurrentBalance.Location = new System.Drawing.Point(717, 0);
            this.radLabelCurrentBalance.Margin = new System.Windows.Forms.Padding(4);
            this.radLabelCurrentBalance.Name = "radLabelCurrentBalance";
            this.radLabelCurrentBalance.Size = new System.Drawing.Size(155, 30);
            this.radLabelCurrentBalance.TabIndex = 4;
            this.radLabelCurrentBalance.Text = "Текущий баланс";
            this.radLabelCurrentBalance.Click += new System.EventHandler(this.radLabelCurrentBalance_Click);
            // 
            // radLabelSpend
            // 
            this.radLabelSpend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelSpend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radLabelSpend.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabelSpend.ForeColor = System.Drawing.Color.DimGray;
            this.radLabelSpend.Location = new System.Drawing.Point(779, 33);
            this.radLabelSpend.Margin = new System.Windows.Forms.Padding(4);
            this.radLabelSpend.Name = "radLabelSpend";
            this.radLabelSpend.Size = new System.Drawing.Size(108, 30);
            this.radLabelSpend.TabIndex = 4;
            this.radLabelSpend.Text = "Потрачено";
            // 
            // radTextBoxSpend
            // 
            this.radTextBoxSpend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTextBoxSpend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radTextBoxSpend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radTextBoxSpend.Location = new System.Drawing.Point(918, 36);
            this.radTextBoxSpend.Margin = new System.Windows.Forms.Padding(4);
            this.radTextBoxSpend.Name = "radTextBoxSpend";
            this.radTextBoxSpend.Size = new System.Drawing.Size(164, 27);
            this.radTextBoxSpend.TabIndex = 6;
            // 
            // radTextBoxCurrentBalance
            // 
            this.radTextBoxCurrentBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTextBoxCurrentBalance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radTextBoxCurrentBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radTextBoxCurrentBalance.Location = new System.Drawing.Point(918, 1);
            this.radTextBoxCurrentBalance.Margin = new System.Windows.Forms.Padding(4);
            this.radTextBoxCurrentBalance.Name = "radTextBoxCurrentBalance";
            this.radTextBoxCurrentBalance.Size = new System.Drawing.Size(164, 31);
            this.radTextBoxCurrentBalance.TabIndex = 6;
            // 
            // radRadialGaugeCurrentMoney
            // 
            this.radRadialGaugeCurrentMoney.BackColor = System.Drawing.Color.White;
            this.radRadialGaugeCurrentMoney.CausesValidation = false;
            this.radRadialGaugeCurrentMoney.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc1,
            this.radialGaugeArc2,
            this.radialGaugeNeedle1,
            this.radialGaugeLabels1,
            this.radialGaugeSingleLabel1});
            this.radRadialGaugeCurrentMoney.Location = new System.Drawing.Point(752, 484);
            this.radRadialGaugeCurrentMoney.Margin = new System.Windows.Forms.Padding(4);
            this.radRadialGaugeCurrentMoney.Name = "radRadialGaugeCurrentMoney";
            this.radRadialGaugeCurrentMoney.RangeEnd = 50D;
            this.radRadialGaugeCurrentMoney.Size = new System.Drawing.Size(343, 312);
            this.radRadialGaugeCurrentMoney.StartAngle = 205D;
            this.radRadialGaugeCurrentMoney.SweepAngle = 130D;
            this.radRadialGaugeCurrentMoney.TabIndex = 6;
            this.radRadialGaugeCurrentMoney.Text = "Доступно средств";
            this.radRadialGaugeCurrentMoney.Value = 33.33F;
            // 
            // radialGaugeArc1
            // 
            this.radialGaugeArc1.BackColor = System.Drawing.Color.Black;
            this.radialGaugeArc1.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc1.BindEndRange = true;
            this.radialGaugeArc1.Name = "radialGaugeArc1";
            this.radialGaugeArc1.RangeEnd = 33.330001831054688D;
            this.radialGaugeArc1.Width = 40D;
            // 
            // radialGaugeArc2
            // 
            this.radialGaugeArc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radialGaugeArc2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radialGaugeArc2.BindStartRange = true;
            this.radialGaugeArc2.Name = "radialGaugeArc2";
            this.radialGaugeArc2.RangeEnd = 50D;
            this.radialGaugeArc2.RangeStart = 33.330001831054688D;
            this.radialGaugeArc2.Width = 40D;
            // 
            // radialGaugeNeedle1
            // 
            this.radialGaugeNeedle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radialGaugeNeedle1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radialGaugeNeedle1.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle1.BindValue = true;
            this.radialGaugeNeedle1.InnerPointRadiusPercentage = 4D;
            this.radialGaugeNeedle1.LenghtPercentage = 115D;
            this.radialGaugeNeedle1.Name = "radialGaugeNeedle1";
            this.radialGaugeNeedle1.Thickness = 0.7D;
            this.radialGaugeNeedle1.Value = 33.33F;
            // 
            // radialGaugeLabels1
            // 
            this.radialGaugeLabels1.DrawText = false;
            this.radialGaugeLabels1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels1.LabelFontSize = 5F;
            this.radialGaugeLabels1.LabelRadiusPercentage = 112F;
            this.radialGaugeLabels1.LabelsCount = 1;
            this.radialGaugeLabels1.Name = "radialGaugeLabels1";
            // 
            // radialGaugeSingleLabel1
            // 
            this.radialGaugeSingleLabel1.BindValue = true;
            this.radialGaugeSingleLabel1.LabelFontSize = 11F;
            this.radialGaugeSingleLabel1.LabelFormat = "n2";
            this.radialGaugeSingleLabel1.LabelText = "Text";
            this.radialGaugeSingleLabel1.LocationPercentage = new System.Drawing.SizeF(0F, 0.25F);
            this.radialGaugeSingleLabel1.Name = "radialGaugeSingleLabel1";
            // 
            // radButtonShowSpendingGraph
            // 
            this.radButtonShowSpendingGraph.AllowDrop = true;
            this.radButtonShowSpendingGraph.BackColor = System.Drawing.SystemColors.Highlight;
            this.radButtonShowSpendingGraph.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButtonShowSpendingGraph.ForeColor = System.Drawing.Color.White;
            this.radButtonShowSpendingGraph.Location = new System.Drawing.Point(361, 716);
            this.radButtonShowSpendingGraph.Margin = new System.Windows.Forms.Padding(4);
            this.radButtonShowSpendingGraph.Name = "radButtonShowSpendingGraph";
            this.radButtonShowSpendingGraph.Size = new System.Drawing.Size(357, 51);
            this.radButtonShowSpendingGraph.TabIndex = 1;
            this.radButtonShowSpendingGraph.Text = "Отобразить в виде графика";
            this.radButtonShowSpendingGraph.Click += new System.EventHandler(this.radButtonShowSpendingGraph_Click);
            // 
            // radButtonRemoveTransaction
            // 
            this.radButtonRemoveTransaction.AllowDrop = true;
            this.radButtonRemoveTransaction.BackColor = System.Drawing.SystemColors.Highlight;
            this.radButtonRemoveTransaction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButtonRemoveTransaction.ForeColor = System.Drawing.Color.White;
            this.radButtonRemoveTransaction.Location = new System.Drawing.Point(25, 230);
            this.radButtonRemoveTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.radButtonRemoveTransaction.Name = "radButtonRemoveTransaction";
            this.radButtonRemoveTransaction.Size = new System.Drawing.Size(306, 51);
            this.radButtonRemoveTransaction.TabIndex = 0;
            this.radButtonRemoveTransaction.Text = "Удалить транзакцию";
            this.radButtonRemoveTransaction.Click += new System.EventHandler(this.radButtonRemoveTransaction_Click);
            // 
            // radButtonRemoveCategory
            // 
            this.radButtonRemoveCategory.AllowDrop = true;
            this.radButtonRemoveCategory.BackColor = System.Drawing.SystemColors.Highlight;
            this.radButtonRemoveCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButtonRemoveCategory.ForeColor = System.Drawing.Color.White;
            this.radButtonRemoveCategory.Location = new System.Drawing.Point(25, 296);
            this.radButtonRemoveCategory.Margin = new System.Windows.Forms.Padding(4);
            this.radButtonRemoveCategory.Name = "radButtonRemoveCategory";
            this.radButtonRemoveCategory.Size = new System.Drawing.Size(307, 51);
            this.radButtonRemoveCategory.TabIndex = 1;
            this.radButtonRemoveCategory.Text = "Удалить категорию";
            this.radButtonRemoveCategory.Click += new System.EventHandler(this.radButtonRemoveCategory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.radLabelSpend);
            this.panel1.Controls.Add(this.radTextBoxSpend);
            this.panel1.Controls.Add(this.radTextBoxCurrentBalance);
            this.panel1.Controls.Add(this.radLabelCurrentBalance);
            this.panel1.Controls.Add(this.radLabelProjectName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 68);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radLabelDonutName
            // 
            this.radLabelDonutName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radLabelDonutName.Location = new System.Drawing.Point(830, 83);
            this.radLabelDonutName.Name = "radLabelDonutName";
            this.radLabelDonutName.Size = new System.Drawing.Size(207, 30);
            this.radLabelDonutName.TabIndex = 8;
            this.radLabelDonutName.Text = "Диаграмма категорий";
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Location = new System.Drawing.Point(20, 779);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(97, 25);
            this.linkLabelAbout.TabIndex = 9;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "linkLabel1";
            // 
            // ShowStatisticForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1126, 813);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.radLabelDonutName);
            this.Controls.Add(this.radButtonShowSpendingGraph);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radRadialGaugeCurrentMoney);
            this.Controls.Add(this.radChartViewCategories);
            this.Controls.Add(this.radTreeViewCategories);
            this.Controls.Add(this.radButtonRemoveCategory);
            this.Controls.Add(this.radButtonAddCategory);
            this.Controls.Add(this.radButtonRemoveTransaction);
            this.Controls.Add(this.radButtonAddTransaction);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ShowStatisticForm";
            this.Text = "Simple Money Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartViewCategories)).EndInit();
            this.radChartViewCategories.ResumeLayout(false);
            this.radChartViewCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSpeedName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelProjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCurrentBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSpend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSpend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxCurrentBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGaugeCurrentMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonShowSpendingGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemoveTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemoveCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDonutName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonAddTransaction;
        private Telerik.WinControls.UI.RadButton radButtonAddCategory;
        private Telerik.WinControls.UI.RadTreeView radTreeViewCategories;
        private Telerik.WinControls.UI.RadChartView radChartViewCategories;
        private Telerik.WinControls.UI.RadLabel radLabelProjectName;
        private Telerik.WinControls.UI.RadLabel radLabelCurrentBalance;
        private Telerik.WinControls.UI.RadLabel radLabelSpend;
        private Telerik.WinControls.UI.RadTextBox radTextBoxSpend;
        private Telerik.WinControls.UI.RadTextBox radTextBoxCurrentBalance;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGaugeCurrentMoney;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc2;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel1;
        private Telerik.WinControls.UI.RadButton radButtonShowSpendingGraph;
        private Telerik.WinControls.UI.RadButton radButtonRemoveTransaction;
        private Telerik.WinControls.UI.RadButton radButtonRemoveCategory;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadLabel radLabelSpeedName;
        private Telerik.WinControls.UI.RadLabel radLabelDonutName;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
    }
}