using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreryProject.DAL
{
    public class Dal
    {
        private static OleDbConnection con;
        private static DataSet ds;
       
        static Dal()
        {
            string path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + @"\Library.mdb";
            con = new OleDbConnection(path);
            ds = new DataSet();
        }
       
        public static void AddTable(string tableName, string Keyname)
        {
            if (!ds.Tables.Contains(tableName))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " +
               tableName + " order by " + Keyname, con);
                adapter.Fill(ds, tableName);
            }
        }

        public static DataTable GetTable(string tableName)
        {
            if (ds.Tables.Contains(tableName))
                return ds.Tables[tableName];
            else
                return null;
        }
        //פעולה שמביאה לנו רק חלק מהטבלה שאנחנו רוצים//
        public static DataTable GetDisplayTable(string sqlstring)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, con);
            adapter.Fill(dt);
            return dt;
        }
        // פעולה שמעדכנת את הטבלה הרצויה שעשינו בה שינויים בתוך האקסס//
        public static void Update(string tableName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " +
           tableName, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.Update(ds, tableName);
        }

    
    }
}
