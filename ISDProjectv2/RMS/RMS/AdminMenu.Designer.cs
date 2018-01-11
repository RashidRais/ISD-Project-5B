namespace RMS
{
    partial class AdminMenu
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
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLoadMenu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gridMenu = new System.Windows.Forms.DataGridView();
            this.btnInsert = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(685, 217);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(118, 37);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadMenu
            // 
            this.btnLoadMenu.Depth = 0;
            this.btnLoadMenu.Location = new System.Drawing.Point(178, 290);
            this.btnLoadMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadMenu.Name = "btnLoadMenu";
            this.btnLoadMenu.Primary = true;
            this.btnLoadMenu.Size = new System.Drawing.Size(63, 34);
            this.btnLoadMenu.TabIndex = 7;
            this.btnLoadMenu.Text = "Load";
            this.btnLoadMenu.UseVisualStyleBackColor = true;
            this.btnLoadMenu.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // gridMenu
            // 
            this.gridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMenu.Location = new System.Drawing.Point(364, 73);
            this.gridMenu.Margin = new System.Windows.Forms.Padding(2);
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.RowTemplate.Height = 33;
            this.gridMenu.Size = new System.Drawing.Size(438, 133);
            this.gridMenu.TabIndex = 11;
            this.gridMenu.DoubleClick += new System.EventHandler(this.gridMenu_DoubleClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Depth = 0;
            this.btnInsert.Location = new System.Drawing.Point(46, 290);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Primary = true;
            this.btnInsert.Size = new System.Drawing.Size(63, 34);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDel
            // 
            this.btnDel.Depth = 0;
            this.btnDel.Location = new System.Drawing.Point(112, 290);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDel.Name = "btnDel";
            this.btnDel.Primary = true;
            this.btnDel.Size = new System.Drawing.Size(63, 34);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(244, 290);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(63, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 126);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(16, 154);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(43, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Price";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(16, 211);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(41, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Type";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(16, 238);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Category";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(143, 124);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(187, 23);
            this.txtName.TabIndex = 0;
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrice.Depth = 0;
            this.txtPrice.Hint = "";
            this.txtPrice.Location = new System.Drawing.Point(143, 154);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(187, 23);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtType.Depth = 0;
            this.txtType.Hint = "";
            this.txtType.Location = new System.Drawing.Point(143, 211);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.SelectedText = "";
            this.txtType.SelectionLength = 0;
            this.txtType.SelectionStart = 0;
            this.txtType.Size = new System.Drawing.Size(187, 23);
            this.txtType.TabIndex = 2;
            this.txtType.UseSystemPasswordChar = false;
            // 
            // txtCat
            // 
            this.txtCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCat.Depth = 0;
            this.txtCat.Hint = "";
            this.txtCat.Location = new System.Drawing.Point(143, 238);
            this.txtCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtCat.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCat.Name = "txtCat";
            this.txtCat.PasswordChar = '\0';
            this.txtCat.SelectedText = "";
            this.txtCat.SelectionLength = 0;
            this.txtCat.SelectionStart = 0;
            this.txtCat.Size = new System.Drawing.Size(187, 23);
            this.txtCat.TabIndex = 4;
            this.txtCat.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(49, 73);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(110, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Add Menu Item";
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(364, 264);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(210, 23);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Text = "Search Bar";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.materialSingleLineTextField1_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Depth = 0;
            this.btnReset.Location = new System.Drawing.Point(364, 290);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = true;
            this.btnReset.Size = new System.Drawing.Size(63, 34);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtSPrice
            // 
            this.txtSPrice.Depth = 0;
            this.txtSPrice.Hint = "";
            this.txtSPrice.Location = new System.Drawing.Point(143, 183);
            this.txtSPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSPrice.Name = "txtSPrice";
            this.txtSPrice.PasswordChar = '\0';
            this.txtSPrice.SelectedText = "";
            this.txtSPrice.SelectionLength = 0;
            this.txtSPrice.SelectionStart = 0;
            this.txtSPrice.Size = new System.Drawing.Size(187, 23);
            this.txtSPrice.TabIndex = 15;
            this.txtSPrice.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(16, 187);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(92, 19);
            this.materialLabel6.TabIndex = 16;
            this.materialLabel6.Text = "Selling Price";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 360);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtSPrice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnLoadMenu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gridMenu);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.materialLabel4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMenu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridMenu;
        private MaterialSkin.Controls.MaterialRaisedButton btnLoadMenu;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnInsert;
        private MaterialSkin.Controls.MaterialRaisedButton btnDel;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtType;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCat;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialRaisedButton btnReset;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}