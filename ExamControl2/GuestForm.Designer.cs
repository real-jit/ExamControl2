namespace ExamControl2
{
    partial class GuestForm
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
            this.lblFio = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(749, 19);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(36, 13);
            this.lblFio.TabIndex = 25;
            this.lblFio.Text = "Гость";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(869, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.panelProduct.Location = new System.Drawing.Point(29, 329);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(927, 221);
            this.panelProduct.TabIndex = 14;
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
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(29, 92);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(792, 231);
            this.dgvProducts.TabIndex = 13;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblFio);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.dgvProducts);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.Label lblOldPrice;
        private System.Windows.Forms.PictureBox pictureBoxProducts;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}