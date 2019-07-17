using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pointof
{
    public partial class Product : Form
    {
        SqlConnection scon = new SqlConnection();
        SqlCommand scmd = new SqlCommand();
        DataConnection dbcon = new DataConnection();
        SqlDataReader dr;

        public Product()
        {
            InitializeComponent();
            scon = new SqlConnection(dbcon.MyConnection());
            LoadRecord();
        }
        public void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            scon.Open();
            scmd = new SqlCommand("ShowProduct", scon);
            dr = scmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i,dr[0].ToString(), dr[1].ToString(),dr[2].ToString(),dr[3].ToString(),dr[4].ToString());
            }
            dr.Close();
            scon.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPcode.ReadOnly = true;
            btnSave.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            string pCode;
            string Bcode;
            string pName;
            string pCate;
            string pPrice;

            DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];

            pCode = selectRow.Cells[1].Value.ToString();
            Bcode = selectRow.Cells[2].Value.ToString();
            pName = selectRow.Cells[3].Value.ToString();
            pCate = selectRow.Cells[4].Value.ToString();
            pPrice = selectRow.Cells[5].Value.ToString();

            txtPcode.Text = pCode;
            txtBarcode.Text = Bcode;
            txtPname.Text = pName;
            cmbPcategory.Text = pCate;
            txtPprice.Text = pPrice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPcode.Clear();
            txtBarcode.Clear();
            txtPname.Clear();
            txtPprice.Clear();
            cmbPcategory.Text = "";
            lblOutput.Text = "";

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtPcode.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add new product?", "Insert Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblOutput.Text = "New record added sucessfully";
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblOutput.Text = "Your record updated sucessfully";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblOutput.Text = "Your record deleted";
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }






        private void txtPprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        
    }
}
