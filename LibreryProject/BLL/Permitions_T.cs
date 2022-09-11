using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
  public class Permitions_T: GeneralTable
    {
        public Permitions_T() : base("Permitions", "Code")
        {

            foreach (DataRow item in table.Rows)
            {

                list.Add(new Permitions(item));
            }
        }

        public List<Permitions> GetList()
        {
            return base.list.Cast<Permitions>().ToList();
        }
    }
}
