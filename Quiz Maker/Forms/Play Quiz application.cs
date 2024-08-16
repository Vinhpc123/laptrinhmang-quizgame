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
    public partial class Play_Quiz_application : UserControl
    {
        public Play_Quiz_application()
        {
            InitializeComponent();
        }
        public static int timelevel = 60; // para sa level pag nag select
        private void Play_Quiz_application_Load(object sender, EventArgs e)
        {
           

        }
        public void refresh()
        {
            ////remove all yung mga list 
            questionlist.Clear();
            answerlist.Clear();
            ///////////////////////////////////

            ///////para mapindot ulit yung mga radio button
            easyrbtn.Enabled = true;
            mediumrbtn.Enabled = true;
            hardrbtn.Enabled = true;


            quiznametbx.Enabled = true;
            questiontbx.Text = "";
            answertbx.Text = "";
            correctanswertbx.Text = "";

            ////remove muna lahat ng mga data sa gridview para pag nag quiz ulit wala yung dating result ng quiz
            ViewResultGridview.Rows.Clear();
            viewresultpanel.Hide(); //


            i = 1; // set muna sa default value yung kung pang ilang question
            row = 0; ///set muna sa default value  para ma lagay lahat ng mga na sagutan ng question ilalagay narin yung correct answer
            score = 0;///set muna sa default value
            totalnumber = 0; /// para malaman ng system kung ilang quiz items
            try
            {
                startplaybtn.Visible = true;
                easyrbtn.Select();/// para laging easy mode yung simula
                quiznametbx.Clear(); //para mabura yung naunang value
                //select yung mga name ng quiz sa database lalagay sa combobox
                Database.DBConnection.Database.Open();
                Database.DBConnection.SetCommand("Select Distinct(IDQuizName) from CreateQuiz_Table where IDUsername ='" + Login_application.username + "' ORDER By IDQuizName asc");
                OleDbDataReader selectreader = Database.DBConnection.Command.ExecuteReader();
                while (selectreader.Read())
                {
                    quiznametbx.RemoveItem(selectreader["IDQuizName"].ToString());//remove muna yung unang value para walang duplicate
                    quiznametbx.AddItem(selectreader["IDQuizName"].ToString());// add na yung new value para walang duplicate sa combobox
                }
                Database.DBConnection.Database.Close();

                playpanel.Hide(); // hide muna ang panel kasi wala pang quiz na napipili
            }
            catch (Exception Error_Message)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n" + Error_Message.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Database.DBConnection.Database.Close();
            }
        
        }
        
        public void Close_responsive(string setresponsive)// para yung form uurong sa dulo
        {


            playpanel.Size = new Size(801, 299); // play panel
            ViewResultGridview.Size = new Size(795, 169);
            viewresultpanel.Size = playpanel.Size; // pa same size sila lagi ng play panel
            questiontbx.Size = new Size(768, 110); // qestiontbx
            nextanswerbtn.Location = new Point(647, 233); //nextbtn
            donequizbtn.Location = new Point(647, 244); // yung sa viewresult panel to
            exportexcelbtn.Location = new Point(500, 244);
            answertbx.Size = new Size(552, 35);
            timerpanel.Location = new Point(700, -4);
            


        }
        public void Open_responsive(string setresponsive)// para yung form babalik sa dating pwesto
        {
            playpanel.Size = new Size(627, 299); // play panel
            ViewResultGridview.Size = new Size(625, 169);
            viewresultpanel.Size = playpanel.Size; // pa same size sila lagi ng play panel
            questiontbx.Size = new Size(598, 110); // qestiontbx
            nextanswerbtn.Location = new Point(476, 233); //nextbtn
            donequizbtn.Location = new Point(476, 244);// yung sa viewresult panel to
            exportexcelbtn.Location = new Point(330, 243);
            answertbx.Size = new Size(380, 35);
            timerpanel.Location = new Point(530, -4);
        }




        List<string> questionlist = new List<string>(); // para sa pag display ng question
        List<string> answerlist = new List<string>(); // para sa pag validate kung tama sagot ng naglalaro
        public static int countitems = 0;
        public static int totalnumber = 0; // para malaman kung  ilang items yung quiz
        private void startplaybtn_Click(object sender, EventArgs e)
        {
          
          try
          {
              countitems = 0;
              //kapag walang piniling value sa gridview
              if (quiznametbx.selectedIndex != -1)
              {
                  //set ng timer
                  if (easyrbtn.Checked)
                  {
                      quiztimer.Enabled = false;
                      timerpanel.Visible = false; // hide ang timer
                      timerlbl.Text = "";
                  }
                  if (mediumrbtn.Checked)
                  {
                      timerlbl.Text = "";
                      timelevel = 60; // 60 seconds sa medium
                      quiztimerprogressbar.MaxValue = 60;
                      quiztimerprogressbar.Value = timelevel;
                      timerpanel.Visible = true; // show ang timer
                      quiztimer.Enabled = true;

                  }
                  if (hardrbtn.Checked)
                  {
                      timerlbl.Text = "";
                      timelevel = 30; // 60 seconds sa medium
                      quiztimerprogressbar.MaxValue = 30;
                      quiztimerprogressbar.Value = timelevel;
                      timerpanel.Visible = true; // show ang timer
                      quiztimer.Enabled = true;
                  }



                  Database.DBConnection.Database.Open();
                  Database.DBConnection.SetCommand("Select * from CreateQuiz_Table where IDUsername ='" + Login_application.username + "' AND IDQuizName = '" + quiznametbx.selectedValue.ToString() + "' ORDER By IDNumber asc");
                  OleDbDataReader selectreader = Database.DBConnection.Command.ExecuteReader();
                  while (selectreader.Read())
                  {

                      /////add na yung mga question and correct answer sa ginawa nating list
                      questionlist.Add(selectreader["IDQuestion"].ToString());
                      answerlist.Add(selectreader["IDAnswer"].ToString());
                      highscore = Convert.ToInt32(selectreader["IDHighScore"].ToString());
                      countitems++; ///guide kung ilang question yung sasagutan // at ito din ang gagamitin para marandom ang question pag nag decrement tayo
                      totalnumber++; // para maku
                  }
                  Database.DBConnection.Database.Close();
                  playpanel.Show();
                  viewresultpanel.Visible = false; // para nakahide alway yung view result
                  ////////////////////para maset ang unang question at unang sagot
                  Random rand = new Random();
                  int randomnumber = rand.Next(0, countitems);
                  questiontbx.Text = questionlist.ElementAt(randomnumber);
                  correctanswertbx.Text = answerlist.ElementAt(randomnumber);
                  answerlist.Remove(correctanswertbx.Text); // para wala na rin yung answer sa list
                  questionlist.Remove(questiontbx.Text); // para wala na rin yung question sa list
                  countitems--;// para mabawasan yung items kung tapos na yung isang items sagutan di na kasali max items
                  numlbl.Text = i.ToString();///para alam ng student kung pang ilang question na sinasagutan nila
                  startplaybtn.Visible = false; /// para hindi makakapag play kapag nag lalaro na ang player
                  answertbx.Focus(); // para lagi dun ang focus para tuloy tuloy ang pag sagot 
                  quiznametbx.Enabled = false; // para di machange yung quizname habang nag sasagot yung user
                  cancelquizbtn.Visible = true; /// para pwede nilang cancel ang quiz kapag nag play na sila
                  
                  /////para hindi mapindot yung radio button
                  easyrbtn.Enabled = false;
                  mediumrbtn.Enabled = false;
                  hardrbtn.Enabled = false;


              }
              else
              {
                  MetroFramework.MetroMessageBox.Show(this, "\n\nPlease select a quiz first", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
             
           
          }
          catch (Exception Error_Message)
          {
              MetroFramework.MetroMessageBox.Show(this, "\n" + Error_Message.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
              Database.DBConnection.Database.Close();
          }

         
            
        }
        public static int i = 1;
        public static int row = 0; /// para ma lagay lahat ng mga na sagutan ng question ilalagay narin yung correct answer
        public static int score = 0; // count kung ilang score ng player
        public static int highscore = 0; // kung ilan nag previews score nya para mag update if nalagpasan nya
        private void nextanswerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Answervalidation = ""; // kung tama or mali ang sagot
                if (answertbx.Text.ToUpper() == correctanswertbx.Text.ToUpper())
                {
                    Answervalidation = "Correct";
                    score++;
                }
                else
                {
                    Answervalidation = "Wrong";
                }




                //////////////////////////////////////////////////////////////////////////

                if (i == totalnumber) /// para malaman kung last question na
                {

                    /////////////////////viewing ng result pag tapos na ang quiz nag add ng row sa gridview
                    ViewResultGridview.Rows.Add();// add new Row sa view result gridview
                    ViewResultGridview.Rows[row].Cells[0].Value = i.ToString();//Number
                    ViewResultGridview.Rows[row].Cells[1].Value = questiontbx.Text;//Question
                    ViewResultGridview.Rows[row].Cells[2].Value = correctanswertbx.Text;//Correct Answer
                    ViewResultGridview.Rows[row].Cells[3].Value = answertbx.Text;//your  Answer
                    ViewResultGridview.Rows[row].Cells[4].Value = Answervalidation;//Correct Answer

                    if(score > highscore)
                    {
                        Database.DBConnection.Database.Open();
                        Database.DBConnection.SetCommand("Update CreateQuiz_Table set IDHighScore ='" + score.ToString() + "' where IDUsername ='" + Login_application.username + "' AND IDQuizName = '" + quiznametbx.selectedValue.ToString() + "'");
                        OleDbDataReader updatereader = Database.DBConnection.Command.ExecuteReader();
                        Database.DBConnection.Database.Close();

                    }
                  
                    scorelbl.Text = "Your score is : " + score.ToString();
                    MetroFramework.MetroMessageBox.Show(this, "\n\nView your scores", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    playquizpanelTrainsition.Show(viewresultpanel);
                    playpanel.Hide();
                    cancelquizbtn.Hide();
                    quiztimer.Enabled = false; /// para mag stop yung timer pag tapos na yung quiz
                }
                else
                {
                    //////para sa pag start ng timer
                    timerlbl.Text = timelevel.ToString(); // para mag reset ulit sa time na sinelect nila
                    quiztimerprogressbar.Value = timelevel;// para mag reset ulit sa time na sinelect nila


                    /////////////////////viewing ng result pag tapos na ang quiz nag add ng row sa gridview
                    ViewResultGridview.Rows.Add();// add new Row sa view result gridview
                    ViewResultGridview.Rows[row].Cells[0].Value = i.ToString();//Number
                    ViewResultGridview.Rows[row].Cells[1].Value = questiontbx.Text;//Question
                    ViewResultGridview.Rows[row].Cells[2].Value = correctanswertbx.Text;//Correct Answer
                    ViewResultGridview.Rows[row].Cells[3].Value = answertbx.Text;//your  Answer
                    ViewResultGridview.Rows[row].Cells[4].Value = Answervalidation;//Correct Answer


                    row++;/// para pag nag next new row ulit



                    /////////////set yung question as random 
                    Random rand = new Random();
                    int randomnumber = rand.Next(0, countitems);
                    questiontbx.Text = questionlist.ElementAt(randomnumber);
                    correctanswertbx.Text = answerlist.ElementAt(randomnumber);




                    //////////////////////Reremove na yung Question at answer kapag napindot na yung next //para random ang question
                    answerlist.Remove(correctanswertbx.Text); // para wala na rin yung answer sa list
                    questionlist.Remove(questiontbx.Text); // para wala na rin yung question sa list
                    countitems--;// para mabawasan yung items kung tapos na yung isang items sagutan di na kasali max items
                    i++;
                    numlbl.Text = i.ToString();///para alam ng student kung pang ilang question na sinasagutan nila
                    answertbx.Text = "";//clear yung text para makapag enter ng new answer
                    answertbx.Focus(); // para lagi dun ang focus para tuloy tuloy ang pag sagot 
                  
                }
         
            }
            catch
            {

            }
          
             
            
        
        }

        private void donequizbtn_Click(object sender, EventArgs e)
        {
           
            refresh();// reset na ulit lahat sa original          
        }

        private void exportexcelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ViewResultGridview.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
                    excelapp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < ViewResultGridview.Columns.Count + 1; i++)
                    {
                        excelapp.Cells[1, i] = ViewResultGridview.Columns[i - 1].HeaderText;

                    }
                    for (int i = 0; i < ViewResultGridview.Rows.Count; i++)
                    {
                        for (int j = 0; j < ViewResultGridview.Columns.Count; j++)
                        {
                            excelapp.Cells[i + 2, j + 1] = ViewResultGridview.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    excelapp.Columns.AutoFit();
                    excelapp.Visible = true;
                }
            }
            catch (Exception Error_Message)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n" + Error_Message.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void answertbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               ///// nag ganito tayong code nag create ng  button gamit ang codes kasi walang perform that click ang bunifu button kaya gumawa nalang ako ng bagong button
               Button Enter = new Button();
               Enter.Click += new System.EventHandler(nextanswerbtn_Click);
               Controls.Add(Enter);
               Enter.Location = new Point(0, -100); // para hindi makita sa GUI yung button nakatago lang 
               Enter.PerformClick();
              
            }
        }

        private void quiztimer_Tick(object sender, EventArgs e)
        {
            timerlbl.Text = quiztimerprogressbar.Value.ToString();
            quiztimerprogressbar.Value--;

          
                if (quiztimerprogressbar.Value == 0)
                {
                    ///// nag ganito tayong code nag create ng  button gamit ang codes kasi walang perform that click ang bunifu button kaya gumawa nalang ako ng bagong button
                    Button Enter = new Button();
                    Enter.Click += new System.EventHandler(nextanswerbtn_Click);
                    Enter.Location = new Point(0, -100); // para hindi magpakita sa form at nakahide lang 
                    Controls.Add(Enter);
                    Enter.PerformClick();         
                }
           
        }

        private void cancelquizbtn_Click(object sender, EventArgs e)
        {
            refresh();
            quiztimer.Enabled = false;
            cancelquizbtn.Visible = false; //  hide cancel button

  
        }
    }
}
