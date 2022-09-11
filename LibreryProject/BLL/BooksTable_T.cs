using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    class BooksTable_T:GeneralTable
    {
        public BooksTable_T() : base("BooksTable", "codeBook")
        {

            foreach (DataRow item in table.Rows)
            {

                list.Add(new BooksTable(item));
            }
        }

        public List<BooksTable> GetList()
        {
            return base.list.Cast<BooksTable>().ToList();
        }
    }
}
