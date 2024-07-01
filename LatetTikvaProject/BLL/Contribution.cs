using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public class Contribution : GeneralRow
    {
        public int codeContribution { get; set; }
        private int idWorker;
        public int IdWorker
        {
            get { return idWorker; }
            set {
                if (Validation.CheckId(value.ToString()))
                    idWorker = value;
                else
                    throw new Exception("תעודת הזהות אינה תקינה ");
            }

        }
        public int bonus { get; set; }
        public int codePerformanceContribution { get; set; }
        public Contribution() : base()
        {

        }
        public Contribution(DataRow row) : base(row)
        {

        }
        //מאפיינים למפתחות זרים
        #region
        public Worker ThisWorker
        {
            get { return MyDB.Workers.GetList().FirstOrDefault(x => x.IdWorker == this.idWorker); }
        }
        public PerformanceContribution ThisPerformanceContribution
        {
            get { return MyDB.PerformanceContributions.GetList().FirstOrDefault(x => x.codePerformanceContribution == this.codePerformanceContribution); }
        }
        #endregion

        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["codeContribution"] = this.codeContribution;
            row["idWorker"] = this.idWorker;
            row["bonus"] = this.bonus;
            row["codePerformanceContribution"] = this.codePerformanceContribution;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.codeContribution = Convert.ToInt32(row["codeContribution"]);
            this.idWorker = Convert.ToInt32(row["idWorker"]);
            this.bonus = Convert.ToInt32(row["bonus"]);
            this.codePerformanceContribution = Convert.ToInt32(row["codePerformanceContribution"]);
        }
    }
}
