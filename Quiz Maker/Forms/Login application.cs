using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Quiz_Maker.Forms
{
    public partial class Login_application : UserControl
    {       
        public Login_application()
        {
            InitializeComponent();
        }
        
        private void showpasswordbtn_Click(object sender, EventArgs e)
        {
            if (passwordtbx.UseSystemPasswordChar == true)
            {
                passwordtbx.UseSystemPasswordChar = false;
                showpasswordbtn.Image = Properties.Resources.EyeShow;
               
            }
            else
            {
                passwordtbx.UseSystemPasswordChar = true;
                showpasswordbtn.Image = Properties.Resources.EyeHide;
    
            }
          
        }

        public static string name = "";
        public static string username = "";
        public static string password = "";
        private void loginbtn_Click(object sender, EventArgs e)
        {

         

            try
            {
                if (usernametbx.Text == "" || passwordtbx.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease fill up the form", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Database.DBConnection.Database.Open();
                    Database.DBConnection.SetCommand("Select * from Account_Table where IDUsername = '" + usernametbx.Text.ToUpper() + "' AND IDPassword = '" + passwordtbx.Text.ToUpper() + "'");
                    OleDbDataReader selectreader = Database.DBConnection.Command.ExecuteReader();
                    int count = 0;/// for validation if meron talagang account
                    while (selectreader.Read())
                    {
                        name = selectreader["IDName"].ToString();
                        username = selectreader["IDUsername"].ToString();
                        password = selectreader["IDPassword"].ToString(); 
                        count++;
                    }
                    if (count > 0) /// now validating
                    {
                        ///if nag 1 ang count merong account
                        Dashboard form = new Dashboard();
                        form.Show();
                        ParentForm.Hide(); /// para mawala yung parent form
                       


                    }
                    else
                    {
                        //if 0 ang count walang account
                        MetroFramework.MetroMessageBox.Show(this, "\n\nWrong password or username", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Database.DBConnection.Database.Close();
                }

            }
            catch (Exception Error_Message)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n" + Error_Message.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Database.DBConnection.Database.Close();
            }
         
        }
        private void No_Quotation_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////// para hindi mag kaerror pag nag iinsert sa database
            string notallowed = "'";
            char ch = e.KeyChar;
            if (e.KeyChar == Convert.ToChar(notallowed)) // avoid single quotation 
            {
                e.Handled = true;
            }
            else if (Char.IsLetter(ch) || Char.IsDigit(ch) || ch == 8 || Char.IsSymbol(ch)) // avoid naman ang copy paste
            {

            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
