using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamControl2
{
    public partial class OrdersForm : Form
    {
        string connectionString = "Host=localhost; Port=5432; Username=postgres; Password=root; Database=shoestore2exam";

        int selectedProductId = 0;

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {

            string sql = @"
                SELECT
                    p.article,
                    o.order_id,
                    s.status_name,
                    pp.address,
                    o.issue_date,
                    o.order_date
                FROM orders o
                LEFT JOIN order_statuses s ON o.status_id = s.status_id
                LEFT JOIN pickup_points pp ON o.pickup_point_id = pp.pickup_point_id
                LEFT JOIN order_products op ON o.order_id = op.order_id
                LEFT JOIN products p ON op.product_id = p.product_id
                WHERE 1 = 1
            ";

            DataTable table = new DataTable();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn))
            {
                adapter.Fill(table);
            }

            dgvProducts.DataSource = table;

            SetupGrid();

            if (dgvProducts.Rows.Count > 0)
            {
                dgvProducts.Rows[0].Selected = true;
                ShowProductCard(dgvProducts.Rows[0]);
            }
        }

        private void SetupGrid()
        {
            foreach (DataGridViewColumn column in dgvProducts.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (dgvProducts.Columns["status_name"] != null)
            {
                dgvProducts.Columns["status_name"].HeaderText = "Статус";
            }
            if (dgvProducts.Columns["address"] != null)
            {
                dgvProducts.Columns["address"].Visible = false;
            }
            if (dgvProducts.Columns["issue_date"] != null)
            {
                dgvProducts.Columns["issue_date"].HeaderText = "Дата доставки";
            }
            if (dgvProducts.Columns["order_date"] != null)
            {
                dgvProducts.Columns["order_date"].HeaderText = "Дата заказа";
            }
            if (dgvProducts.Columns["order_id"] != null)
            {
                dgvProducts.Columns["order_id"].Visible = false;
            }
            if (dgvProducts.Columns["article"] != null)
            {
                dgvProducts.Columns["article"].Visible = false;
            }
        }

        private void ShowProductCard(DataGridViewRow row)
        {
            selectedProductId = Convert.ToInt32(row.Cells["order_id"].Value);

            lblArticle.Text = row.Cells["article"].Value.ToString();
            lblStatus.Text = "Статус: " + row.Cells["status_name"].Value.ToString();
            lblAddress.Text = "Адрес: " + row.Cells["address"].Value.ToString();
            lblDateIssue.Text = "Дата\nдоставки\n: " + Convert.ToDateTime(row.Cells["issue_date"].Value);
            lblDateOrder.Text = "Дата заказа:" + Convert.ToDateTime(row.Cells["order_date"].Value);

        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowProductCard(dgvProducts.Rows[e.RowIndex]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderEditForm orderEditForm = new OrderEditForm();
            orderEditForm.ShowDialog();

            LoadProducts();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            OrderEditForm orderEditForm = new OrderEditForm();
            orderEditForm.ShowDialog();

            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (selectedProductId == 0)
                {
                    MessageBox.Show("Выберете заказ", "Удаление заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show("Удалить выбранный заказ?", "Удаление заказа", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                string deleteSql = "DELETE FROM orders WHERE order_id = " + selectedProductId;

                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                using (NpgsqlCommand cmd = new NpgsqlCommand(deleteSql, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Заказ удален", "Удаление заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Сбой:" + ex.Message, "Удаление заказа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
