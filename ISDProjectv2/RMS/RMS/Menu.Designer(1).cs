namespace RMS
{
    partial class orderMenu
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
            this.btnStarters = new System.Windows.Forms.Button();
            this.btnSide = new System.Windows.Forms.Button();
            this.btnVeg = new System.Windows.Forms.Button();
            this.btnTand = new System.Windows.Forms.Button();
            this.btnDess = new System.Windows.Forms.Button();
            this.btnSea = new System.Windows.Forms.Button();
            this.lblCAT = new System.Windows.Forms.Label();
            this.gViewMenu = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQty = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NumAmnt = new MaterialSkin.Controls.MaterialLabel();
            this.gridBilling = new System.Windows.Forms.DataGridView();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnTotal = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStarters
            // 
            this.btnStarters.Location = new System.Drawing.Point(640, 240);
            this.btnStarters.Name = "btnStarters";
            this.btnStarters.Size = new System.Drawing.Size(159, 71);
            this.btnStarters.TabIndex = 0;
            this.btnStarters.Text = "STARTERS";
            this.btnStarters.UseVisualStyleBackColor = true;
            this.btnStarters.Click += new System.EventHandler(this.btnStarters_Click);
            // 
            // btnSide
            // 
            this.btnSide.Location = new System.Drawing.Point(809, 315);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(159, 71);
            this.btnSide.TabIndex = 0;
            this.btnSide.Text = "SIDE ORDER";
            this.btnSide.UseVisualStyleBackColor = true;
            this.btnSide.Click += new System.EventHandler(this.btnSide_Click);
            // 
            // btnVeg
            // 
            this.btnVeg.Location = new System.Drawing.Point(809, 240);
            this.btnVeg.Name = "btnVeg";
            this.btnVeg.Size = new System.Drawing.Size(159, 71);
            this.btnVeg.TabIndex = 0;
            this.btnVeg.Text = "VEGETABLES";
            this.btnVeg.UseVisualStyleBackColor = true;
            this.btnVeg.Click += new System.EventHandler(this.btnVeg_Click);
            // 
            // btnTand
            // 
            this.btnTand.Location = new System.Drawing.Point(640, 388);
            this.btnTand.Name = "btnTand";
            this.btnTand.Size = new System.Drawing.Size(159, 71);
            this.btnTand.TabIndex = 0;
            this.btnTand.Text = "TANDOORI";
            this.btnTand.UseVisualStyleBackColor = true;
            this.btnTand.Click += new System.EventHandler(this.btnTand_Click);
            // 
            // btnDess
            // 
            this.btnDess.Location = new System.Drawing.Point(809, 388);
            this.btnDess.Name = "btnDess";
            this.btnDess.Size = new System.Drawing.Size(159, 71);
            this.btnDess.TabIndex = 0;
            this.btnDess.Text = "DESSERTS";
            this.btnDess.UseVisualStyleBackColor = true;
            this.btnDess.Click += new System.EventHandler(this.btnDess_Click);
            // 
            // btnSea
            // 
            this.btnSea.Location = new System.Drawing.Point(640, 315);
            this.btnSea.Name = "btnSea";
            this.btnSea.Size = new System.Drawing.Size(159, 71);
            this.btnSea.TabIndex = 0;
            this.btnSea.Text = "SEAFOOD";
            this.btnSea.UseVisualStyleBackColor = true;
            this.btnSea.Click += new System.EventHandler(this.btnSea_Click);
            // 
            // lblCAT
            // 
            this.lblCAT.AutoSize = true;
            this.lblCAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCAT.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAT.Location = new System.Drawing.Point(640, 146);
            this.lblCAT.Name = "lblCAT";
            this.lblCAT.Size = new System.Drawing.Size(292, 69);
            this.lblCAT.TabIndex = 1;
            this.lblCAT.Text = "CATEGORY";
            this.lblCAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gViewMenu
            // 
            this.gViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewMenu.Location = new System.Drawing.Point(970, 146);
            this.gViewMenu.Name = "gViewMenu";
            this.gViewMenu.RowTemplate.Height = 33;
            this.gViewMenu.Size = new System.Drawing.Size(751, 482);
            this.gViewMenu.TabIndex = 0;
            this.gViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewMenu_CellContentClick);
            this.gViewMenu.DoubleClick += new System.EventHandler(this.gViewMenu_DoubleClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 160);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(163, 37);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Item Name";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(186, 160);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(424, 41);
            this.txtName.TabIndex = 4;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Depth = 0;
            this.txtPrice.Hint = "";
            this.txtPrice.Location = new System.Drawing.Point(186, 217);
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(424, 41);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 217);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(85, 37);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Price";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 342);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(156, 37);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Final Price";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 269);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(129, 37);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Quantity";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txtQty
            // 
            this.txtQty.Depth = 0;
            this.txtQty.Hint = "";
            this.txtQty.Location = new System.Drawing.Point(186, 280);
            this.txtQty.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.Size = new System.Drawing.Size(424, 41);
            this.txtQty.TabIndex = 4;
            this.txtQty.UseSystemPasswordChar = false;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // NumAmnt
            // 
            this.NumAmnt.AutoSize = true;
            this.NumAmnt.Depth = 0;
            this.NumAmnt.Font = new System.Drawing.Font("Roboto", 11F);
            this.NumAmnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NumAmnt.Location = new System.Drawing.Point(266, 342);
            this.NumAmnt.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumAmnt.Name = "NumAmnt";
            this.NumAmnt.Size = new System.Drawing.Size(0, 37);
            this.NumAmnt.TabIndex = 5;
            // 
            // gridBilling
            // 
            this.gridBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_name,
            this.item_price,
            this.item_quantity,
            this.final_amount});
            this.gridBilling.Location = new System.Drawing.Point(12, 539);
            this.gridBilling.Name = "gridBilling";
            this.gridBilling.RowTemplate.Height = 33;
            this.gridBilling.Size = new System.Drawing.Size(880, 340);
            this.gridBilling.TabIndex = 6;
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Item Name";
            this.item_name.Name = "item_name";
            // 
            // item_price
            // 
            this.item_price.HeaderText = "Price";
            this.item_price.Name = "item_price";
            // 
            // item_quantity
            // 
            this.item_quantity.HeaderText = "Quantity";
            this.item_quantity.Name = "item_quantity";
            // 
            // final_amount
            // 
            this.final_amount.HeaderText = "Amount";
            this.final_amount.Name = "final_amount";
            // 
            // btn_Add
            // 
            this.btn_Add.Depth = 0;
            this.btn_Add.Location = new System.Drawing.Point(12, 462);
            this.btn_Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Primary = true;
            this.btn_Add.Size = new System.Drawing.Size(262, 71);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add Item";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Depth = 0;
            this.btnTotal.Location = new System.Drawing.Point(898, 634);
            this.btnTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Primary = true;
            this.btnTotal.Size = new System.Drawing.Size(200, 85);
            this.btnTotal.TabIndex = 8;
            this.btnTotal.Text = "Get Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(1141, 673);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(214, 37);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "materialLabel5";
            // 
            // orderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1768, 908);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gridBilling);
            this.Controls.Add(this.NumAmnt);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnSide);
            this.Controls.Add(this.gViewMenu);
            this.Controls.Add(this.btnVeg);
            this.Controls.Add(this.btnTand);
            this.Controls.Add(this.lblCAT);
            this.Controls.Add(this.btnDess);
            this.Controls.Add(this.btnSea);
            this.Controls.Add(this.btnStarters);
            this.Name = "orderMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.gViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStarters;
        private System.Windows.Forms.Button btnSide;
        private System.Windows.Forms.Button btnVeg;
        private System.Windows.Forms.Button btnTand;
        private System.Windows.Forms.Button btnDess;
        private System.Windows.Forms.Button btnSea;
        private System.Windows.Forms.Label lblCAT;
        public System.Windows.Forms.DataGridView gViewMenu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQty;
        private MaterialSkin.Controls.MaterialLabel NumAmnt;
        private System.Windows.Forms.DataGridView gridBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn final_amount;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Add;
        private MaterialSkin.Controls.MaterialRaisedButton btnTotal;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
    }
}