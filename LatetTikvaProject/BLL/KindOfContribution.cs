using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public class KindOfContribution:GeneralRow
    {
        public int codeKindOfContribution { get; set; }
        public string nameKind { get; set; }
        public KindOfContribution() : base()
        {

        }
        public KindOfContribution(DataRow row) : base(row)
        {

        }
        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["codeKindOfContribution"] = this.codeKindOfContribution;
            row["nameKind"] = this.nameKind;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.codeKindOfContribution = Convert.ToInt32(row["codeKindOfContribution"]);
            this.nameKind = row["nameKind"].ToString();
        }

        public override string ToString()
        {
            return this.nameKind.ToString();            
        }
    }
}
