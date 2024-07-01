using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public class Repelled:GeneralRow
    {
        public int codeRepelled { get; set; }
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
        public DateTime dateRepelled { get; set; }
        public string reseonRepelled { get; set; }
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
        public DateTime timeToRepelled { get; set; }
        //public int codeStatus { get; set; }
        public Repelled() : base()
        {

        }
        public Repelled(DataRow row) : base(row)
        {

        }
        //מאפיינים למפתחות זרים
        #region
        public Contributor ThisContributor
        {
            get { return MyDB.Contributors.GetList().FirstOrDefault(x => x.IdContributor == this.IdContributor); }
        }
        public Worker ThisWorker
        {
            get { return MyDB.Workers.GetList().FirstOrDefault(x => x.IdWorker == this.idWorker); }
        }
        //public Status ThisStatus
        //{
        //    get { return MyDB.StatusOfContributors.GetList().FirstOrDefault(x => x.codeStatus == this.codeStatus); }
        //}
        #endregion

        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["codeRepelled"] = this.codeRepelled;
            row["idContributor"] = this.idContributor;
            row["dateRepelled"] = this.dateRepelled;
            row["reseonRepelled"] = this.reseonRepelled;
            row["idWorker"] = this.idWorker;
            row["timeToRepelled"] = this.timeToRepelled;
            //row["codeStatus"] = this.codeStatus;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.codeRepelled = Convert.ToInt32(row["codeRepelled"]);
            this.idContributor = Convert.ToInt32(row["idContributor"]);
            this.dateRepelled = (DateTime)row["dateRepelled"];
            this.reseonRepelled = row["reseonRepelled"].ToString();
            this.idWorker = Convert.ToInt32(row["idWorker"]);
            //this.codeStatus = Convert.ToInt32(row["codeStatus"]);
            this.timeToRepelled = (DateTime)row["timeToRepelled"];
        }


        public override string ToString()
        {
            return this.reseonRepelled.ToString();
        }
    }
}
