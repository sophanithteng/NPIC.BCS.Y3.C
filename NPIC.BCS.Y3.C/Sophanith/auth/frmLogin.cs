using NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters;
using NPIC.BCS.Y3.C.Sophanith.layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPIC.BCS.Y3.C.Sophanith.auth
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                QueriesTableAdapter q = new QueriesTableAdapter();

                string username = txtname.Text.Trim().Replace("'", "''");
                string password = txtpasswrd.Text.Trim().Replace("'", "''");

                bool? @is_login = false;
                string @message = string.Empty;
                q.pro_login_account(username, password, ref is_login, ref message);

                if (is_login.Value)
                {
                    this.Hide();
                    new frmDashboard().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(message);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtpasswrd.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
