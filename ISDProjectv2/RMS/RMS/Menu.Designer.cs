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
            this.gViewMenu = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.gridBilling = new System.Windows.Forms.DataGridView();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnTotal = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.nupQty = new System.Windows.Forms.NumericUpDown();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRemove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Label5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCAT = new System.Windows.Forms.Label();
            this.NumAmnt = new MaterialSkin.Controls.MaterialLabel();
            this.RemoveIndex = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnStr = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVegeta = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSfood = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSOrder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDesserts = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnTandori = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLogOut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblChefMsg = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQty)).BeginInit();
            this.SuspendLayout();
            // 
            // gViewMenu
            // 
            this.gViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewMenu.Location = new System.Drawing.Point(193, 117);
            this.gViewMenu.Margin = new System.Windows.Forms.Padding(2);
            this.gViewMenu.Name = "gViewMenu";
            this.gViewMenu.RowTemplate.Height = 33;
            this.gViewMenu.Size = new System.Drawing.Size(450, 245);
            this.gViewMenu.TabIndex = 0;
            this.gViewMenu.DoubleClick += new System.EventHandler(this.gViewMenu_DoubleClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(189, 376);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Item Name";
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(276, 376);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(232, 23);
            this.txtName.TabIndex = 4;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Depth = 0;
            this.txtPrice.Hint = "";
            this.txtPrice.Location = new System.Drawing.Point(276, 406);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(231, 23);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(189, 410);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(43, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Price";
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
            this.gridBilling.Location = new System.Drawing.Point(193, 483);
            this.gridBilling.Margin = new System.Windows.Forms.Padding(2);
            this.gridBilling.Name = "gridBilling";
            this.gridBilling.RowTemplate.Height = 33;
            this.gridBilling.Size = new System.Drawing.Size(450, 177);
            this.gridBilling.TabIndex = 6;
            this.gridBilling.DoubleClick += new System.EventHandler(this.gridBilling_DoubleClick);
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
            this.btn_Add.Location = new System.Drawing.Point(512, 376);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Primary = true;
            this.btn_Add.Size = new System.Drawing.Size(131, 37);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add Item";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Depth = 0;
            this.btnTotal.Location = new System.Drawing.Point(512, 675);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Primary = true;
            this.btnTotal.Size = new System.Drawing.Size(131, 37);
            this.btnTotal.TabIndex = 8;
            this.btnTotal.Text = "Confirm Order";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(328, 674);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 19);
            this.lblTotal.TabIndex = 9;
            // 
            // nupQty
            // 
            this.nupQty.Location = new System.Drawing.Point(276, 441);
            this.nupQty.Name = "nupQty";
            this.nupQty.Size = new System.Drawing.Size(120, 20);
            this.nupQty.TabIndex = 10;
            this.nupQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.Location = new System.Drawing.Point(193, 483);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(440, 173);
            this.listOrder.TabIndex = 11;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(189, 439);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Quantity";
            // 
            // btnRemove
            // 
            this.btnRemove.Depth = 0;
            this.btnRemove.Location = new System.Drawing.Point(512, 427);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = true;
            this.btnRemove.Size = new System.Drawing.Size(131, 37);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Depth = 0;
            this.Label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label5.Location = new System.Drawing.Point(181, 675);
            this.Label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(101, 19);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Total Amount";
            // 
            // lblCAT
            // 
            this.lblCAT.AutoSize = true;
            this.lblCAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAT.Location = new System.Drawing.Point(40, 76);
            this.lblCAT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCAT.Name = "lblCAT";
            this.lblCAT.Size = new System.Drawing.Size(157, 31);
            this.lblCAT.TabIndex = 1;
            this.lblCAT.Text = "CATEGORY";
            this.lblCAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumAmnt
            // 
            this.NumAmnt.AutoSize = true;
            this.NumAmnt.Depth = 0;
            this.NumAmnt.Font = new System.Drawing.Font("Roboto", 11F);
            this.NumAmnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NumAmnt.Location = new System.Drawing.Point(286, 674);
            this.NumAmnt.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumAmnt.Name = "NumAmnt";
            this.NumAmnt.Size = new System.Drawing.Size(0, 19);
            this.NumAmnt.TabIndex = 21;
            // 
            // RemoveIndex
            // 
            this.RemoveIndex.Depth = 0;
            this.RemoveIndex.Hint = "";
            this.RemoveIndex.Location = new System.Drawing.Point(413, 439);
            this.RemoveIndex.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveIndex.Name = "RemoveIndex";
            this.RemoveIndex.PasswordChar = '\0';
            this.RemoveIndex.SelectedText = "";
            this.RemoveIndex.SelectionLength = 0;
            this.RemoveIndex.SelectionStart = 0;
            this.RemoveIndex.Size = new System.Drawing.Size(93, 23);
            this.RemoveIndex.TabIndex = 24;
            this.RemoveIndex.UseSystemPasswordChar = false;
            // 
            // btnStr
            // 
            this.btnStr.Depth = 0;
            this.btnStr.Location = new System.Drawing.Point(40, 117);
            this.btnStr.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStr.Name = "btnStr";
            this.btnStr.Primary = true;
            this.btnStr.Size = new System.Drawing.Size(137, 37);
            this.btnStr.TabIndex = 25;
            this.btnStr.Text = "Fast Food";
            this.btnStr.UseVisualStyleBackColor = true;
            this.btnStr.Click += new System.EventHandler(this.btnStr_Click);
            // 
            // btnVegeta
            // 
            this.btnVegeta.Depth = 0;
            this.btnVegeta.Location = new System.Drawing.Point(40, 161);
            this.btnVegeta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVegeta.Name = "btnVegeta";
            this.btnVegeta.Primary = true;
            this.btnVegeta.Size = new System.Drawing.Size(137, 34);
            this.btnVegeta.TabIndex = 26;
            this.btnVegeta.Text = "Chinese";
            this.btnVegeta.UseVisualStyleBackColor = true;
            this.btnVegeta.Click += new System.EventHandler(this.btnVegeta_Click);
            // 
            // btnSfood
            // 
            this.btnSfood.Depth = 0;
            this.btnSfood.Location = new System.Drawing.Point(40, 202);
            this.btnSfood.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSfood.Name = "btnSfood";
            this.btnSfood.Primary = true;
            this.btnSfood.Size = new System.Drawing.Size(137, 37);
            this.btnSfood.TabIndex = 27;
            this.btnSfood.Text = "Rolls";
            this.btnSfood.UseVisualStyleBackColor = true;
            this.btnSfood.Click += new System.EventHandler(this.btnSfood_Click);
            // 
            // btnSOrder
            // 
            this.btnSOrder.Depth = 0;
            this.btnSOrder.Location = new System.Drawing.Point(40, 246);
            this.btnSOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSOrder.Name = "btnSOrder";
            this.btnSOrder.Primary = true;
            this.btnSOrder.Size = new System.Drawing.Size(137, 34);
            this.btnSOrder.TabIndex = 28;
            this.btnSOrder.Text = "Pakistani";
            this.btnSOrder.UseVisualStyleBackColor = true;
            this.btnSOrder.Click += new System.EventHandler(this.btnSOrder_Click);
            // 
            // btnDesserts
            // 
            this.btnDesserts.Depth = 0;
            this.btnDesserts.Location = new System.Drawing.Point(40, 330);
            this.btnDesserts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Primary = true;
            this.btnDesserts.Size = new System.Drawing.Size(137, 34);
            this.btnDesserts.TabIndex = 29;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.UseVisualStyleBackColor = true;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click);
            // 
            // btnTandori
            // 
            this.btnTandori.Depth = 0;
            this.btnTandori.Location = new System.Drawing.Point(40, 289);
            this.btnTandori.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTandori.Name = "btnTandori";
            this.btnTandori.Primary = true;
            this.btnTandori.Size = new System.Drawing.Size(137, 32);
            this.btnTandori.TabIndex = 30;
            this.btnTandori.Text = "Extras";
            this.btnTandori.UseVisualStyleBackColor = true;
            this.btnTandori.Click += new System.EventHandler(this.btnTandori_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Depth = 0;
            this.btnLogOut.Location = new System.Drawing.Point(506, 77);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Primary = true;
            this.btnLogOut.Size = new System.Drawing.Size(137, 34);
            this.btnLogOut.TabIndex = 31;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblChefMsg
            // 
            this.lblChefMsg.AutoSize = true;
            this.lblChefMsg.Depth = 0;
            this.lblChefMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblChefMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblChefMsg.Location = new System.Drawing.Point(11, 711);
            this.lblChefMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChefMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChefMsg.Name = "lblChefMsg";
            this.lblChefMsg.Size = new System.Drawing.Size(0, 19);
            this.lblChefMsg.TabIndex = 33;
            // 
            // orderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(686, 778);
            this.Controls.Add(this.lblChefMsg);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnTandori);
            this.Controls.Add(this.btnDesserts);
            this.Controls.Add(this.btnSOrder);
            this.Controls.Add(this.btnSfood);
            this.Controls.Add(this.btnVegeta);
            this.Controls.Add(this.btnStr);
            this.Controls.Add(this.RemoveIndex);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.NumAmnt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.nupQty);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gridBilling);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.gViewMenu);
            this.Controls.Add(this.lblCAT);
            this.Controls.Add(this.listOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "orderMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.orderMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView gViewMenu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView gridBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn final_amount;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Add;
        private MaterialSkin.Controls.MaterialRaisedButton btnTotal;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private System.Windows.Forms.NumericUpDown nupQty;
        private System.Windows.Forms.ListBox listOrder;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemove;
        private MaterialSkin.Controls.MaterialLabel Label5;
        private System.Windows.Forms.Label lblCAT;
        private MaterialSkin.Controls.MaterialLabel NumAmnt;
        private MaterialSkin.Controls.MaterialSingleLineTextField RemoveIndex;
        private MaterialSkin.Controls.MaterialRaisedButton btnStr;
        private MaterialSkin.Controls.MaterialRaisedButton btnVegeta;
        private MaterialSkin.Controls.MaterialRaisedButton btnSfood;
        private MaterialSkin.Controls.MaterialRaisedButton btnSOrder;
        private MaterialSkin.Controls.MaterialRaisedButton btnDesserts;
        private MaterialSkin.Controls.MaterialRaisedButton btnTandori;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogOut;
        private MaterialSkin.Controls.MaterialLabel lblChefMsg;
    }
}