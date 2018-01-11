namespace RMS
{
    partial class Admin
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
            this.lblMsg = new MaterialSkin.Controls.MaterialLabel();
            this.btnUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLogout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Depth = 0;
            this.lblMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(172, 41);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 19);
            this.lblMsg.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.Depth = 0;
            this.btnUser.Location = new System.Drawing.Point(16, 83);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUser.Name = "btnUser";
            this.btnUser.Primary = true;
            this.btnUser.Size = new System.Drawing.Size(110, 62);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Add User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Depth = 0;
            this.btnEdit.Location = new System.Drawing.Point(16, 158);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = true;
            this.btnEdit.Size = new System.Drawing.Size(110, 62);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Menu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Depth = 0;
            this.btnLogout.Location = new System.Drawing.Point(92, 243);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Primary = true;
            this.btnLogout.Size = new System.Drawing.Size(110, 62);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(176, 83);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(110, 62);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "View Sales";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(176, 158);
            this.materialRaisedButton3.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(110, 62);
            this.materialRaisedButton3.TabIndex = 8;
            this.materialRaisedButton3.Text = "Order Details";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(302, 316);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.lblMsg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblMsg;
        private MaterialSkin.Controls.MaterialRaisedButton btnUser;
        private MaterialSkin.Controls.MaterialRaisedButton btnEdit;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogout;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
    }
}