using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    class EmploiesTable_T:GeneralTable
    {
        public EmploiesTable_T() : base("EmploiesTable", "IdEmploy")
        {

            foreach (DataRow item in table.Rows)
            {

                list.Add(new EmploiesTable(item));
            }
        }

        public List<EmploiesTable> GetList()
        {
            return base.list.Cast<EmploiesTable>().ToList();
        }
    }
}
