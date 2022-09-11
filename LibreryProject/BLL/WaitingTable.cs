using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
 public   class WaitingTable:GeneralRow
    {
        private int codeWaiting;

        public int code_Waiting
        {
            get { return codeWaiting; }
            set { codeWaiting = value; }
        }

        private int CodeClient;

        public int Code_Client
        {
            get { return CodeClient; }
            set {CodeClient = value; }
        }
        private int CodeBook;

        public int Code_Book
        {
            get { return CodeBook; }
            set {CodeBook = value; }
        }
        public bool StatusWaiting { get; set; }

        public override void FillFields()
        {
            this.codeWaiting = Convert.ToInt32(drow["codeWaiting"]);
            this.CodeClient = Convert.ToInt32(drow["CodeClient"]);
            this.CodeBook = Convert.ToInt32(drow["CodeBook"]);
            this.StatusWaiting = Convert.ToBoolean(drow["StatusWaiting"]);
        }

        public override void FillDataRow()
        {
            drow["codeWaiting"] = this.codeWaiting;
            drow["CodeClient"] = this.CodeClient;
            drow["CodeBook"] = this.CodeBook;
            drow["StatusWaiting"] = this.StatusWaiting;
        }
        public WaitingTable()
        {

        }
        public WaitingTable(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public WaitingTable(int id)
        {
            WaitingTable_T wait = new WaitingTable_T();
            drow = wait.Find(id);
            FillFields();
        }
        public ClientTable GetRegion()
        {
            ClientTable_T reg = new ClientTable_T();
            return reg.GetList().FirstOrDefault(x => x.Id_Client == this.CodeClient);
        }

    }
}
