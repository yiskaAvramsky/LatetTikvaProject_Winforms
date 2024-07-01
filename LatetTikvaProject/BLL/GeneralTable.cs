using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatetTikvaProject.DAL;

namespace LatetTikvaProject.BLL
{
    public abstract class GeneralTable
    {
        //מופע סטטי של מחלקת קונקט-מופע יחידי עבור כל מחלקות הרבים
        public static Connect connect = new Connect();
        protected DataTable table;
        protected List<GeneralRow> list;

        //פעולה בונה, מקבלת שם של טבלה, מכניסה למופע של הטבלה שחזרה מהחיבור לאקסס-ממחלקת הקונקט
        public GeneralTable(string NameTable)
        {
            table = connect.GetTable(NameTable);
            list = new List<GeneralRow>();
        }
        public void AddItem(GeneralRow item)
        {
            //מןסיף אובקייקט חדש לרשימה
            list.Add(item);
            //מאתחל את השורה להיות מסוג הטבלה אליה אנחנו נרצה להוסיף נתונים
            item.row = table.NewRow();
            //ממלאה את השורה החדשה באקסס על פי הנתונים שהמשתמש הזין
            item.FillDataRow();
            //מוסיף שורה חדשה בטבלה-את השורה שבה טיפלנו עד כה
            table.Rows.Add(item.row);
        }
        public void UpdateItem(GeneralRow item)
        {
            item.FillDataRow();
        }
        public void DeleteItem(GeneralRow item)
        {
            item.row.Delete();
            list.Remove(item);
        }
        public void SaveChanges()
        {
            connect.UpdateTable(this.table.TableName);
        }
    }
}
