using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatetTikvaProject.BLL
{
    public class ListToTalk : GeneralRow
    {
        public int codeListToTalk { get; set; }
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
        public int codeStatus { get; set; }

        public ListToTalk() : base()
        {

        }
        public ListToTalk(DataRow row) : base(row)
        {

        }
        //מאפיינים למפתחות זרים
        #region
        public Worker ThisWorker
        {
            get { return MyDB.Workers.GetList().FirstOrDefault(x => x.IdWorker == this.idWorker); }
        }
        public Contributor ThisContributor
        {
            get { return MyDB.Contributors.GetList().FirstOrDefault(x => x.IdContributor == this.IdContributor); }
        }
        public Status ThisStatus
        {
            get { return MyDB.StatusOfContributors.GetList().FirstOrDefault(x => x.codeStatus == this.codeStatus); }
        }
        #endregion

        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["codeListToTalk"] = this.codeListToTalk;
            row["idWorker"] = this.idWorker;
            row["idContributor"] = this.idContributor;
            row["codeStatus"] = this.codeStatus;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.codeListToTalk = Convert.ToInt32(row["codeListToTalk"]);
            this.idWorker = Convert.ToInt32(row["idWorker"]);
            this.idContributor = Convert.ToInt32(row["idContributor"]);
            this.codeStatus = Convert.ToInt32(row["codeStatus"]);
        }
    }
}
