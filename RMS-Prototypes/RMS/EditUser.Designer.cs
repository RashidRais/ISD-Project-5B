namespace RMS
{
    partial class EditUser
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnLoadUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInsert = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gridUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 86);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "User Name";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtType.Depth = 0;
            this.txtType.Hint = "";
            this.txtType.Location = new System.Drawing.Point(140, 142);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.SelectedText = "";
            this.txtType.SelectionLength = 0;
            this.txtType.SelectionStart = 0;
            this.txtType.Size = new System.Drawing.Size(187, 23);
            this.txtType.TabIndex = 6;
            this.txtType.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPass.Depth = 0;
            this.txtPass.Hint = "";
            this.txtPass.Location = new System.Drawing.Point(140, 113);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(187, 23);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 142);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(41, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Type";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(140, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(187, 23);
            this.txtName.TabIndex = 3;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 113);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Password";
            // 
            // btnLoadUser
            // 
            this.btnLoadUser.Depth = 0;
            this.btnLoadUser.Location = new System.Drawing.Point(169, 186);
            this.btnLoadUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadUser.Name = "btnLoadUser";
            this.btnLoadUser.Primary = true;
            this.btnLoadUser.Size = new System.Drawing.Size(63, 34);
            this.btnLoadUser.TabIndex = 11;
            this.btnLoadUser.Text = "Load";
            this.btnLoadUser.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Depth = 0;
            this.btnInsert.Location = new System.Drawing.Point(37, 186);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Primary = true;
            this.btnInsert.Size = new System.Drawing.Size(63, 34);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDel
            // 
            this.btnDel.Depth = 0;
            this.btnDel.Location = new System.Drawing.Point(103, 186);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDel.Name = "btnDel";
            this.btnDel.Primary = true;
            this.btnDel.Size = new System.Drawing.Size(63, 34);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(235, 186);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(63, 34);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(16, 261);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(210, 23);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.Text = "Search Bar";
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // gridUser
            // 
            this.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUser.Location = new System.Drawing.Point(16, 294);
            this.gridUser.Margin = new System.Windows.Forms.Padding(2);
            this.gridUser.Name = "gridUser";
            this.gridUser.RowTemplate.Height = 33;
            this.gridUser.Size = new System.Drawing.Size(310, 133);
            this.gridUser.TabIndex = 14;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(342, 446);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.btnLoadUser);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.materialLabel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditUser";
            this.Sizable = false;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtType;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnLoadUser;
        private MaterialSkin.Controls.MaterialRaisedButton btnInsert;
        private MaterialSkin.Controls.MaterialRaisedButton btnDel;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.DataGridView gridUser;
    }
}