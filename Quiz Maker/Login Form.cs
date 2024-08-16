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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        


        private void Login_Form_Load(object sender, EventArgs e)
        {
            panelTransition.Show(panel);
            bprologoTransition.Show(bpropanel);
            // Ensure only the login form is visible when the form loads
            login_application1.Visible = true;
            registration_application1.Visible = false;

            // Show the Register button and hide the Back button (if there is one)
            Showregistrationbtn.Visible = true;
            Showloginbtn.Visible = false; // Hide login button initially
            

            // Set button texts, if necessary
            Showregistrationbtn.Text = "Register";
            Showloginbtn.Text = "Login";
        }

        public void Showregistrationbtn_Click(object sender, EventArgs e)
        {
            // Show the registration form and hide the login form
            registration_application1.Visible = true;
            login_application1.Visible = false;

            // Show the login button, hide the register button
            Showloginbtn.Visible = true;
            Showregistrationbtn.Visible = false;

            // If you need a Back button, control its visibility here
            
        }

        public void Showloginbtn_Click(object sender, EventArgs e)
        {
            // Show the login form and hide the registration form
            login_application1.Visible = true;
            registration_application1.Visible = false;

            // Show the register button, hide the login button
            Showregistrationbtn.Visible = true;
            Showloginbtn.Visible = false;

            
        }




        private void mycodename_Click(object sender, EventArgs e)
        {

        }
    }
}
