using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public class Worker:GeneralRow
    {
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
        public string fNameWorker { get; set; }
        public string lNameWorker { get; set; }
        public string address { get; set; }
        public int numOfHome { get; set; }
        public int codeTown { get; set; }
        public bool IfPriceForTravel { get; set; }
        public int priceForHour { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime dateBeginingWork { get; set; }
        public int codePart { get; set; }
        public Worker() : base()
        {

        }
        public Worker(DataRow row) : base(row)
        {

        }
        //מאפיינים למפתחות זרים
        #region
      
        public Town ThisCity
        {
            get { return MyDB.Towns.GetList().FirstOrDefault(x => x.codeTown == this.codeTown); }
        }
        public Part ThisPart
        {
            get { return MyDB.Parts.GetList().FirstOrDefault(x => x.codePart == this.codePart); }
        }
        #endregion

        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["idWorker"] = this.idWorker;
            row["fNameWorker"] = this.fNameWorker;
            row["lNameWorker"] = this.lNameWorker;
            row["address"] = this.address;
            row["numOfHome"] = this.numOfHome;
            row["codeTown"] = this.codeTown;
            row["IfPriceForTravel"] = this.IfPriceForTravel;
            row["priceForHour"] = this.priceForHour;
            row["dateOfBirth"] = this.dateOfBirth;
            row["dateBeginingWork"] = this.dateBeginingWork;
            row["codePart"] = this.codePart;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.idWorker = Convert.ToInt32(row["idWorker"]);
            this.fNameWorker = row["fNameWorker"].ToString();
            this.lNameWorker = row["lNameWorker"].ToString();
            this.address = row["address"].ToString();
            this.numOfHome = Convert.ToInt32(row["numOfHome"]);
            this.codeTown = Convert.ToInt32(row["codeTown"]);
            this.IfPriceForTravel =(bool)row["IfPriceForTravel"];
            this.priceForHour = Convert.ToInt32(row["priceForHour"]);
            this.dateOfBirth = (DateTime)row["dateOfBirth"];
            this.dateBeginingWork = (DateTime)row["dateBeginingWork"];
            this.codePart = Convert.ToInt32(row["codePart"]);
        }


        public override string ToString()
        {
            return this.fNameWorker.ToString() + " " +
                   this.lNameWorker.ToString(); /*+ " " +*/
                   //this.address.ToString();
        }
    }
}
