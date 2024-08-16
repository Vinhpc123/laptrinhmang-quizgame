using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     
     

        private void Form1_Load(object sender, EventArgs e)
        {
            startbtn.Location = new Point(0, -100); // para mahide yung button
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value++;
            if(ProgressBar1.Value == 100)
            {
                timer1.Stop();
                startbtn.PerformClick();
   
            }
            if(ProgressBar1.Value == 10)
            {
                initializinglbl.Location = new Point(172, 324); //para align paring sa center
                initializinglbl.Text = "Welcome to Group3 Quiz Game";
                
            }
            if (ProgressBar1.Value == 30)
            {
                initializinglbl.Location = new Point(215, 324); //para align paring sa center
                initializinglbl.Text = "Group3 Loading...";
               
            }
            if (ProgressBar1.Value == 60)
            {
                initializinglbl.Location = new Point(215, 324); //para align paring sa center
                initializinglbl.Text = "Group3 Preparing data...";
               
            }
            if (ProgressBar1.Value == 90)
            {
                initializinglbl.Location = new Point(215, 324); //para align paring sa center
                initializinglbl.Text = "Group3 Initializing data...";
            }
            

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();
            form.Show();
            this.Hide();
        }

        private void initializinglbl_Click(object sender, EventArgs e)
        {

        }
    }
}
