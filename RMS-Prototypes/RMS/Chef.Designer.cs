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
            this.gridDisplay.Location = new System.Drawing.Point(71, 146);
            this.gridDisplay.Name = "gridDisplay";
            this.gridDisplay.RowTemplate.Height = 33;
            this.gridDisplay.Size = new System.Drawing.Size(576, 333);
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
            this.btnConfirm.Location = new System.Drawing.Point(801, 413);
            this.btnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Primary = true;
            this.btnConfirm.Size = new System.Drawing.Size(150, 66);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtTime
            // 
            this.txtTime.Depth = 0;
            this.txtTime.Hint = "";
            this.txtTime.Location = new System.Drawing.Point(704, 329);
            this.txtTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTime.Name = "txtTime";
            this.txtTime.PasswordChar = '\0';
            this.txtTime.SelectedText = "";
            this.txtTime.SelectionLength = 0;
            this.txtTime.SelectionStart = 0;
            this.txtTime.Size = new System.Drawing.Size(247, 41);
            this.txtTime.TabIndex = 2;
            this.txtTime.UseSystemPasswordChar = false;
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 670);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gridDisplay);
            this.Name = "Chef";
            this.Text = "Chef";
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn food;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfirm;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTime;
    }
}