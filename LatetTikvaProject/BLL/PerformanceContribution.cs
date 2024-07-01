using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public class PerformanceContribution:GeneralRow
    {
        public int codePerformanceContribution { get; set; }
        public int sumOfContribution { get; set; }
        public string wayPaying { get; set; }
        public int numOfPaying { get; set; }
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
        public DateTime dateOfContribution { get; set; }
        public int codeKindOfContribution { get; set; }
        //public string creditCard { get; set; }
        //public DateTime validity { get; set; }
        public PerformanceContribution() : base()
        {

        }
        public PerformanceContribution(DataRow row) : base(row)
        {

        }
        //מאפיינים למפתחות זרים
        #region
        public Contributor ThisContributor
        {
            get { return MyDB.Contributors.GetList().FirstOrDefault(x => x.IdContributor == this.IdContributor); }
        }
        public KindOfContribution ThisKindOfContribution
        {
            get { return MyDB.KindOfContributions.GetList().FirstOrDefault(x => x.codeKindOfContribution == this.codeKindOfContribution); }
        }
        #endregion

        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["codePerformanceContribution"] = this.codePerformanceContribution;
            row["sumOfContribution"] = this.sumOfContribution;
            row["wayPaying"] = this.wayPaying;
            row["numOfPaying"] = this.numOfPaying;
            row["idContributor"] = this.idContributor;
            row["dateOfContribution"] = this.dateOfContribution;
            row["codeKindOfContribution"] = this.codeKindOfContribution;
            //row["creditCard"] = this.creditCard;
            //row["validity"] = this.validity;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.codePerformanceContribution = Convert.ToInt32(row["codePerformanceContribution"]);
            this.sumOfContribution = Convert.ToInt32(row["sumOfContribution"]);
            this.wayPaying = row["wayPaying"].ToString();
            this.numOfPaying = Convert.ToInt32(row["numOfPaying"]);
            this.idContributor = Convert.ToInt32(row["idContributor"]);
            this.dateOfContribution = (DateTime)row["dateOfContribution"];
            this.codeKindOfContribution = Convert.ToInt32(row["codeKindOfContribution"]);
            //this.creditCard = row["creditCard"].ToString();
            //this.validity = Convert.ToDateTime(row["validity"]);
        }


        public override string ToString()
        {
            return this.wayPaying.ToString();
        }
    }
}
