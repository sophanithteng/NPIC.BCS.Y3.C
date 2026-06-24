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



        private bool AuthenticateUser(string username, string password, out bool isDisabled)
        {
            isDisabled = false;
            var cs = Properties.Settings.Default.NPIC_BCS_Y3_CConnectionString;

            using (var conn = new SqlConnection(cs))
            using (var cmd = conn.CreateCommand())
            {
                // read the whole row so we can adapt to either 'disable' or 'status' column
                cmd.CommandText = "SELECT TOP 1 * FROM [tbl_Users] WHERE [username] = @username AND [password] = @password";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    if (!rdr.Read())
                        return false;

                    // helper to check column existence
                    bool HasColumn(System.Data.IDataRecord r, string name)
                    {
                        for (int i = 0; i < r.FieldCount; i++)
                            if (string.Equals(r.GetName(i), name, StringComparison.OrdinalIgnoreCase))
                                return true;
                        return false;
                    }

                    // prefer 'disable' if present
                    if (HasColumn(rdr, "disable"))
                    {
                        var val = rdr["disable"];
                        isDisabled = (val != null && val != DBNull.Value) && Convert.ToBoolean(val);
                    }
                    else if (HasColumn(rdr, "status"))
                    {
                        // dataset uses 'status' boolean; assume status==true means active
                        var val = rdr["status"];
                        bool status = (val != null && val != DBNull.Value) && Convert.ToBoolean(val);
                        isDisabled = !status;
                    }
                    else
                    {
                        // unknown schema - assume not disabled
                        isDisabled = false;
                    }

                    return true;
                }
            }
        }

        private bool TestDbConnection(out string error)
        {
            error = null;
            var cs = Properties.Settings.Default.NPIC_BCS_Y3_CConnectionString;
            try
            {
                using (var conn = new SqlConnection(cs))
                {
                    conn.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                // return full exception for better diagnostics
                error = ex.ToString();
                return false;
            }
        }

        private string MaskConnectionString(string cs)
        {
            if (string.IsNullOrWhiteSpace(cs))
                return "<empty>";

            try
            {
                var builder = new SqlConnectionStringBuilder(cs);
                if (!string.IsNullOrEmpty(builder.Password))
                    builder.Password = "****";
                return builder.ToString();
            }
            catch
            {
                // If parsing fails, do a best-effort mask
                try
                {
                    var lowered = cs.ToLowerInvariant();
                    int p = lowered.IndexOf("password=");
                    if (p >= 0)
                    {
                        int start = p + "password=".Length;
                        int end = cs.IndexOf(';', start);
                        if (end < 0) end = cs.Length;
                        return cs.Substring(0, start) + "****" + (end < cs.Length ? cs.Substring(end) : "");
                    }
                }
                catch { }
                return "<invalid connection string>";
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtname.Text.Trim();
            string password = txtpasswrd.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!TestDbConnection(out var connErr))
                {
                    MessageBox.Show("Cannot connect to database: " + connErr, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool isDisabled;
                bool isCredentialsValid = AuthenticateUser(username, password, out isDisabled);
                if (isCredentialsValid)
                {
                    if (isDisabled)
                    {
                        MessageBox.Show("Your account has been disabled. Please contact the administrator.", "Account Disabled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        this.Hide();
                        using (var dash = new frmDashboard())
                        {
                            dash.ShowDialog();
                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtpasswrd.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
