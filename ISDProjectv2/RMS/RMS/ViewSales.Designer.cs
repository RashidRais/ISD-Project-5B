namespace RMS
{
    partial class ViewSales
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
            this.GridViewReport = new System.Windows.Forms.DataGridView();
            this.btnLoad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewReport
            // 
            this.GridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewReport.Location = new System.Drawing.Point(12, 75);
            this.GridViewReport.Name = "GridViewReport";
            this.GridViewReport.Size = new System.Drawing.Size(354, 238);
            this.GridViewReport.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Depth = 0;
            this.btnLoad.Location = new System.Drawing.Point(53, 329);
            this.btnLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Primary = true;
            this.btnLoad.Size = new System.Drawing.Size(124, 38);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(206, 329);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(117, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 387);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.GridViewReport);
            this.Name = "ViewSales";
            this.Text = "ViewSales";
            this.Load += new System.EventHandler(this.ViewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewReport;
        private MaterialSkin.Controls.MaterialRaisedButton btnLoad;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
    }
}