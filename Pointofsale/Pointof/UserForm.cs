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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /*
         * Data Source=(LocalDB)\v11.0;AttachDbFilename="C:\Users\User\Documents\Visual Studio 2013\Projects\Pointofsale\Pointof\POS_db.mdf";Integrated Security=True
         * Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Temp.SFC\Documents\Visual Studio 2013\Projects\Pointofsale\Pointof\POS_db.mdf;Integrated Security=True
         * 
         * private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
     {
         string sId;
         string fName;
         string gName;

         DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];

         sId = selectRow.Cells[0].Value.ToString();
         fName = selectRow.Cells[1].Value.ToString();
         gName = selectRow.Cells[2].Value.ToString();
     }

         private void btnUpdate_click(object sender, EventArgs e)
         {
             int studentIdValue = int.Parse(txtID.Text);
             string fName = txtFamily.Text;
             string gName = txtGiven.Text;
                
             string conString;
             conString = Properties.Settings.Default.SDB;

             SqlConnection con = new SqlConnection(conString);
             con.Open();

             SqlCommand cmd = new SqlCommand("UpdateStudentsTable", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.Add(new SqlParameter("@sID", studentIdValue));
             cmd.Parameters.Add(new SqlParameter("@Fam", fName));
             cmd.Parameters.Add(new SqlParameter("@Giv", gName));

             cmd.ExecuteNonQuery();

             MessageBox.Show("Updated:");
             con.Close();
         }*/

    }
}
