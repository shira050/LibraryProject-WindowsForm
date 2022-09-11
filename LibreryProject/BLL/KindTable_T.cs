using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    class KindTable_T:GeneralTable
    {
        public KindTable_T() : base("KindTable", "CodeKind")
        {

            foreach (DataRow item in table.Rows)
            {

                list.Add(new KindTable(item));
            }
        }

        public List<KindTable> GetList()
        {
            return base.list.Cast<KindTable>().ToList();
        }
    }
}
