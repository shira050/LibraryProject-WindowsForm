using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    class ClientTable_T:GeneralTable
    {
        public ClientTable_T() : base("ClientTable", "IdClient")
        {

            foreach (DataRow item in table.Rows)
            {

                list.Add(new ClientTable(item));
            }
        }

        public List<ClientTable> GetList()
        {
            return base.list.Cast<ClientTable>().ToList();
        }
    }
}
