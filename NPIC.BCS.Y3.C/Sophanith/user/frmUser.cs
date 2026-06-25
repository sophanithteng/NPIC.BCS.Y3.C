using NPIC.BCS.Y3.C.Sophanith.function;
using NPIC.BCS.Y3.C.Sophanith.layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPIC.BCS.Y3.C.Sophanith.user
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void tbl_UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_UsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_BCS_Y3_CDataSet);

        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nPIC_BCS_Y3_CDataSet.tbl_Genders' table. You can move, or remove it, as needed.
            this.tbl_GendersTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.tbl_Genders);
            // TODO: This line of code loads data into the 'nPIC_BCS_Y3_CDataSet.user_view' table. You can move, or remove it, as needed.
            this.user_viewTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.user_view);
            // TODO: This line of code loads data into the 'nPIC_BCS_Y3_CDataSet.tbl_Users' table. You can move, or remove it, as needed.
            this.tbl_UsersTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.tbl_Users);
            this.tbl_UsersBindingSource.Filter = "id=-1";

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            new frmUpdate().ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            GB.OpenForm(new frmHome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_UsersBindingSource.AddNew();
            statusCheckBox.Checked = false;
            created_atDateTimePicker.Text = "01-01-01";
            created_atDateTimePicker.Value = DateTime.Now;
            gender_idComboBox.SelectedIndex = 0;
            roleComboBox.SelectedIndex = 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            tbl_UsersBindingNavigatorSaveItem_Click(sender, e);
            MessageBox.Show("you information have been save");
            this.user_viewTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.user_view);
        }

        private void picturePictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog fp = new OpenFileDialog())
            {
                fp.Title = "Picture";
                fp.Filter = "Image Files|*.png;*.jpg;*.jpeg";
                fp.Multiselect = false;

                if (fp.ShowDialog() == DialogResult.OK)
                {
                    picturePictureBox.Image = Image.FromFile(fp.FileName);
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string search = txtsearch.Text.Trim().Replace("'", "'");
            this.user_viewBindingSource.Filter = "nickname LIKE '%" + search + "%' OR username LIKE '%" + search + "%'";
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsearch_Click(sender, e);
            }
        }

        private void user_viewDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != 1) 
            {
                int id = int.Parse(user_viewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.tbl_UsersBindingSource.Filter = "id =" + id;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Check if anything is actually selected in the BindingSource
                if (this.tbl_UsersBindingSource.Current == null)
                {
                    MessageBox.Show("Please select a user to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Confirm Deletion
                if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 3. Remove the currently selected row from the BindingSource
                    this.tbl_UsersBindingSource.RemoveCurrent();

                    // 4. Save changes to the database
                    this.tableAdapterManager.UpdateAll(this.nPIC_BCS_Y3_CDataSet);

                    MessageBox.Show("User has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the view
                    this.user_viewTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.user_view);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
