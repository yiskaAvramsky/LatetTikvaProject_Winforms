using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace LatetTikvaProject.DAL
{
    public class Connect
    {

        private DataSet dataset;
        private OleDbConnection con;
        private OleDbDataAdapter adapter;

        public Connect()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            int x = path.IndexOf("\\bin");
            path = path.Substring(0, x) + "\\Dal\\LatetTikva.accdb";

            con = new OleDbConnection(@"Provider= Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True");
            dataset = new DataSet();

        }

        private void AddTable(string tableName)
        {
            adapter = new OleDbDataAdapter("select * from " + tableName, con);
            adapter.Fill(dataset, tableName);
        }

        public DataTable GetTable(string tableName)
        {
            if (!(dataset.Tables.Contains(tableName)))
            {
                AddTable(tableName);
            }
            return dataset.Tables[tableName];
        }

        public void UpdateTable(string tableName)
        {
            adapter = new OleDbDataAdapter("select * from " + tableName, con);
            OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = oleDbCommandBuilder.GetInsertCommand();
            adapter.DeleteCommand = oleDbCommandBuilder.GetDeleteCommand();
            adapter.UpdateCommand = oleDbCommandBuilder.GetUpdateCommand();
            adapter.Update(dataset, tableName);
        }
    }
 } 
