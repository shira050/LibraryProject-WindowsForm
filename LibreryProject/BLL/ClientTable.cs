using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
   public class ClientTable:GeneralRow
    {
        private int IdClient;

        public int Id_Client
        {
            get { return IdClient; }
            set {
                                 IdClient = value; }
        }
        private string NameClient;

        public string Name_Client
        {
            get { return NameClient; }
            set {
                NameClient = value; }
        }
        private string mailClient;

        public string MailClient
        {
            get { return mailClient; }
            set {
                if (validates.CheackMail(value) == false)
                    throw new Exception("מייל שגוי");
                mailClient = value; }
        }

        //  public string MailClient { get; set; }
        //  public string TelClient { get; set; }
        private string telClient;

        public string TelClient
        {
            get { return telClient; }
            set
            {
                if (validates.IsTelephone(value) == false|| validates.IsCellPhone(value) == false)
                    throw new Exception("טלפון שגוי");
                telClient = value;
            }
        }
        public override void FillFields()
        {
            this.IdClient = Convert.ToInt32(drow["IdClient"]);
            this.NameClient = drow["NameClient"].ToString();
            this.MailClient = drow["MailClient"].ToString();
            this.TelClient = drow["TelClient"].ToString();

        }

        public override void FillDataRow()
        {
            drow["IdClient"] = this.IdClient;
            drow["NameClient"] = this.NameClient;
            drow["MailClient"] = this.MailClient;
            drow["TelClient"] = this.TelClient;
        }
        public ClientTable()
        {

        }
        public ClientTable(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClientTable(int id)
        {
            ClientTable_T client = new ClientTable_T();
            drow = client.Find(id);
            FillFields();
        }
        public List<BorrowTable> GetBorrow()
        {
            BorrowTable_T reg = new BorrowTable_T();
            return reg.GetList().Where(x => x.Code_Client == this.Id_Client).ToList();
        }
        public List<WaitingTable> GetWaiting()
        {
            WaitingTable_T reg = new WaitingTable_T();
            return reg.GetList().Where(x => x.Code_Client == this.IdClient).ToList();
        }
}
}
