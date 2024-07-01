using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class Talk : GeneralRow
    {
        public int codeTalk { get; set; }
        public DateTime dateInPastOfTalk { get; set; }
        public DateTime timeInPastOfTalk { get; set; }
        private int idContributor;
        public int IdContributor
        {
            get { return idContributor; }
            set
            {
                if (Validation.CheckId(value.ToString()))
                    idContributor = value;
                else
                    throw new Exception("תעודת הזהות אינה תקינה");
            }
        }
        private int idWorker;
        public int IdWorker
        {
            get { return idWorker; }
            set
            {
                if (Validation.CheckId(value.ToString()))
                    idWorker = value;
                else
                    throw new Exception("תעודת הזהות אינה תקינה");
            }
        }
        public int codeStatus { get; set; }
        public string note { get; set; }
        public Talk() : base()
        {
                
        }
        public Talk(DataRow row) : base(row)
        {

        }
        //מאפיינים למפתחות זרים
        #region
        public Worker ThisWorker
        {
            get { return MyDB.Workers.GetList().FirstOrDefault(x => x.IdWorker == this.idWorker); }
        }
         public Status ThisStatus
        {
            get { return MyDB.StatusOfContributors.GetList().FirstOrDefault(x => x.codeStatus == this.codeStatus); }
        }
        public Contributor ThisContributor
        {
            get { return MyDB.Contributors.GetList().FirstOrDefault(x => x.IdContributor == this.idContributor); }
        }
        #endregion

        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["codeTalk"] = this.codeTalk;
            row["dateInPastOfTalk"] = this.dateInPastOfTalk;
            row["timeInPastOfTalk"] = this.timeInPastOfTalk;
            row["idWorker"] = this.idWorker;
            row["codeStatus"] = this.codeStatus;
            row["noteT"] = this.note;
            row["idContributor"] = this.idContributor;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.codeTalk = Convert.ToInt32(row["codeTalk"]);
            this.dateInPastOfTalk = (DateTime)row["dateInPastOfTalk"];
            this.timeInPastOfTalk = (DateTime)row["timeInPastOfTalk"];
            this.idWorker = Convert.ToInt32(row["idWorker"]);
            this.codeStatus = Convert.ToInt32(row["codeStatus"]);
            this.note = row["noteT"].ToString();
            this.idContributor = Convert.ToInt32(row["idContributor"]);
        }
        public override string ToString()
        {
            return this.note.ToString();
        }
    }
}
