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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void tbl_ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_ProductsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_BCS_Y3_CDataSet);

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nPIC_BCS_Y3_CDataSet.tbl_Products' table. You can move, or remove it, as needed.
            this.tbl_ProductsTableAdapter.Fill(this.nPIC_BCS_Y3_CDataSet.tbl_Products);

        }
    }
}
