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
using System.IO;

namespace Quiz_Maker.Forms
{
    public partial class My_Account_application : UserControl
    {
        public My_Account_application()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";
        }
        public void Close_responsive(string setresponsive)
        {
            
            nametbx.Size = new Size(500, 35);
            usernametbx.Size = new Size(500, 35);
            changepasswordbtn.Size = new Size(500, 40);


            avatarbtn.Location = new Point(667, 19); // para yung image ng avatar uurong sa dulo
            uploadimagebtn.Location = new Point(667, 127); // para yung upload image uurong sa dulo
            avatarpanel.Size = new Size(801, 254); // avatar panel
            cancelbtn2.Location = new Point(640, 194);//cancel avatar panel


            ///para sa paglipat ng position ng mga avatar para kunwari responsive   uurong sa dulo
            selectAvatar7.Location = new Point(621, 74);
            selectAvatar8.Location = new Point(722, 74);
            selectAvatar9.Location = new Point(17, 138);
            
           
        }
        public void Open_responsive(string setresponsive)
        {
            
            nametbx.Size = new Size(344, 35);
            usernametbx.Size = new Size(344, 35);
            changepasswordbtn.Size = new Size(344, 40);


            avatarbtn.Location = new Point(492, 19); // para yung image ng avatar babalik sa dating pwesto
            uploadimagebtn.Location = new Point(492, 127); // para yung upload image babalik sa dating pwesto
            avatarpanel.Size = new Size(619, 254); // avatar panel
            cancelbtn2.Location = new Point(450, 194);//cancel avatar panel

            ///para sa paglipat ng position ng mga avatar para kunwari responsive balik sa dating pwesto
            selectAvatar7.Location = new Point(17, 138);
            selectAvatar8.Location = new Point(118, 138);
            selectAvatar9.Location = new Point(219, 138);
            
            

            //
            
        }
        private void My_Account_application_Load(object sender, EventArgs e)
        {
            nametbx.Text = Login_application.name;
            usernametbx.Text = Login_application.username;
        }

        private void changepasswordbtn_Click(object sender, EventArgs e) //show changepasswordpanel
        {
            /// para walang value yung mga textbox kapag mag chechange
            passwordtbx1.Text = "";
            passwordtbx2.Text = "";
            oldpasswordtbx.Text = "";
            myaccountpanelTransition.Hide(avatarpanel);
            myaccountpanelTransition.Show(changepasswordpanel);
          
        }

        private void cancelbtn_Click(object sender, EventArgs e) // hide panel
        {
            myaccountpanelTransition.Hide(changepasswordpanel);
            myaccountpanelTransition.Hide(avatarpanel);
        }

        private void avatarbtn_Click(object sender, EventArgs e)//show avatar panel
        {
            myaccountpanelTransition.Hide(changepasswordpanel);   
            myaccountpanelTransition.Show(avatarpanel);
                    
        }

