using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPIC.BCS.Y3.C.Sophanith.pages
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        private void tbl_CategoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_CategoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_BCS_Y3_CDataSet);

        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nPIC_BCS_Y3_CDataSet.tbl_Categories' table. You can move, or remove it, as needed.
            this.tbl_CategoriesTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.tbl_Categories);

        }
    }
}
