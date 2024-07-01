using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public class Contributor : GeneralRow
    {
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
        public string fNameOfContributor { get; set; }
        public string lNameOfContributor { get; set; }
        public string address { get; set; }
        public int numOfHome { get; set; }
        public int codeTown { get; set; }
        private string tellephon { get; set; }
        public string Tellephon
        {
            get { return tellephon; }
            set
            {
                if (Validation.IsTell(value) || Validation.IsPelephone(value))
                    tellephon = value;
                else
                {
                    throw new Exception("המספר אינו תקין");
                }
            }
        }
        private string anotherTell;
        public string AnotherTell
        {
            get { return anotherTell; }
            set
            {
                if (Validation.IsTell(value) || Validation.IsPelephone(value))
                    anotherTell = value;
                else
                {
                    throw new Exception("המספר אינו תקין");
                }
            }
        }
        private string mail;
        public string Mail
        {
            get { return mail; }
            set
            {
                if (Validation.IsMail(value.ToString()))
                    mail = value;
                else
                {
                    throw new Exception("המייל אינו תקין");
                }
            }
        }
        public int codeStatus { get; set; }
        public DateTime dateOfLastContribution { get; set; }
        public int sumOfLastContribution;
        public int GetSumOfLastContribution()
        {
            return this.sumOfLastContribution;
        }
        public void SetSumOfLastContribution(int sum)
        {
            this.sumOfLastContribution = sum;
        }
        public int idWorker { get; set; }
        public string noteOnContribution { get; set; }
        public Contributor() : base()
        {

        }
        public Contributor(DataRow row) : base(row)
        {

        }
        //מאפיינים למפתחות זרים
        #region
        public Town ThisCity
        {
            get { return MyDB.Towns.GetList().FirstOrDefault(x => x.codeTown == this.codeTown); }
        }
        public Status ThisStatus
        {
            get { return MyDB.StatusOfContributors.GetList().FirstOrDefault(x => x.codeStatus == this.codeStatus); }
        }
        public Worker ThisWorker
        {
            get { return MyDB.Workers.GetList().FirstOrDefault(x => x.IdWorker == this.idWorker); }
        }
        #endregion

        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["idContributor"] = this.idContributor;
            row["fNameOfContributor"] = this.fNameOfContributor;
            row["lNameOfContributor"] = this.lNameOfContributor;
            row["address"] = this.address;
            row["numOfHome"] = this.numOfHome;
            row["codeTown"] = this.codeTown;
            row["tellephon"] = this.tellephon;
            row["anotherTell"] = this.anotherTell;
            row["mail"] = this.mail;
            row["codeStatus"] = this.codeStatus;
            row["dateOfLastContribution"] = this.dateOfLastContribution;
            row["sumOfLastContribution"] = this.sumOfLastContribution;
            row["idWorker"] = this.idWorker;
            row["noteOnContribution"] = this.noteOnContribution;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.idContributor = Convert.ToInt32(row["idContributor"]);
            this.fNameOfContributor = row["fNameOfContributor"].ToString();
            this.lNameOfContributor = row["lNameOfContributor"].ToString();
            this.address = row["address"].ToString();
            this.numOfHome = Convert.ToInt32(row["numOfHome"]);
            this.codeTown = Convert.ToInt32(row["codeTown"]);
            this.tellephon =  row["tellephon"].ToString();
            this.anotherTell = row["anotherTell"].ToString();
            this.mail = row["mail"].ToString();
            this.codeStatus = Convert.ToInt32(row["codeStatus"]);
            this.dateOfLastContribution = (DateTime)row["dateOfLastContribution"];
            this.sumOfLastContribution = Convert.ToInt32(row["sumOfLastContribution"]);
            this.idWorker = Convert.ToInt32(row["idWorker"]);
            this.noteOnContribution = row["noteOnContribution"].ToString();
        }


        //public override string ToString()
        //{
        //    return  this.fNameOfContributor.ToString()+" "+
        //            this.lNameOfContributor.ToString()+" "+
        //            this.address.ToString()+" "+
        //            this.mail.ToString()+" "+
        //            this.noteOnContribution.ToString(); 
        //}
    }
     
}
