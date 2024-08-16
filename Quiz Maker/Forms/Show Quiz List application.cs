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
    public partial class Show_Quiz_List_application : UserControl
    {
        public Show_Quiz_List_application()
        {
            InitializeComponent();
        }
        public void Close_responsive(string setresponsive)// para yung form dulo
        {
            viewresultpanel.Size = new Size(801, 384); // sa panel view
            ViewQuizListGridview.Size = new Size(795, 293);        
            /////pag ishoshow na yung isang quizname
            showquizpanel.Size = new Size(801, 384);
            questiontbx.Size = new Size(768, 110); // qestiontbx
     

        }
        public void Open_responsive(string setresponsive)// para yung form babalik sa dating pwesto
        {
            viewresultpanel.Size = new Size(627, 384);// sa panel view
            ViewQuizListGridview.Size = new Size(620, 293);
            /////pag ishoshow na yung isang quizname
            showquizpanel.Size = new Size(627, 384);
            questiontbx.Size = new Size(598, 110); // qestiontbx



            
        }

        private void Show_Quiz_List_application_Load(object sender, EventArgs e)
        {
           
        }
        public void refresh() // reset muna lahat sa orginal 
        {
            try
            {
                Database.DBConnection.Database.Open();
                Database.DBConnection.SetCommand("Select Distinct(IDQuizName) ,IDTotal , IDHighScore from CreateQuiz_Table where IDUsername ='" + Login_application.username + "'");
                DataTable table = new DataTable();
                OleDbDataAdapter selectadapter = new OleDbDataAdapter(Database.DBConnection.Command);
                selectadapter.Fill(table);
                ViewQuizListGridview.DataSource = table;
                Database.DBConnection.Database.Close();


                itemnumber = 0;
                totalnumber = 0;
                quiznum = 1;
                showquizpanel.Hide();
                viewresultpanel.Show();
                searchtbx.Text = "";
            }
            catch
            {
                Database.DBConnection.Database.Close();
            }
         
      
         
        }
        List<string> questionlist = new List<string>(); // para sa pag display ng question
        List<string> answerlist = new List<string>(); // para sa pag validate kung tama sagot ng naglalaro
        List<string> IDNumlist = new List<string>(); //// para sa pag update
        
        public static int itemnumber = 0; // para pag mag nenext at mag back
        public static int totalnumber = 0; // para malaman kung  ilang items yung quiz
        public static int quiznum = 1;  /// para naman sa chronological order ng question next at back button
        private void ViewQuizListGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnindex = Convert.ToInt32(e.ColumnIndex);

            questionlist.Clear();
            answerlist.Clear();
           
            try
            {
             
                int rowindex = Convert.ToInt32(e.RowIndex);
                string QuizName = ViewQuizListGridview.Rows[rowindex].Cells[2].Value.ToString();
                if (columnindex == 0) // para sa delete
                {
                    
                    DialogResult yesno = MetroFramework.MetroMessageBox.Show(this, "\nAre you sure you want to delete?\nQuiz name " + QuizName, "Delete Command", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (yesno == DialogResult.Yes)
                    {

                        Database.DBConnection.Database.Open();
                        Database.DBConnection.SetCommand("Delete From CreateQuiz_Table where IDQuizName = '" + QuizName + "' AND IDUsername ='" + Login_application.username + "'");
                        OleDbDataReader deletereader = Database.DBConnection.Command.ExecuteReader();
                        Database.DBConnection.Database.Close();
                        MetroFramework.MetroMessageBox.Show(this, "\n\n" + QuizName + " has been delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        refresh();
                    }
                }
                else if (columnindex == 1) // para sa view ng quiz
                {
                    Database.DBConnection.Database.Open();
                    Database.DBConnection.SetCommand("Select * from CreateQuiz_Table where IDQuizName = '" + QuizName + "' AND IDUsername ='" + Login_application.username + "' ORDER By IDNumber asc");
                    OleDbDataReader selectreader = Database.DBConnection.Command.ExecuteReader();
                    while (selectreader.Read())
                    {

                        /////add na yung mga question and correct answer sa ginawa nating list
                        questionlist.Add(selectreader["IDQuestion"].ToString());
                        answerlist.Add(selectreader["IDAnswer"].ToString());
                        IDNumlist.Add(selectreader["IDNum"].ToString());
                        totalnumber++; // para ito ang gagamitin para pag nag next hindi sumobra
                    }
                    Database.DBConnection.Database.Close();


                    numlbl.Text = quiznum.ToString();
                    questiontbx.Text = questionlist.ElementAt(itemnumber);
                    answertbx.Text = answerlist.ElementAt(itemnumber);
                    IDNumlbl.Text = IDNumlist.ElementAt(itemnumber);
                    viewresultpanel.Hide();
                    showquizpanel.Show();
                }
           
            }
            catch
            {
                Database.DBConnection.Database.Close();
            }



        }  
        private void closebtnbtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Database.DBConnection.Database.Open();
                Database.DBConnection.SetCommand("Update CreateQuiz_Table set IDQuestion='" + questiontbx.Text.Replace("'", "`") + "',IDAnswer = '" + answertbx.Text.Replace("'", "`") + "' where IDNum = " + IDNumlbl.Text + "");
                OleDbDataReader updatereader = Database.DBConnection.Command.ExecuteReader();
                Database.DBConnection.Database.Close();

                // insert yung bagong data sa list kasi nag update tapos remove muna yung unang value // para kapag nag next at nag back ibang value na yung lalabas
                questionlist.RemoveAt(itemnumber);
                questionlist.Insert(itemnumber, questiontbx.Text);
                answerlist.RemoveAt(itemnumber);
                answerlist.Insert(itemnumber, answertbx.Text);
                MetroFramework.MetroMessageBox.Show(this, "\n\nUpdate successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
         



        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            if (itemnumber > 0)
            {
                itemnumber--;
                quiznum--;
                numlbl.Text = quiznum.ToString();
                IDNumlbl.Text = IDNumlist.ElementAt(itemnumber);
                questiontbx.Text = questionlist.ElementAt(itemnumber);
                answertbx.Text = answerlist.ElementAt(itemnumber);
            }

        }
        private void nextbtn_Click(object sender, EventArgs e)
        {
            if (itemnumber < totalnumber - 1)
            {
                itemnumber++;
                quiznum++;
                numlbl.Text = quiznum.ToString();
                IDNumlbl.Text = IDNumlist.ElementAt(itemnumber);
                questiontbx.Text = questionlist.ElementAt(itemnumber);
                answertbx.Text = answerlist.ElementAt(itemnumber);
            }

        }

        private void No_Quotation_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void searchtbx_OnValueChanged(object sender, EventArgs e)
        {
           try
           {
               Database.DBConnection.Database.Open();
               Database.DBConnection.SetCommand("Select Distinct(IDQuizName) ,IDTotal , IDHighScore from CreateQuiz_Table where IDUsername ='" + Login_application.username.Replace("'", "`") + "' AND IDQuizName like '%" + searchtbx.Text.ToUpper().Replace("'", "`") + "%' OR IDHighScore like '%" + searchtbx.Text.ToUpper().Replace("'", "`") + "%' OR IDTotal like '%" + searchtbx.Text.ToUpper().Replace("'", "`") + "%'");
               DataTable table = new DataTable();
               OleDbDataAdapter selectadapter = new OleDbDataAdapter(Database.DBConnection.Command);
               selectadapter.Fill(table);
               ViewQuizListGridview.DataSource = table;
               Database.DBConnection.Database.Close();
           }
            catch
           {
               Database.DBConnection.Database.Close();
           }
                
          
         
        } 

    }
}
