namespace ExamControl2
{
    partial class OrdersForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.lblDateIssue = new System.Windows.Forms.Label();
            this.lblDateOrder = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(869, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(869, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(869, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить заказ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProduct.Controls.Add(this.lblDateIssue);
            this.panelProduct.Controls.Add(this.lblDateOrder);
            this.panelProduct.Controls.Add(this.lblAddress);
            this.panelProduct.Controls.Add(this.lblStatus);
            this.panelProduct.Controls.Add(this.lblArticle);
            this.panelProduct.Location = new System.Drawing.Point(29, 288);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(927, 221);
            this.panelProduct.TabIndex = 7;
            // 
            // lblDateIssue
            // 
            this.lblDateIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateIssue.Location = new System.Drawing.Point(753, 18);
            this.lblDateIssue.Name = "lblDateIssue";
            this.lblDateIssue.Size = new System.Drawing.Size(156, 183);
            this.lblDateIssue.TabIndex = 7;
            this.lblDateIssue.Text = "Дата доставки";
            this.lblDateIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateOrder
            // 
            this.lblDateOrder.AutoSize = true;
            this.lblDateOrder.Location = new System.Drawing.Point(44, 137);
            this.lblDateOrder.Name = "lblDateOrder";
            this.lblDateOrder.Size = new System.Drawing.Size(72, 13);
            this.lblDateOrder.TabIndex = 3;
            this.lblDateOrder.Text = "Дата заказа";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(44, 103);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(38, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Адрес";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(44, 62);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Статус";
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArticle.Location = new System.Drawing.Point(44, 18);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(69, 16);
            this.lblArticle.TabIndex = 0;
            this.lblArticle.Text = "Артикул";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(29, 51);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(792, 231);
            this.dgvProducts.TabIndex = 6;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.dgvProducts);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label lblDateIssue;
        private System.Windows.Forms.Label lblDateOrder;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}