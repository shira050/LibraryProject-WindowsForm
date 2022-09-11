using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    class BorrowTable_T:GeneralTable
    {
        public BorrowTable_T() : base("BorrowTable", "CodeBorrow")
        {

            foreach (DataRow item in table.Rows)
            {

                list.Add(new BorrowTable(item));
            }
        }

        public List<BorrowTable> GetList()
        {
            return base.list.Cast<BorrowTable>().ToList();
        }
    }
}
