using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
  public  class EmploiesTable:GeneralRow
    {
        private int IdEmploy;

        public int Id_Employ
        {
            get { return IdEmploy; }
            set { IdEmploy = value; }
        }
        private string NameEmploy;

        public string Name_Employ
        {
            get { return NameEmploy; }
            set {
                if (value == "")
                    throw new Exception("שדה חובה");
                NameEmploy = value; }
        }
        private string MailEmploy;

        public string Mail_Employ
        {
            get { return MailEmploy; }
            set
            {
                if (validates.CheackMail(value) == false)
                    throw new Exception("מייל שגוי");
                MailEmploy = value; }
        }

        private string TelEmploy;

        public string Tel_Employ
        {
            get { return TelEmploy; }
            set
            {
                if (validates.IsTelephone(value) == false|| validates.IsCellPhone(value) == false)
                    throw new Exception("טלפון שגוי");
                TelEmploy = value; }
        }

        public override void FillFields()
        {
            this.IdEmploy = Convert.ToInt32(drow["IdEmploy"]);
            this.NameEmploy = drow["NameEmploy"].ToString();
            this.MailEmploy = drow["MailEmploy"].ToString();
            this.TelEmploy = drow["TelEmploy"].ToString();
        }

        public override void FillDataRow()
        {
            drow["IdEmploy"] = this.IdEmploy;
            drow["NameEmploy"] = this.NameEmploy;
            drow["MailEmploy"] = this.MailEmploy;
            drow["TelEmploy"] = this.TelEmploy;
        }
        public EmploiesTable()
        {

        }
        public EmploiesTable(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public EmploiesTable(int id)
        {
            EmploiesTable_T employe = new EmploiesTable_T();
            drow = employe.Find(id);
            FillFields();
        }

        public List<BorrowTable> GetBorrow()
        {
            BorrowTable_T reg = new BorrowTable_T();
            return reg.GetList().Where(x => x.code_Employ == this.IdEmploy).ToList();
        }
    }
}
