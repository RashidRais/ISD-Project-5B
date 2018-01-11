namespace RMS
{
    partial class Chef
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
            this.gridDisplay = new System.Windows.Forms.DataGridView();
            this.food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtTime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDecline = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDisplay
            // 
            this.gridDisplay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.food,
            this.quantity});
            this.gridDisplay.Location = new System.Drawing.Point(36, 76);
            this.gridDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.gridDisplay.Name = "gridDisplay";
            this.gridDisplay.RowTemplate.Height = 33;
            this.gridDisplay.Size = new System.Drawing.Size(288, 173);
            this.gridDisplay.TabIndex = 0;
            // 
            // food
            // 
            this.food.HeaderText = "Food Item";
            this.food.Name = "food";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Depth = 0;
            this.btnConfirm.Location = new System.Drawing.Point(352, 170);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Primary = true;
            this.btnConfirm.Size = new System.Drawing.Size(124, 34);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtTime
            // 
            this.txtTime.Depth = 0;
            this.txtTime.Hint = "";
            this.txtTime.Location = new System.Drawing.Point(352, 122);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTime.Name = "txtTime";
            this.txtTime.PasswordChar = '\0';
            this.txtTime.SelectedText = "";
            this.txtTime.SelectionLength = 0;
            this.txtTime.SelectionStart = 0;
            this.txtTime.Size = new System.Drawing.Size(124, 23);
            this.txtTime.TabIndex = 2;
            this.txtTime.UseSystemPasswordChar = false;
            // 
            // btnDecline
            // 
            this.btnDecline.Depth = 0;
            this.btnDecline.Location = new System.Drawing.Point(352, 215);
            this.btnDecline.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Primary = true;
            this.btnDecline.Size = new System.Drawing.Size(124, 34);
            this.btnDecline.TabIndex = 3;
            this.btnDecline.Text = "Decline Order";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(348, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Enter Time";
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 286);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gridDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chef";
            this.Text = "Chef";
            this.Load += new System.EventHandler(this.Chef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn food;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfirm;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTime;
        private MaterialSkin.Controls.MaterialRaisedButton btnDecline;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}