using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
   public class BorrowsBooksTable:GeneralRow
    {
        private int CodeBookinborrow;

        public int Code_Bookinborrow
        {
            get { return CodeBookinborrow; }
            set { CodeBookinborrow = value; }
        }

        private int CodeBorrow;

        public int Code_Borrow
        {
            get { return CodeBorrow; }
            set { CodeBorrow = value; }
        }

        private int CodeCopy;

        public int Code_Copy
        {
            get { return CodeCopy; }
            set { CodeCopy = value; }
        }

        public override void FillFields()
        {
            this.CodeBookinborrow = Convert.ToInt32(drow["CodeBookinborrow"]);
            this.CodeBorrow = Convert.ToInt32(drow["CodeBorrow"]);
            this.CodeCopy = Convert.ToInt32(drow["CodeCopy"]);
        }

        public override void FillDataRow()
        {
            drow["CodeBookinborrow"] = this.CodeBookinborrow;
            drow["CodeBorrow"] = this.CodeBorrow;
            drow["CodeCopy"] = this.CodeCopy;
        }
        public BorrowsBooksTable()
        {

        }
        public BorrowsBooksTable(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public BorrowsBooksTable(int id)
        {
            BorrowsBooksTable_T borrowBook = new BorrowsBooksTable_T();
            drow = borrowBook.Find(id);
            FillFields();
        }

        public BorrowTable GetBorrow()
        {
            BorrowTable_T reg = new BorrowTable_T();
            return reg.GetList().FirstOrDefault(x => x.Code_Borrow == this.Code_Borrow);
        }
        public CopyTable GetCopy()
        {
            CopyTable_T reg = new CopyTable_T();
            return reg.GetList().FirstOrDefault(x => x.Code_Copy == this.Code_Copy);
        }
      

    }
}
