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
    public partial class Category : Form
    {
        SqlConnection scon = new SqlConnection();
        SqlCommand scmd = new SqlCommand();
        SqlDataReader dr ;
        DataConnection dbcon = new DataConnection();

        public Category()
        {
            InitializeComponent();
            scon = new SqlConnection(dbcon.MyConnection());
            LoadRecord();
        }

        public void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            scon.Open();
            scmd = new SqlCommand("Select * from Category", scon);
            dr = scmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i,dr["Id"].ToString(), dr["Category"].ToString());
            }
            dr.Close();
            scon.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.ReadOnly = true;
            btnSave.Enabled = false;
            btnInsert.Enabled = true;

            string sId;
            string cat;

            DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];

            sId = selectRow.Cells[1].Value.ToString();
            cat = selectRow.Cells[2].Value.ToString();

            txtId.Text = sId;
            txtCategory.Text = cat;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtCategory.Clear();
            lblOutput.Text = "";

            txtId.ReadOnly = false;
            btnSave.Enabled = true;
            btnInsert.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add new category?", "Insert Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblOutput.Text = "New record added sucessfully";
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdValue = int.Parse(txtId.Text);
                    string cat = txtCategory.Text;

                    scon.Open();

                    scmd = new SqlCommand("UpdateCategory", scon);
                    scmd.CommandType = CommandType.StoredProcedure;
                    scmd.Parameters.Add(new SqlParameter("@cID", IdValue));
                    scmd.Parameters.Add(new SqlParameter("@Cat", cat));

                    scmd.ExecuteNonQuery();

                    lblOutput.Text = "Your record updated sucessfully";
                    scon.Close();
                }
                LoadRecord();
            }
            catch (Exception ex)
            {
                scon.Close();
                MessageBox.Show(ex.Message);
            }
            txtId.ReadOnly = false;
            btnInsert.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   // cn.Open();
                    //cm = new SqlCommand("Delete from Product where Pcode");
                   // cn.Close();
                    lblOutput.Text = "Your record is deleted";
                }
            }
            catch (Exception ex)
            {
               // cn.Close();
                MessageBox.Show(ex.Message);
            }
            txtId.ReadOnly = false;
            btnInsert.Enabled = true;
           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }










        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        
       
    }
}
