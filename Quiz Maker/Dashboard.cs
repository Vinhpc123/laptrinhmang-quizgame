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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        
     
        private void closensidebarbtn_Click(object sender, EventArgs e)
        {
            slidinglbl.Visible = false;
            sidepanel.Size = new Size(55, 514);
            sidepanel.Hide();///hide first para gumana ang animation
            sidebarcloseTransition.Show(sidepanel);///show pag katapos hide           
            opensidebarbtn.Visible = true;

          


            /////////create quiz panel
            create_Quiz_application1.Location = new Point(69, 37);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            create_Quiz_application1.Size = new Size(830, 450);
            create_Quiz_application1.Close_responsive("close");
            //////////////////////////////////////////////////////////

            /////////play quiz panel         
            play_Quiz_application1.Location = new Point(69, 37);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            play_Quiz_application1.Size = new Size(830, 450);
            play_Quiz_application1.Close_responsive("close");
            //////////////////////////////////////////////////////////


            /////////myaccount panel
            my_Account_application1.Location = new Point(69, 37);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            my_Account_application1.Size = new Size(830, 450);
            my_Account_application1.Close_responsive("close");
            //////////////////////////////////////////////////////////

            /////////Show Quiz list panel
            show_Quiz_List_application1.Location = new Point(69, 37);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            show_Quiz_List_application1.Size = new Size(830, 450);
            show_Quiz_List_application1.Close_responsive("close");
            //////////////////////////////////////////////////////////


          
        }

        private void opensidebarbtn_Click(object sender, EventArgs e)
        {
            slidinglbl.Visible = true;
            sidepanel.Size = new Size(245, 514);
            sidepanel.Hide();///hide first para gumana ang animation
            sidebaropenransition.Show(sidepanel);///show pag katapos hide
            opensidebarbtn.Visible = false;

            BProLogoPanel.Hide();
            logoTransition.Show(BProLogoPanel);


            /////////create quiz panel
            create_Quiz_application1.Location = new Point(245, 37);// para umurong yung main panel pag nag open na yung form
            create_Quiz_application1.Size = new Size(654, 450);
            create_Quiz_application1.Open_responsive("open");
            //////////////////////////////////////////////////////////

            /////////play quiz panel
            play_Quiz_application1.Location = new Point(245, 37);// para umurong yung main panel pag nag open na yung form
            play_Quiz_application1.Size = new Size(654, 450);
            play_Quiz_application1.Open_responsive("open");
            //////////////////////////////////////////////////////////


            /////////create quiz panel
            my_Account_application1.Location = new Point(245, 37);// para umurong yung main panel pag nag open na yung form
            my_Account_application1.Size = new Size(654, 450);
            my_Account_application1.Open_responsive("open");
            //////////////////////////////////////////////////////////


               /////////Show quiz list panel
            show_Quiz_List_application1.Location = new Point(245, 37);// para umurong yung main panel pag nag open na yung form
            show_Quiz_List_application1.Size = new Size(654, 450);
            show_Quiz_List_application1.Open_responsive("open");
            //////////////////////////////////////////////////////////


            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            slidinglbl.Text = "Thank you for using Quiz Game! ";


            ////// para sa first run ng system naka default yung size ng mga child form
            create_Quiz_application1.Location = new Point(245, 37);
            create_Quiz_application1.Size = new Size(654, 450);
            create_Quiz_application1.Open_responsive("open");








            ////para pag sa first run may animation yung side panel
            sidepanel.Size = new Size(245, 514);
            sidepanel.Hide();///hide first para gumana ang animation
            sidebaropenransition.Show(sidepanel);///show pag katapos hide
            opensidebarbtn.Visible = false;

            BProLogoPanel.Hide();
            logoTransition.Show(BProLogoPanel);
        }

        private void createquizbtn_Click(object sender, EventArgs e)
        {
            play_Quiz_application1.Hide();
            my_Account_application1.Hide();
            create_Quiz_application1.Hide();
            show_Quiz_List_application1.Hide();
            childformTransition.Show(create_Quiz_application1);          
            create_Quiz_application1.refresh(); 




            /// changing color ng button kung saan yung pinindot nya
          
            myaccountbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            playquizbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            createquizbtn.Normalcolor = Color.Gray;
            viewquizlistbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            logoutbtn.Normalcolor = Color.FromArgb(64, 64, 64);
        }



        private void myaccountbtn_Click(object sender, EventArgs e)
        {
            play_Quiz_application1.Hide();
            my_Account_application1.Hide();
            create_Quiz_application1.Hide();
            show_Quiz_List_application1.Hide();
            childformTransition.Show(my_Account_application1);
            my_Account_application1.refresh();//para yung image laging nakaset sa napiling image


            /// changing color ng button kung saan yung pinindot nya

            myaccountbtn.Normalcolor = Color.Gray;
            playquizbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            createquizbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            viewquizlistbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            logoutbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            
        }

        private void playquizbtn_Click(object sender, EventArgs e)
        {
            play_Quiz_application1.Hide();
            my_Account_application1.Hide();
            create_Quiz_application1.Hide();
            show_Quiz_List_application1.Hide();
            childformTransition.Show(play_Quiz_application1);
            play_Quiz_application1.refresh(); // para mag set ulit sa default na wala pang napipiling quiz


            /// changing color ng button kung saan yung pinindot nya

            myaccountbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            playquizbtn.Normalcolor = Color.Gray;
            createquizbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            viewquizlistbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            logoutbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            
        }
        private void viewquizlistbtn_Click(object sender, EventArgs e)
        {

            play_Quiz_application1.Hide();
            my_Account_application1.Hide();
            create_Quiz_application1.Hide();
            show_Quiz_List_application1.Hide();
            childformTransition.Show(show_Quiz_List_application1);
            show_Quiz_List_application1.refresh(); // para mag set ulit sa default na wala pang napipiling quiz

            /// changing color ng button kung saan yung pinindot nya

            myaccountbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            playquizbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            createquizbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            viewquizlistbtn.Normalcolor = Color.Gray;
            logoutbtn.Normalcolor = Color.FromArgb(64, 64, 64);
        }


        private void logoutbtn_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Login_Form form = new Login_Form();
                form.Show();
                this.Hide();
            }

            /// changing color ng button kung saan yung pinindot nya

            myaccountbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            playquizbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            createquizbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            viewquizlistbtn.Normalcolor = Color.FromArgb(64, 64, 64);
            logoutbtn.Normalcolor = Color.Gray;
       
          
        }
        int textslide = 0;
        private void slidinglabel_Tick(object sender, EventArgs e) /// para sa text sa sidebar gumagalaw
        {

            textslide = textslide -5;
            if(slidinglbl.Left  > -1000)
            {
                slidinglbl.Left = textslide;
            }
            else
            {
                textslide = 245;
                slidinglbl.Left = textslide;
                
            }

            
        }

        private void exit_application1_Load(object sender, EventArgs e)
        {

        }

        private void mycodename_Click(object sender, EventArgs e)
        {

        }
    }
}
