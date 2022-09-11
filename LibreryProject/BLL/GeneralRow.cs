using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
   public abstract class GeneralRow
    {

        protected DataRow drow;
        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        public abstract void FillFields();
        public abstract void FillDataRow();
    }
}
