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
    public partial class registration_application : UserControl
    {
        public registration_application()
        {
            InitializeComponent();
        }

        private void showpasswordbtn_Click(object sender, EventArgs e)
        {
            if (passwordtbx2.UseSystemPasswordChar == true)
            {
                passwordtbx1.UseSystemPasswordChar = false;
                passwordtbx2.UseSystemPasswordChar = false;
                showpasswordbtn.Image = Properties.Resources.EyeShow;
            }
            else
            {
                passwordtbx1.UseSystemPasswordChar = true;
                passwordtbx2.UseSystemPasswordChar = true;
                showpasswordbtn.Image = Properties.Resources.EyeHide;

            }

        
        }

        private void createbtn_Click(object sender, EventArgs e)
        {


           
            try
            {
                if(usernametbx.Text == ""|| passwordtbx1.Text == ""|| passwordtbx2.Text == "" || nametbx.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease fill up the form", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (passwordtbx1.Text.ToUpper() == passwordtbx2.Text.ToUpper())
                {

                    ///count if the username is duplicate //avoiding duplication
                    Database.DBConnection.Database.Open();
                    Database.DBConnection.SetCommand("Select Count(*) From Account_Table where IDUsername = '"+usernametbx.Text.ToUpper()+"'");
                    int countreader =  Convert.ToInt32(Database.DBConnection.Command.ExecuteScalar());
                    Database.DBConnection.Database.Close();
                    if(countreader > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\nAccount has already registered", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                       
                        ////insert data from database if username has no same value
                        Database.DBConnection.Database.Open();
                        Database.DBConnection.SetCommand("Insert into Account_Table (IDUsername,IDPassword,IDName) values ('" + usernametbx.Text.ToUpper().Replace("'", "`") + "','" + passwordtbx1.Text.ToUpper().Replace("'", "`") + "','" + nametbx.Text.ToUpper().Replace("'", "`") + "')");
                        OleDbDataReader insertreader = Database.DBConnection.Command.ExecuteReader();                      
                        Database.DBConnection.Database.Close();
                        Image defaultimage = defaultImage.Image;
                        defaultimage.Save(Environment.CurrentDirectory+@"\Images\" + usernametbx.Text.ToUpper() + ".png");
                        MetroFramework.MetroMessageBox.Show(this, "\n\nAccount has been created", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    
                 
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"\n\nPassword not match", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Error_Message)
            {
                MetroFramework.MetroMessageBox.Show(this,"\n"+Error_Message.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Database.DBConnection.Database.Close();
            }

         
          
        }
        private void No_Quotation_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
    }
}
