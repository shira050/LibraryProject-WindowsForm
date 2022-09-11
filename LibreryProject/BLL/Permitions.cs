using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
  public  class Permitions: GeneralRow
    {
        public int Code { get; set; }

        private string userName;

        public string user_Name
        {
            get { return userName; }
            set {
                if (value == "")
                    throw new Exception("שדה חובה");
                userName = value;
            }

        }
        private string PasswordClient;

        public string Password_Client
        {
            get { return PasswordClient; }
            set { PasswordClient = value; }
        }

        private string KindClient;

        public string Kind_Client
        {
            get { return KindClient; }
            set {
                if (value != "מנהל"&&value!="משתמש")
                    throw new Exception("ניתן להזין משתמש או מנהל בלבד"); 
                KindClient = value; }
        }


        public override void FillFields()
        {
            this.Code = Convert.ToInt32(drow["Code"]);
            this.userName = drow["userName"].ToString();
            this.PasswordClient = drow["PasswordClient"].ToString();
            this.KindClient = drow["KindClient"].ToString();
        }

        public override void FillDataRow()
        {
            drow["Code"] = this.Code;
            drow["userName"] = this.userName;
            drow["PasswordClient"] = this.PasswordClient;
            drow["KindClient"] = this.KindClient;
        }

        public Permitions()
        {

        }
        public Permitions(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public Permitions(int id)
        {
            Permitions_T per = new Permitions_T();
            drow = per.Find(id);
            FillFields();
        }

        //????????????????????
        //צריך קשרי גומלין??????
        //public List<BooksTable> GetCodeAuthor()
        //{
        //    BooksTable_T reg = new BooksTable_T();
        //    return reg.GetList().Where(x => x.Code_Author == this.CodeAuthor).ToList();
        //}
    }



}
