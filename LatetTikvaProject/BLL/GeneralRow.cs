using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public abstract class GeneralRow
    {
        public DataRow row;
        public GeneralRow()
        {
                
        }
        public GeneralRow(DataRow row)
        {
            this.row = row;
            FillFields();
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public abstract void FillFields();

        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public abstract void FillDataRow();
    }
}
