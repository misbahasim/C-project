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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection();
        DataConnection dbcon = new DataConnection();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(dbcon.MyConnection());
            SqlDataAdapter da = new SqlDataAdapter("select Count(*) from Login where Username ='" + txtUser.Text.Trim() + "'and password='" + txtPassword.Text.Trim() + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainOutputForm mf = new MainOutputForm();
                mf.Show();
            }
            else { 
                    lblIncorrect.Text = "Incorrect username/password";
                    txtPassword.Clear();
                 }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
