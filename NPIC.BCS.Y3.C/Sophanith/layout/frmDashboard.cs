using NPIC.BCS.Y3.C.Sophanith.function;
using NPIC.BCS.Y3.C.Sophanith.pages;
using NPIC.BCS.Y3.C.Sophanith.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPIC.BCS.Y3.C.Sophanith.layout
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            GB.SCREEN = this.PnlScreen;
            GB.OpenForm(new frmHome());

        }

        private void btnuser_Click(object sender, EventArgs e)
        {
           
            GB.OpenForm(new user.frmUser());
        }

        private void btnhomepage_Click(object sender, EventArgs e)
        {
            GB.OpenForm(new frmHome());
        }

        private void btncategories_Click(object sender, EventArgs e)
        {
            GB.OpenForm(new pages.FrmCategories());
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            GB.OpenForm(new FrmProduct());
        }
    }
    
}
