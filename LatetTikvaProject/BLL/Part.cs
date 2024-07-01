using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public class Part:GeneralRow
    {
        public int codePart { get; set; }
        public string namePart { get; set; }
        public Part() : base()
        {

        }
        public Part(DataRow row) : base(row)
        {

        }
        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["codePart"] = this.codePart;
            row["namePart"] = this.namePart;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.codePart = Convert.ToInt32(row["codePart"]);
            this.namePart = row["namePart"].ToString();
        }

        public override string ToString()
        {
            return this.namePart.ToString();
        }
    }
}