        private void uploadimagebtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog upload = new OpenFileDialog();
                upload.Filter = "(*.jpg;*jpeg;*.png;) |*.jpg;*jpeg;*.png;";
                if (upload.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    avatarbtn.Image = new Bitmap(upload.FileName);
                    DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to change?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes) // mapapalitan na yung image nya
                    {
                        avatarbtn.Image.Save(Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png");
                    }
                    else // babalik sa dating profile picture or avatar image
                    {
                        avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";


                    }
                }
            }
            catch
            {

            }
          
        }
        private void selectAvatar1_Click(object sender, EventArgs e)
        {
            try
            {
                //pag nag click ng image ng avatar para palitan ang profile
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to change?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) // mapapalitan na yung image nya
                {
                    selectAvatar1.Image.Save(Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"); // pinalitan ang image sa folder 
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"; // sinelect yung bagong image
                }
                else // babalik sa dating profile picture or avatar image
                {
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";
                }
            }
            catch
            {

            }      
        }

        private void selectAvatar2_Click(object sender, EventArgs e)
        {
            try
            {
                //pag nag click ng image ng avatar para palitan ang profile
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to change?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) // mapapalitan na yung image nya
                {
                    selectAvatar2.Image.Save(Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"); // pinalitan ang image sa folder 
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"; // sinelect yung bagong image
                }
                else // babalik sa dating profile picture or avatar image
                {
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";
                }
            }
            catch
            {

            }
           
        }

        private void selectAvatar3_Click(object sender, EventArgs e)
        {
            try
            {
                //pag nag click ng image ng avatar para palitan ang profile
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to change?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) // mapapalitan na yung image nya
                {
                    selectAvatar3.Image.Save(Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"); // pinalitan ang image sa folder 
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"; // sinelect yung bagong image
                }
                else // babalik sa dating profile picture or avatar image
                {
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";
                }
            }
            catch
            {

            }
           
        }

        private void selectAvatar4_Click(object sender, EventArgs e)
        {
            try
            {
                //pag nag click ng image ng avatar para palitan ang profile
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to change?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) // mapapalitan na yung image nya
                {
                    selectAvatar4.Image.Save(Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"); // pinalitan ang image sa folder 
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"; // sinelect yung bagong image
                }
                else // babalik sa dating profile picture or avatar image
                {
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";
                }
            }
            catch
            {

            }
           
        }

        private void selectAvatar5_Click(object sender, EventArgs e)
        {
            try
            {
                //pag nag click ng image ng avatar para palitan ang profile
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to change?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) // mapapalitan na yung image nya
                {
                    selectAvatar5.Image.Save(Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"); // pinalitan ang image sa folder 
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"; // sinelect yung bagong image
                }
                else // babalik sa dating profile picture or avatar image
                {
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";
                }
            }
            catch
            {

            }
            
        }

        private void selectAvatar6_Click(object sender, EventArgs e)
        {
            try
            {
                //pag nag click ng image ng avatar para palitan ang profile
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to change?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) // mapapalitan na yung image nya
                {
                    selectAvatar6.Image.Save(Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"); // pinalitan ang image sa folder 
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"; // sinelect yung bagong image
                }
                else // babalik sa dating profile picture or avatar image
                {
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";
                }
            }
            catch
            {

            }
           
        }

        private void selectAvatar7_Click(object sender, EventArgs e)
        {
            try
            {
                //pag nag click ng image ng avatar para palitan ang profile
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to change?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) // mapapalitan na yung image nya
                {
                    selectAvatar7.Image.Save(Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"); // pinalitan ang image sa folder 
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"; // sinelect yung bagong image
                }
                else // babalik sa dating profile picture or avatar image
                {
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";
                }
            }
            catch
            {

            }
          
        }

        private void selectAvatar8_Click(object sender, EventArgs e)
        {
            try
            {
                //pag nag click ng image ng avatar para palitan ang profile
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to change?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) // mapapalitan na yung image nya
                {
                    selectAvatar8.Image.Save(Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"); // pinalitan ang image sa folder 
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"; // sinelect yung bagong image
                }
                else // babalik sa dating profile picture or avatar image
                {
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";
                }
            }
            catch
            {

            }
            
        }

        private void selectAvatar9_Click(object sender, EventArgs e)
        {
            try
            {
                //pag nag click ng image ng avatar para palitan ang profile
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to change?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) // mapapalitan na yung image nya
                {
                    selectAvatar9.Image.Save(Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"); // pinalitan ang image sa folder 
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png"; // sinelect yung bagong image
                }
                else // babalik sa dating profile picture or avatar image
                {
                    avatarbtn.ImageLocation = Environment.CurrentDirectory + @"\Images\" + Login_application.username + ".png";
                }
            }
            catch
            {

            }
          
        }

        private void changepassbtn_Click(object sender, EventArgs e)
        {
            try
            {
                 if(usernametbx.Text == ""|| passwordtbx1.Text == ""|| passwordtbx2.Text == "" || oldpasswordtbx.Text== "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease fill up the form", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                 
                 else if (oldpasswordtbx.Text.ToUpper() == Login_application.password)
                 {

                     if (passwordtbx1.Text.ToUpper() == passwordtbx2.Text.ToUpper())
                     {
                         Database.DBConnection.Database.Open();
                         Database.DBConnection.SetCommand("Update Account_table set IDPassword = '" + passwordtbx1.Text.ToUpper().Replace("'", "`") + "' where IDUsername = '" + Login_application.username.Replace("'", "`") + "'");
                         OleDbDataReader updatereader = Database.DBConnection.Command.ExecuteReader();
                         Database.DBConnection.Database.Close();
                         DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nPassword has been change\nDo you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                         if (dialog == DialogResult.Yes)
                         {
                             Login_Form form = new Login_Form();
                             form.Show();
                             ParentForm.Hide();
                         }
                         Login_application.password = passwordtbx1.Text.ToUpper(); /// para yung variables mapalitan din yung value kung papalit ulit yung user
                         passwordtbx1.Text = "";
                         passwordtbx2.Text = "";
                         oldpasswordtbx.Text = "";
                     }
                     else
                     {
                         MetroFramework.MetroMessageBox.Show(this, "\n\nPassword not match", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }

                    
                 }
                 else
                 {
                     MetroFramework.MetroMessageBox.Show(this, "\n\nWrong old password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

            }
            catch (Exception Error_Message)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n" + Error_Message.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Database.DBConnection.Database.Close();
            }

          
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
