using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Quiz_Maker.Database
{
    class DBConnection
    {

        
        public static OleDbConnection Database = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Environment.CurrentDirectory+"\\QuizMakerDB.accdb");
        public static OleDbCommand Command = new OleDbCommand("", Database);
        public static void SetCommand(string setcommand)
        {
            Command = new OleDbCommand(setcommand, Database);
        }
    }
}
