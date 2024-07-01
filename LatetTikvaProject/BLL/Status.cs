using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public class Status:GeneralRow
    {
        public int codeStatus { get; set; }
        public string status { get; set; }
        public Status() : base()
        {

        }
        public Status(DataRow row) : base(row)
        {

        }
        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["codeStatus"] = this.codeStatus;
            row["status"] = this.status;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.codeStatus = Convert.ToInt32(row["codeStatus"]);
            this.status =  row["status"].ToString();
        }
    }
}
