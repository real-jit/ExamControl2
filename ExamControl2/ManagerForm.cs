using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamControl2
{
    public partial class ManagerForm : Form
    {
        string connectionString = "Host=localhost; Port=5432; Username=postgres; Password=root; Database=shoestore2exam";

        int selectedProductId = 0;
        bool formLoaded = false;

        string UserFio = "Гость";

        public ManagerForm()
        {
            InitializeComponent();
        }

        public ManagerForm(string fio)
        {
            InitializeComponent();
            UserFio = fio;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            lblFio.Text = UserFio;

            cmbSort.SelectedIndex = 0;

            LoadSuppliers();

            formLoaded = true;

            LoadProducts();
        }

        private void LoadSuppliers()
        {
            cmbSuppliers.Items.Clear();
            cmbSuppliers.Items.Add("Все поставщики");

            string sql = "SELECT supplier_name FROM suppliers ORDER BY supplier_name";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                conn.Open();

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbSuppliers.Items.Add(reader["supplier_name"].ToString());
                    }
                }
            }
            cmbSuppliers.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            string searchText = txtSearch.Text.Replace("'", "''");
            string supplierText = cmbSuppliers.Text.Replace("'", "''");

            string sql = @"
                SELECT
                    p.product_id,
                    p.article,
                    p.product_name,
                    p.unit,
                    p.price,
                    ROUND(p.price - p.price * p.discount / 100, 2) AS final_price,
                    c.category_name,
                    m.manufacturer_name,
                    s.supplier_name,
                    p.discount,
                    p.quantity,
                    p.description,
                    p.image_path
                FROM products p
                LEFT JOIN categories c ON p.category_id = c.category_id
                LEFT JOIN manufacturers m ON p.manufacturer_id = m.manufacturer_id
                LEFT JOIN suppliers s ON p.supplier_id = s.supplier_id
                WHERE 1 = 1
            ";

            if (searchText != "")
            {
                sql += $@"
                    AND (
                        p.article ILIKE '%{searchText}%'
                        OR p.product_name ILIKE '%{searchText}%'
                        OR c.category_name ILIKE '%{searchText}%'
                        OR m.manufacturer_name ILIKE '%{searchText}%'
                        OR s.supplier_name ILIKE '%{searchText}%'
                        OR p.description ILIKE '%{searchText}%'
                    )
                ";
            }

            if (supplierText != "Все поставщики" && supplierText != "")
            {
                sql += " AND s.supplier_name = '" + supplierText + "'";
            }

            if (cmbSort.Text == "Количество по возрастанию")
            {
                sql += " ORDER BY p.quantity ASC";
            }
            else if (cmbSort.Text == "Количество по убыванию")
            {
                sql += " ORDER BY p.quantity DESC";
            }
            else
            {
                sql += " ORDER BY p.product_name";
            }

            DataTable table = new DataTable();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn))
            {
                adapter.Fill(table);
            }

            dgvProducts.DataSource = table;

            SetupGrid();
            ColorRows();

            if (dgvProducts.Rows.Count > 0)
            {
                dgvProducts.Rows[0].Selected = true;
                ShowProductCard(dgvProducts.Rows[0]);
            }
            else
            {
                ClearProductCard();
            }
        }

        private void SetupGrid()
        {
            foreach (DataGridViewColumn column in dgvProducts.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (dgvProducts.Columns["product_id"] != null)
            {
                dgvProducts.Columns["product_id"].Visible = false;
            }
            if (dgvProducts.Columns["article"] != null)
            {
                dgvProducts.Columns["article"].Visible = false;
            }
            if (dgvProducts.Columns["product_name"] != null)
            {
                dgvProducts.Columns["product_name"].HeaderText = "Наименование";
            }
            if (dgvProducts.Columns["unit"] != null)
            {
                dgvProducts.Columns["unit"].Visible = false;
            }
            if (dgvProducts.Columns["price"] != null)
            {
                dgvProducts.Columns["price"].Visible = false;
            }
            if (dgvProducts.Columns["final_price"] != null)
            {
                dgvProducts.Columns["final_price"].HeaderText = "Цена";
            }
            if (dgvProducts.Columns["category_name"] != null)
            {
                dgvProducts.Columns["category_name"].HeaderText = "Категория";
            }
            if (dgvProducts.Columns["manufacturer_name"] != null)
            {
                dgvProducts.Columns["manufacturer_name"].Visible = false;
            }
            if (dgvProducts.Columns["supplier_name"] != null)
            {
                dgvProducts.Columns["supplier_name"].HeaderText = "Поставщик";
            }
            if (dgvProducts.Columns["discount"] != null)
            {
                dgvProducts.Columns["discount"].HeaderText = "Скидка";
            }
            if (dgvProducts.Columns["quantity"] != null)
            {
                dgvProducts.Columns["quantity"].HeaderText = "Количество";
            }
            if (dgvProducts.Columns["description"] != null)
            {
                dgvProducts.Columns["description"].Visible = false;
            }
            if (dgvProducts.Columns["image_path"] != null)
            {
                dgvProducts.Columns["image_path"].Visible = false;
            }
        }

        private void ColorRows()
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                int discount = Convert.ToInt32(row.Cells["discount"].Value);
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);

                if (quantity <= 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

                else if (discount > 15)
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void ShowProductCard(DataGridViewRow row)
        {
            selectedProductId = Convert.ToInt32(row.Cells["product_id"].Value);

            decimal price = Convert.ToDecimal(row.Cells["price"].Value);
            decimal finalPrice = Convert.ToDecimal(row.Cells["final_price"].Value);

            int discount = Convert.ToInt32(row.Cells["discount"].Value);
            int quantity = Convert.ToInt32(row.Cells["quantity"].Value);

            lblTitle.Text = row.Cells["category_name"].Value.ToString() + " | " + row.Cells["product_name"].Value.ToString();
            lblDescription.Text = "Описание: " + row.Cells["description"].Value.ToString();
            lblManufacturer.Text = "Производитель: " + row.Cells["manufacturer_name"].Value.ToString();
            lblSupplier.Text = "Поставщик: " + row.Cells["supplier_name"].Value.ToString();
            lblPrice.Text = "Цена:";
            lblUnit.Text = "Единица измерения: " + row.Cells["unit"].Value.ToString();
            lblQty.Text = "Количество: " + row.Cells["quantity"].Value.ToString();
            lblDiscount.Text = "Действующая\nскидка\n " + row.Cells["discount"].Value.ToString() + " %";

            if (discount > 0)
            {
                lblOldPrice.Text = price.ToString("0.00") + " руб.";
                lblOldPrice.ForeColor = Color.Red;
                lblOldPrice.Font = new Font(lblOldPrice.Font, FontStyle.Strikeout);

                lblNewPrice.Text = price.ToString("0.00") + " руб.";
                lblNewPrice.ForeColor = Color.Black;
                lblNewPrice.Font = new Font(lblNewPrice.Font, FontStyle.Regular);
                lblNewPrice.Visible = true;
            }
            else
            {
                lblOldPrice.Text = price.ToString("0.00") + "руб.";
                lblOldPrice.ForeColor = Color.Black;
                lblOldPrice.Font = new Font(lblOldPrice.Font, FontStyle.Regular);

                lblNewPrice.Text = "";
                lblNewPrice.Visible = false;
            }

            if (quantity <= 0)
            {
                panelProduct.BackColor = Color.LightBlue;
            }

            else if (discount > 15)
            {
                panelProduct.BackColor = ColorTranslator.FromHtml("#2E8B57");
            }
            else
            {
                panelProduct.BackColor = Color.White;
            }

            LoadImage(row.Cells["image_path"].Value.ToString());
        }

        private void ClearProductCard()
        {
            selectedProductId = 0;

            lblTitle.Text = "";
            lblDescription.Text = "";
            lblManufacturer.Text = "";
            lblSupplier.Text = "";
            lblPrice.Text = "Цена:";
            lblUnit.Text = "";
            lblQty.Text = "";
            lblDiscount.Text = "";
            lblOldPrice.Text = "";
            lblNewPrice.Text = "";

            panelProduct.BackColor = Color.White;
            pictureBoxProducts.Image = Properties.Resources.picture;
        }

        private void LoadImage(string imagePath) // Метод для загрузки картинки
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath))
                {
                    if (!Path.IsPathRooted(imagePath))
                    {
                        imagePath = Path.Combine(Application.StartupPath, imagePath);
                    }

                    if (File.Exists(imagePath))
                    {
                        using (Image image = Image.FromFile(imagePath))
                        {
                            pictureBoxProducts.Image = new Bitmap(image);
                        }

                        return;
                    }
                }
            }
            catch
            {

            }
            pictureBoxProducts.Image = Properties.Resources.picture;
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                LoadProducts();
            }
        }

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                LoadProducts();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                LoadProducts();
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowProductCard(dgvProducts.Rows[e.RowIndex]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
