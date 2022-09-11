using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    class WaitingTable_T:GeneralTable
    {

        public WaitingTable_T() : base("WaitingTable", "codeWaiting")
        {

            foreach (DataRow item in table.Rows)
            {

                list.Add(new WaitingTable(item));
            }
        }

        public List<WaitingTable> GetList()
        {
            return base.list.Cast<WaitingTable>().ToList();
        }
    }
}
