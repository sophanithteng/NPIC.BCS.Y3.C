using NPIC.BCS.Y3.C.Sophanith.function;
using NPIC.BCS.Y3.C.Sophanith.layout;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NPIC.BCS.Y3.C.Sophanith.user
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            // Ensure dataset reference uses correct casing: NPIC_BCS_Y3_CDataSet
        }

        private byte[] ImageToByteArray(Image img)
        {
            if (img == null) return null;
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private static object ToDbValue(object val)
        {
            if (val == null || val == DBNull.Value) return DBNull.Value;
            if (val is string s && string.IsNullOrWhiteSpace(s)) return DBNull.Value;
            return val;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                this.tblUsersTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.tbl_Users);

                if (this.picturePictureBox.Image == null)
                {
                    this.picturePictureBox.Image = global::NPIC.BCS.Y3.C.Properties.Resources.working;
                }
                this.picturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                try
                {
                    var idBinding = this.idTextBox.DataBindings["Text"];
                    if (idBinding != null)
                    {
                        idBinding.Format += (s, ev) =>
                        {
                            if (ev.DesiredType == typeof(string) && ev.Value is int intVal && intVal < 0)
                            {
                                ev.Value = string.Empty;
                            }
                        };
                    }
                }
                catch
                {
                    // Ignore binding errors if controls don't exist
                }

                using (var conn = new SqlConnection(Properties.Settings.Default.NPIC_BCS_Y3_CConnectionString))
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data or connecting to DB: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblUsersBindingSource.AddNew();

                var drv = this.tblUsersBindingSource.Current as DataRowView;
                if (drv != null && drv.Row != null)
                {
                    // Set default values based on the specific schema provided
                    if (drv.Row.Table.Columns.Contains("status"))
                        drv["status"] = true; // New user active by default

                    if (drv.Row.Table.Columns.Contains("created_at"))
                        drv["created_at"] = DateTime.Now; // Log creation time

                    if (drv.Row.Table.Columns.Contains("picture"))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            global::NPIC.BCS.Y3.C.Properties.Resources.working.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            drv["picture"] = ms.ToArray();
                        }
                        this.picturePictureBox.Image = global::NPIC.BCS.Y3.C.Properties.Resources.working;
                    }
                }

                this.usernameTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add user failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.usernameTextBox.Text) || string.IsNullOrWhiteSpace(this.nicknameTextBox.Text))
                {
                    MessageBox.Show("Please provide both User Name and Nick Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Validate();
                this.tblUsersBindingSource.EndEdit();

                this.tableAdapterManager.UpdateAll(this.nPIC_BCS_Y3_CDataSet);

                // Refresh dataset
                this.tblUsersTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.tbl_Users);
                MessageBox.Show("Saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg != DialogResult.Yes) return;

                this.tblUsersBindingSource.RemoveCurrent();
                this.Validate();
                this.tblUsersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.nPIC_BCS_Y3_CDataSet);

                MessageBox.Show("Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tblUsersTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.tbl_Users);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblUsersBindingSource.CancelEdit();
                this.tblUsersTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.tbl_Users);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cancel failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_BCS_Y3_CDataSet);
        }

        private void toolStrip_Save_Click(object sender, EventArgs e)
        {
            this.tblUsersBindingNavigatorSaveItem_Click(sender, e);
            MessageBox.Show("Saved!");
        }

        private void toolStrip_Create_Click(object sender, EventArgs e)
        {
            btnadduser_Click(sender, e);
            try { this.statusCheckBox.Checked = true; } catch { }
        }

        private void toolStrip_Delete_Click(object sender, EventArgs e)
        {
            btndelete_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GB.OpenForm(new Sophanith.frmHome());
        }

        private void toolStrip_Search_Click(object sender, EventArgs e)
        {
        }

        private void btnaddinformation_Click(object sender, EventArgs e)
        {
            using (var addinformation = new frmUpdate())
            {
                addinformation.ShowDialog();
            }
        }

        private void picturePictureBox_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog fp = new OpenFileDialog())
            {
                fp.Title = "Select Image";
                fp.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
                fp.Multiselect = false;

                if (fp.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] bytes = File.ReadAllBytes(fp.FileName);
                        Image selectedImg;
                        using (var ms = new MemoryStream(bytes))
                        {
                            selectedImg = Image.FromStream(ms);
                        }

                        picturePictureBox.Image = selectedImg;
                        var drv = this.tblUsersBindingSource.Current as DataRowView;

                        if (drv != null)
                        {
                            // Explicitly map to the lowercase "picture" column from the database schema
                            if (drv.Row.Table.Columns.Contains("picture"))
                            {
                                drv["picture"] = bytes;
                            }
                            this.tblUsersBindingSource.EndEdit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}