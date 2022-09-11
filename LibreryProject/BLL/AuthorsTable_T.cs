using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    public class AuthorsTable_T:GeneralTable
    {
        public AuthorsTable_T() : base("AuthorsTable", "CodeAuthor")
        {
           
            foreach (DataRow item in table.Rows)
            {
               
                list.Add(new AuthorsTable(item));
            }
        }
       
        public List<AuthorsTable> GetList()
        {
            return base.list.Cast<AuthorsTable>().ToList();
        }

       
    }
}
