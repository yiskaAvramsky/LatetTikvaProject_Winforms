using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public class Town:GeneralRow
    {
        public int codeTown { get; set; }
        public string nameOfTown { get; set; }
        public Town() : base()
        {

        }
        public Town(DataRow row) : base(row)
        {

        }
        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["codeTown"] = this.codeTown;
            row["nameOfTown"] = this.nameOfTown;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.codeTown = Convert.ToInt32(row["codeTown"]);
            this.nameOfTown = row["nameOfTown"].ToString();
        }

        public override string ToString()
        {
            return this.nameOfTown.ToString();
        }
    }
}
