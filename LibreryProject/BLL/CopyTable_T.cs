using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    class CopyTable_T:GeneralTable
    {
        public CopyTable_T() : base("CopyTable", "CodeCopy")
        {

            foreach (DataRow item in table.Rows)
            {

                list.Add(new CopyTable(item));
            }
        }

        public List<CopyTable> GetList()
        {
            return base.list.Cast<CopyTable>().ToList();
        }
    }
}
