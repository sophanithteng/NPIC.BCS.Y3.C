using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPIC.BCS.Y3.C.Sophanith.function
{
    internal class GB
    {
        public static string nickname = string.Empty;
        public static string name = string.Empty;


        public static Panel SCREEN = null;
        public static void OpenForm(Form Form)
        {
            if (SCREEN == null)
            {
                return;
            }
            if (Form == null)
            {
                return;
            }
            SCREEN.Controls.Clear();
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            Form.TopLevel = false;
            Form.Show();
            SCREEN.Controls.Add(Form);
            
            
        }
    }
}
