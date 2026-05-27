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
    public partial class ProductEditForm : Form
    {
        int roleType = 0;

        public ProductEditForm()
        {
            InitializeComponent();
        }

        public ProductEditForm(int roleId)
        {
            InitializeComponent();
            roleType = roleId;
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
