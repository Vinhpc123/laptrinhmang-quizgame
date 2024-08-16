using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Quiz_Maker.Forms
{
    public partial class Exit_application : UserControl
    {
        
        public Exit_application()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
           DialogResult yesno = MetroFramework.MetroMessageBox.Show(this,"\n\nAre you sure you want to exit?","Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
           if (yesno == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
