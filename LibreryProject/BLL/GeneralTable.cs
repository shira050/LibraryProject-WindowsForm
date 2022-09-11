using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreryProject.BLL
{
    public abstract class GeneralTable
    {
        protected static DAL.Dal dal = new DAL.Dal();
        protected DataTable table;
        protected string tableName;
        protected string key;
        protected List<GeneralRow> list;
        public GeneralTable(string tableName, string key)
        {
            DAL.Dal.AddTable(tableName, key);
            this.table = DAL.Dal.GetTable(tableName);
            this.tableName = tableName;
            this.key = key;
            list = new List<GeneralRow>();
        }
        public DataTable GetDataTable()
        {
            return this.table;
        }
        public string GetPrimaryKey()
        {
            return this.key;
        }
        //פרויקט תכנות, כיתה י"ב קובץ 2
        public bool IsEmpty()
        {
            if (table.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }
        public DataRow Find(string fieldname, object value)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row[fieldname].Equals(value))
                {
                    return row;
                }
            }
            return null;
        }

        public DataRow Find(object value)
        {
            return Find(this.key, value);
        }
        public void Save()
        {
            try
            {
                DAL.Dal.Update(table.TableName);
            }
            catch (Exception ex)
            {
            }
        }
        public DataRow GetNewRow()
        {
            return table.NewRow();
        }
        public void AddRow(DataRow dr)
        {
            table.Rows.Add(dr);
            Save();
        }
        public int GetNewKey()
        {
            if (table.Rows.Count == 0)
                return 1;
            return Convert.ToInt32(table.Rows[table.Rows.Count - 1][key]) + 1;
        }
        //  פרויקט תכנות, כיתה י"ב קובץ 2
        public void Add(GeneralRow item)
        {
            list.Add(item);
            item.Drow = table.NewRow();
            item.FillDataRow();
            table.Rows.Add(item.Drow);
            Save();
        }
        public void Update(GeneralRow item)
        {
            item.FillDataRow();
            Save();
        }

        public void Delete(GeneralRow item)
        {
            list.Remove(item);
            item.Drow.Delete();
            {

            }
        }
    }
}
