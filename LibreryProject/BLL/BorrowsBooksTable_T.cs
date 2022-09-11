using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    class BorrowsBooksTable_T:GeneralTable
    {
        public BorrowsBooksTable_T() : base("BorrowsBooksTable", "CodeBookinborrow")
        {

            foreach (DataRow item in table.Rows)
            {

                list.Add(new BorrowsBooksTable(item));
            }
        }

        public List<BorrowsBooksTable> GetList()
        {
            return base.list.Cast<BorrowsBooksTable>().ToList();
        }
    }
}
