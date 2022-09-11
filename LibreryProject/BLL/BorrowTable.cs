using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
   public class BorrowTable:GeneralRow
    {
        private int CodeBorrow;

        public int Code_Borrow
        {
            get { return CodeBorrow; }
            set { CodeBorrow = value; }
        }


        private int CodeClient;

        public int Code_Client
        {
            get { return CodeClient; }
            set {  CodeClient = value; }
        }

        private int codeEmploy;

        public int code_Employ
        {
            get { return codeEmploy; }
            set {codeEmploy = value; }
        }

        private DateTime DateBorrow;

        public DateTime Date_Borrow
        {
            get { return DateBorrow; }
         set
            {
                if (value < DateTime.Today)
                    throw new Exception("התאריך לא תקין");
                DateBorrow = value; }
        }

        public override void FillFields()
        {
            this.CodeBorrow = Convert.ToInt32(drow["CodeBorrow"]);
            this.CodeClient = Convert.ToInt32(drow["CodeClient"]);
            this.codeEmploy = Convert.ToInt32(drow["codeEmploy"]);
            this.DateBorrow = Convert.ToDateTime(drow["DateBorrow"]);

        }

        public override void FillDataRow()
        {
            drow["CodeBorrow"] = this.CodeBorrow;
            drow["CodeClient"] = this.CodeClient;
            drow["codeEmploy"] = this.codeEmploy;
            drow["DateBorrow"] = this.DateBorrow;
        }
        public BorrowTable()
        {

        }
        public BorrowTable(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public BorrowTable(int id)
        {
            BorrowTable_T borrow = new BorrowTable_T();
            drow = borrow.Find(id);
            FillFields();
        }
        public List<BorrowsBooksTable> GetBorrowsBooks()
        {
            BorrowsBooksTable_T reg = new BorrowsBooksTable_T();
            return reg.GetList().Where(x => x.Code_Borrow == this.CodeBorrow).ToList();
        }
        public ClientTable GetClient()
        {
            ClientTable_T reg = new ClientTable_T();
            return reg.GetList().FirstOrDefault(x => x.Id_Client == this.CodeClient);
        }
        public EmploiesTable GetEmploies()
        {
            EmploiesTable_T reg = new EmploiesTable_T();
            return reg.GetList().FirstOrDefault(x => x.Id_Employ == this.codeEmploy);
        }
    }
}
