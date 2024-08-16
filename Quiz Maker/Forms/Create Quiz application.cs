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
    public partial class Create_Quiz_application : UserControl
    {
        public Create_Quiz_application()
        {
            InitializeComponent();
        }
        public static string responsive = "open";//default//// identify the form if the side bar is close or open

        public void Close_responsive(string setresponsive)
        {
            responsive = setresponsive;
            ///tinawag natin ang list ng mga textbox
            foreach (TextBox questiontbx in questionlist)
            {
                questiontbx.Size = new Size(786, 110);
                createquizbtn.Size = new Size(786, 48);
               
                
            }       
        }
        public void Open_responsive(string setresponsive)
        {
            responsive = setresponsive;
            ///tinawag natin ang list ng mga textbox
            foreach (TextBox questiontbx in questionlist)
            {
                questiontbx.Size = new Size(600, 110);
                createquizbtn.Size = new Size(600, 48);
     
            }
          
        }
        List<TextBox> questionlist = new List<TextBox>(); /// para lahat ng textbox maging responsive // at para masave sa database
        List<TextBox> answerlist = new List<TextBox>(); //para masave sa database// at ma remove
        List<Label> numberlist = new List<Label>(); //para masave sa database// at ma remove
        List<Label> questionlabellist = new List<Label>(); //para masave sa database// at ma remove
        List<Label> answerlabellist = new List<Label>(); //para masave sa database// at ma remove

        //para makabuo ng button textbox or label ///nilabas ko para matawag parin kahit saan
        TextBox questiontbx = new TextBox(); 
        Label numberlbl = new Label();
        Label questionlbl = new Label();
        Label answerlbl = new Label();
        TextBox answertbx = new TextBox();
        private void itemsbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if(quiznametbx.Text =="")
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease put name in your quiz first", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (itemnumtbx.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease input how many items you want in your quiz", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ///count if the quizname is duplicate //avoiding duplication
                    Database.DBConnection.Database.Open();
                    Database.DBConnection.SetCommand("Select Count(*) From CreateQuiz_Table where IDUsername = '" + Login_application.username + "' AND IDQuizName= '" + quiznametbx.Text.ToUpper() + "'");
                    int countreader = Convert.ToInt32(Database.DBConnection.Command.ExecuteScalar());
                    Database.DBConnection.Database.Close();
                    if (countreader > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\nQuiz name has already taken", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int totalnum = Convert.ToInt32(itemnumtbx.Text) + 1;
                        for (int i = 1; i < totalnum; i++)
                        {
                            numberlbl = new Label(); // number of questions
                            questionlbl = new Label(); /// create label for question
                            questiontbx = new TextBox();    // create question textbox  
                            answerlbl = new Label(); /// create label for answer
                            answertbx = new TextBox();    // create answer textbox  for the question
                            answertbx.Font = new Font("Century Gothic", 12, FontStyle.Bold); // para malaki yung font sa pag gawa ng answer
                            questionlbl.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                            numberlbl.Text = i.ToString();                     
                            questionlbl.Text = "Question "; // name the label question 
                            questiontbx.Multiline = true; /// multiline the question
                            questiontbx.Font = new Font("Century Gothic", 12, FontStyle.Bold); // para malaki yung font sa pag gawa ng question
                            answerlbl.Text = "Answer :"; // set text in answerlbl
                            answerlbl.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                            answertbx.Size = new Size(515, 20);

                        
                            if (responsive == "close") // identify the form if the side bar is close or open
                            {

                                questiontbx.Size = new Size(786, 110);
                                createquizbtn.Size = new Size(786, 48);
                            }
                            else
                            {
                                questiontbx.Size = new Size(600, 110); // size of the textbox question
                                createquizbtn.Size = new Size(600, 48);
                            }

                            //// starting position ng textbox at label every loop
                            numberlbl.Location = new Point(100, -83 + (i * 200));
                            questionlbl.Location = new Point(15, -90 + (i * 200));
                            questiontbx.Location = new Point(15, -60 + (i * 200));
                            answerlbl.Location = new Point(15, 60 + (i * 200));
                            answertbx.Location = new Point(100, 60 + (i * 200));
                            createquizbtn.Location = new Point(15, 100 + (i * 200)); /// ito yung create button natin always sa pinaka baba ng last question
                            /// 


                            Controls.Add(numberlbl);
                            Controls.Add(questiontbx);
                            Controls.Add(questionlbl);
                            Controls.Add(answertbx);
                            Controls.Add(answerlbl);



                         

                            questionlist.Add(questiontbx);/// para lahat ng textbox maging responsive // at isave sa database//ma remove
                            answerlist.Add(answertbx);/// para ma save sa database//ma remove
                            numberlist.Add(numberlbl);/// para ma save sa database//ma remove
                            questionlabellist.Add(questionlbl);/// para ma save sa database//ma remove
                            answerlabellist.Add(answerlbl);/// para ma save sa database//ma remove

                        
                        }
                        itemsbtn.Visible = false;
                        cancelquizbtn.Visible = true;
                        createquizbtn.Visible = true;
                        itemnumtbx.Enabled = false;
                        quiznametbx.Enabled = false;


                        
                       
                    }

                  
                }

            }
            catch
            {

            }
          
        }

   

        private void cancelquizbtn_Click(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            /// remove all controls and start new again
            try
            {
                foreach (TextBox questiontbx in questionlist)
                {
                    Controls.Remove(questiontbx);
                }
                foreach (TextBox answertbx in answerlist)
                {
                    Controls.Remove(answertbx);
                }
                foreach (Label numberlbl in numberlist)
                {
                    Controls.Remove(numberlbl);
                }
                foreach (Label questionlbl in questionlabellist)
                {
                    Controls.Remove(questionlbl);
                }
                foreach (Label answerlbl in answerlabellist)
                {
                    Controls.Remove(answerlbl);
                }
                itemnumtbx.Text = "";
                quiznametbx.Text = "";
                itemsbtn.Visible = true;
                cancelquizbtn.Visible = false;
                createquizbtn.Visible = false;
                itemnumtbx.Enabled = true;
                quiznametbx.Enabled = true;
            }
            catch
            {

            }
          
        }

        private void createquizbtn_Click(object sender, EventArgs e)
        {
            try
            {
               
               
                    int totalnum = Convert.ToInt32(itemnumtbx.Text); /// here we start to count in 0 kaya wala tayong + 1
                    for (int i = 0; i < totalnum; i++)
                    {
                        string question = questionlist.ElementAt(i).Text; //ElementAt para makuha natin yung na input nating value sa textbox hula lang code na toh 
                        string quiznumber = numberlist.ElementAt(i).Text;
                        string answer = answerlist.ElementAt(i).Text;


                        Database.DBConnection.Database.Open();
                        Database.DBConnection.SetCommand("Insert into CreateQuiz_Table (IDUsername, IDQuizName, IDNumber, IDQuestion, IDAnswer, IDToTal, IDHighScore) values('" + Login_application.username.Replace("'","`") + "','" + quiznametbx.Text.ToUpper().Replace("'", "`") + "','" + quiznumber.Replace("'", "`") + "','" + question.Replace("'", "`") + "','" + answer.Replace("'", "`") + "','" + itemnumtbx.Text.Replace("'", "`") + "','" + "0" + "')");
                        OleDbDataReader insertreader = Database.DBConnection.Command.ExecuteReader();
                        Database.DBConnection.Database.Close();
                    }
                    MetroFramework.MetroMessageBox.Show(this, "\n\nQuiz has been added to your list", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    refresh();
                    questionlist.Clear();
                
               
            }
            catch (Exception Error_Message)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n" + Error_Message.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Database.DBConnection.Database.Close();
            }

        }
        private void No_Quotation_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Number_Only(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Not_Zero_First(object sender, KeyEventArgs e)
        {
            if (itemnumtbx.Text == "0") //// para ma avoid yung pag input ng zero sa first input error yun
            {
                itemnumtbx.Text = "";
            }
        
            try
            {
                int itemnum = Convert.ToInt32(itemnumtbx.Text);

                if (itemnum > 100) // para  hanggang 100 lang pwedeng items ng quiz
                {
                    MessageBox.Show("The maximum items is only 100", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    itemnumtbx.Text = "";
                }

            }
            catch
            {

            }
           

        }      
    }
}