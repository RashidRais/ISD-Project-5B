namespace RMS
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSignIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(137, 150);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(163, 37);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "User Name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(151, 227);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(149, 37);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Password";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Depth = 0;
            this.btnSignIn.Location = new System.Drawing.Point(233, 298);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Primary = true;
            this.btnSignIn.Size = new System.Drawing.Size(160, 48);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Login";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Depth = 0;
            this.btnClose.Location = new System.Drawing.Point(411, 298);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Primary = true;
            this.btnClose.Size = new System.Drawing.Size(160, 48);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUser
            // 
            this.txtUser.Depth = 0;
            this.txtUser.Hint = "";
            this.txtUser.Location = new System.Drawing.Point(306, 150);
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(338, 41);
            this.txtUser.TabIndex = 0;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.Depth = 0;
            this.txtPass.Hint = "";
            this.txtPass.Location = new System.Drawing.Point(306, 223);
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(338, 41);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // LoginForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(796, 409);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Sizable = false;
            this.Text = "Welcome To Restaurant Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnSignIn;
        private MaterialSkin.Controls.MaterialRaisedButton btnClose;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
    }
}

