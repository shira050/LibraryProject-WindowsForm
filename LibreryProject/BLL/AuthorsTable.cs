using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    public class AuthorsTable : GeneralRow
    {
        private int CodeAuthor;

        public int Code_Author
        {
            get { return CodeAuthor; }
            set {
                    CodeAuthor = value; }
        }


        private string NameAuthor;

        public string Name_Author
        {
            get { return NameAuthor; }

            set {
                if (value == "")
                    throw new Exception("שדה חובה");
                NameAuthor = value; }
        }

        public override void FillFields()
        {
            this.CodeAuthor = Convert.ToInt32(drow["CodeAuthor"]);
            this.NameAuthor = drow["NameAuthor"].ToString();
        }

        public override void FillDataRow()
        {
            drow["CodeAuthor"] = this.CodeAuthor;
            drow["NameAuthor"] = this.NameAuthor;
        }

        public AuthorsTable()
        {

        }
        public AuthorsTable(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public AuthorsTable(int id)
        {
            AuthorsTable_T author = new AuthorsTable_T();
            drow = author.Find(id);
            FillFields();
        }
        public List<BooksTable> GetCodeAuthor()
        {
            BooksTable_T reg = new BooksTable_T();
            return reg.GetList().Where(x => x.Code_Author == this.CodeAuthor).ToList();
        }
        public override string ToString()
        {
            return NameAuthor;
        }
    }
    }
