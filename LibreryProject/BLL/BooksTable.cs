using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    public class BooksTable : GeneralRow
    {
        private int codeBook;

        public int code_Book
        {
            get { return codeBook; }
            set { if (value > 0) codeBook = value; }
        }

        private int CodeAuthor;

        public int Code_Author
        {
            get { return CodeAuthor; }
            set {  CodeAuthor = value; }
        }

        private int CodeKind;

        public int Code_Kind
        {
            get { return CodeKind; }
            set { CodeKind = value; }
        }

        private string NameBook;

        public string Name_Book
        {
            get { return NameBook; }
            set {
                if (value == "")
                    throw new Exception("שדה חובה");
                NameBook = value; }
        }


        //public string MyProperty
        //{
        //    get { return NameBook; }
        //    set { if (NameBook != null) NameBook = value; }
        //}

        public override void FillFields()
        {

            this.codeBook = Convert.ToInt32(drow["codeBook"]);
            this.CodeAuthor = Convert.ToInt32(drow["CodeAuthor"]);
            this.CodeKind = Convert.ToInt32(drow["CodeKind"]);
            this.NameBook = drow["NameBook"].ToString();

        }

        public override void FillDataRow()
        {
            drow["codeBook"] = this.codeBook;
            drow["CodeAuthor"] = this.CodeAuthor;
            drow["CodeKind"] = this.CodeKind;
            drow["NameBook"] = this.NameBook;
        }
        public BooksTable()
        {

        }
        public BooksTable(DataRow dr)
        {
            drow = dr;
            FillFields();
        }

        public BooksTable(int id)
        {
            BooksTable_T book = new BooksTable_T();
            drow = book.Find(id);
            FillFields();
        }
        public List<CopyTable> GetCodeBook()
        {
            CopyTable_T reg = new CopyTable_T();
 return reg.GetList().Where(x => x.Code_Book == this.codeBook).ToList();
}


        public AuthorsTable GetAuthor()
        {
            AuthorsTable_T reg = new AuthorsTable_T();
            return reg.GetList().FirstOrDefault(x => x.Code_Author == this.CodeAuthor);
        }
        public KindTable GetKind()
        {
            KindTable_T reg = new KindTable_T();
            return reg.GetList().FirstOrDefault(x => x.Code_Kind == this.CodeKind);
        }

    }
}
