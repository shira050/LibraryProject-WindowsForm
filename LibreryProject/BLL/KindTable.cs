using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreryProject.BLL
{
    public class KindTable : GeneralRow
    {
        private int CodeKind;

        public int Code_Kind
        {
            get { return CodeKind; }
            set { CodeKind = value; }
        }
        private string Namekind;

        public string Name_kind
        {
            get { return Namekind; }
            set {
                if (value == "")
                    throw new Exception("שדה חובה");
                Namekind = value; }
        }

        public override void FillFields()
        {
            this.CodeKind = Convert.ToInt32(drow["CodeKind"]);
            this.Namekind = drow["Namekind"].ToString();
        }

        public override void FillDataRow()
        {
            drow["CodeKind"] = this.CodeKind;
            drow["Namekind"] = this.Namekind;
        }
        public KindTable()
        {

        }
        public KindTable(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public KindTable(int id)
        {
            KindTable_T kind = new KindTable_T();
            drow = kind.Find(id);
            FillFields();
        }

        public List<BooksTable> GetBooks()
        {
            BooksTable_T reg = new BooksTable_T();
 return reg.GetList().Where(x => x.Code_Kind== this.CodeKind).ToList();
}
        public override string ToString()
        {
            return Namekind;
        }
    }
}
