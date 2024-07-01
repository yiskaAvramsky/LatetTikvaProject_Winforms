using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LatetTikvaProject.BLL
{
    public class TarrifOfBonnus:GeneralRow
    {
        public int codeBonus { get; set; }
        public int codeKindOfContribution { get; set; }
        public int persentOfBonus { get; set; }
        public TarrifOfBonnus():base()
        {

        }
        public TarrifOfBonnus(DataRow row):base(row)
        {

        }
        //מאפיינים למפתחות זרים
        #region
        public KindOfContribution ThisKindOfContribution
        {
            get { return MyDB.KindOfContributions.GetList().FirstOrDefault(x => x.codeKindOfContribution == this.codeKindOfContribution); }
        }
        #endregion

        //פונקציה שממלאה את הנתונים בטבלה באקסס
        public override void FillDataRow()
        {
            row["codeBonus"] = this.codeBonus;
            row["codeKindOfContribution"] = this.codeKindOfContribution;
            row["persentOfBonus"] = this.persentOfBonus;
        }
        //פונקציה שמקבלת נתונים מהאקסס ושומרת אותם בתוך משתני המחלקה
        public override void FillFields()
        {
            this.codeBonus = Convert.ToInt32(row["codeBonus"]);
            this.codeKindOfContribution = Convert.ToInt32(row["codeKindOfContribution"]);
            this.persentOfBonus = Convert.ToInt32(row["persentOfBonus"]);
        }

       
    }
}
