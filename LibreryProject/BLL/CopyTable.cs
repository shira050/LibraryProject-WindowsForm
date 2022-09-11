using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
   public class CopyTable:GeneralRow
    {
        
            private int CodeCopy;

            public int Code_Copy
            {
                get { return CodeCopy; }
                set { CodeCopy = value; }
            }
            private int CodeBook;

            public int Code_Book
            {
                get { return CodeBook; }
                set { CodeBook = value; }
            }
            public bool Isborrow { get; set; }

        public override void FillFields()
        {
            this.CodeCopy = Convert.ToInt32(drow["CodeCopy"]);
            this.CodeBook = Convert.ToInt32(drow["CodeBook"]);
            this.Isborrow = Convert.ToBoolean(drow["Isborrow"]);
            
        }

        public override void FillDataRow()
        {
            drow["CodeCopy"] = this.CodeCopy;
            drow["CodeBook"] = this.CodeBook;
            drow["Isborrow"] = this.Isborrow;
        }
        public CopyTable()
        {

        }
        public CopyTable(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public CopyTable(int id)
        {
            CopyTable_T copy = new CopyTable_T();
            drow = copy.Find(id);
            FillFields();
        }
        public List<BorrowsBooksTable> GetRegions()
        {
            BorrowsBooksTable_T reg = new BorrowsBooksTable_T();
            return reg.GetList().Where(x => x.Code_Copy == this.CodeCopy).ToList();
        }
        public BooksTable GetRegion()
        {
            BooksTable_T reg = new BooksTable_T();
            return reg.GetList().FirstOrDefault(x => x.code_Book == this.CodeBook);
        }

    }
   
}
