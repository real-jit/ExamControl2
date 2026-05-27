namespace ExamControl2
{
    partial class AdminForm
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.pictureBoxProducts = new System.Windows.Forms.PictureBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 91);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(792, 231);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.lblNewPrice);
            this.panelProduct.Controls.Add(this.lblOldPrice);
            this.panelProduct.Controls.Add(this.pictureBoxProducts);
            this.panelProduct.Controls.Add(this.lblDiscount);
            this.panelProduct.Controls.Add(this.lblQty);
            this.panelProduct.Controls.Add(this.lblUnit);
            this.panelProduct.Controls.Add(this.lblPrice);
            this.panelProduct.Controls.Add(this.lblSupplier);
            this.panelProduct.Controls.Add(this.lblManufacturer);
            this.panelProduct.Controls.Add(this.lblDescription);
            this.panelProduct.Controls.Add(this.lblTitle);
            this.panelProduct.Location = new System.Drawing.Point(12, 328);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(927, 221);
            this.panelProduct.TabIndex = 1;
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(441, 131);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(25, 13);
            this.lblNewPrice.TabIndex = 10;
            this.lblNewPrice.Text = "000";
            // 
            // lblOldPrice
            // 
            this.lblOldPrice.AutoSize = true;
            this.lblOldPrice.Location = new System.Drawing.Point(366, 131);
            this.lblOldPrice.Name = "lblOldPrice";
            this.lblOldPrice.Size = new System.Drawing.Size(25, 13);
            this.lblOldPrice.TabIndex = 9;
            this.lblOldPrice.Text = "000";
            // 
            // pictureBoxProducts
            // 
            this.pictureBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProducts.Location = new System.Drawing.Point(16, 18);
            this.pictureBoxProducts.Name = "pictureBoxProducts";
            this.pictureBoxProducts.Size = new System.Drawing.Size(210, 192);
            this.pictureBoxProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProducts.TabIndex = 8;
            this.pictureBoxProducts.TabStop = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(753, 18);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(156, 183);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "Скидка";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(278, 188);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(66, 13);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Количество";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(278, 161);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(43, 13);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Ед изм";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(278, 131);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Цена";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(278, 104);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(65, 13);
            this.lblSupplier.TabIndex = 3;
            this.lblSupplier.Text = "Поставщик";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(278, 73);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(86, 13);
            this.lblManufacturer.TabIndex = 2;
            this.lblManufacturer.Text = "Производитель";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(278, 46);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(57, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Описание";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(278, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Категория наименование";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(852, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить товар";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(852, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(852, 220);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(75, 23);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(852, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Без сортировки",
            "Количество по возрастанию",
            "Количество по убыванию"});
            this.cmbSort.Location = new System.Drawing.Point(13, 45);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(180, 21);
            this.cmbSort.TabIndex = 6;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(247, 45);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(191, 21);
            this.cmbSuppliers.TabIndex = 7;
            this.cmbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cmbSuppliers_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(478, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(326, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поставщики";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск";
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(737, 9);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(34, 13);
            this.lblFio.TabIndex = 12;
            this.lblFio.Text = "ФИО";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblFio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.dgvProducts);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBoxProducts;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.Label lblOldPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFio;
    }
}