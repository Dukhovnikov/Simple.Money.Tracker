namespace SImpleMoneyTracker.WinForms
{
    partial class ShowSpendingGraphForm
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.radChartViewSpendingGraph = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.radChartViewSpendingGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // radChartViewSpendingGraph
            // 
            this.radChartViewSpendingGraph.AreaDesign = cartesianArea1;
            this.radChartViewSpendingGraph.Location = new System.Drawing.Point(12, 12);
            this.radChartViewSpendingGraph.Name = "radChartViewSpendingGraph";
            this.radChartViewSpendingGraph.ShowGrid = false;
            this.radChartViewSpendingGraph.Size = new System.Drawing.Size(1176, 320);
            this.radChartViewSpendingGraph.TabIndex = 0;
            // 
            // ShowSpendingGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 372);
            this.Controls.Add(this.radChartViewSpendingGraph);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShowSpendingGraphForm";
            this.Text = "ShowSpendingGraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.radChartViewSpendingGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartViewSpendingGraph;
    }
}