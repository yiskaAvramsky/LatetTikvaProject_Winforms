using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LatetTikvaProject.BLL;

namespace LatetTikvaProject.GUI
{
    public partial class FrmTreatOnNoWantDelateOrReturne : Form
    {
        Contributor c;
        string couse;
        Talk t;
        List<Talk> lst = new List<Talk>();
        public FrmTreatOnNoWantDelateOrReturne(Contributor currentC)
        {
            InitializeComponent();
            c = currentC;
            lst = MyDB.Talks.GetList().Where(x => x.IdContributor == c.IdContributor).OrderBy(x => x.dateInPastOfTalk).ThenBy(x => x.timeInPastOfTalk).ToList();
            //t = lst.Last();
            //couse = t.note;
            couse = lst.Last().note;
            txtCouseNote.Text = couse;
        }

        private void btnInPast_Click(object sender, EventArgs e)
        {
            FrmPerformanceContributionInPast f = new FrmPerformanceContributionInPast(c);
            f.Show();
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("התורם שנבחר הוא: " + c.fNameOfContributor + " " + c.lNameOfContributor + " האם אתה בטוח שברצונך למוחקו", "מחיקת תורם", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MyDB.Contributors.DeleteItem(c);
                MyDB.Contributors.SaveChanges();       
            }
            this.Close();
        }

        private void btnReturne_Click(object sender, EventArgs e)
        {
            foreach (var item in MyDB.Talks.GetList().Where(x => x.IdContributor == c.IdContributor))
            {
                MyDB.Talks.DeleteItem(item);
                MyDB.Talks.SaveChanges();
            }
            c.idWorker = 203882956;
            c.codeStatus = 9;
            MyDB.Contributors.UpdateItem(c);
            MyDB.Contributors.SaveChanges();
            this.Close();
        }
    }
}
