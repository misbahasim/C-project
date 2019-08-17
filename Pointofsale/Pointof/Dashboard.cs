using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointof
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void MainOutputForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            Category ct = new Category();
            ct.TopLevel = false;
            pnlShowForm.Controls.Add(ct);
            ct.BringToFront();
            ct.Show();
        }

        private void btnProductForm_Click(object sender, EventArgs e)
        {
            Product pf = new Product();
            pf.TopLevel = false;
            pnlShowForm.Controls.Add(pf);
            pf.BringToFront();
            pf.Show();
        }

        private void pnlShowForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStockForm_Click(object sender, EventArgs e)
        {
            StockIn si = new StockIn();
            si.TopLevel = false;
            pnlShowForm.Controls.Add(si);
            si.BringToFront();
            si.Show();
        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.TopLevel = false;
            pnlShowForm.Controls.Add(uf);
            uf.BringToFront();
            uf.Show();
        }
    }
}
