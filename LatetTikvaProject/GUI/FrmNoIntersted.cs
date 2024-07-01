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
    public partial class FrmNoIntersted : Form
    {
        Talk t;
        DateTime d;
        Worker w;
        Contributor c;
        ListToTalk ll;
        Repelled rr;
        //bool flag;
        public FrmNoIntersted(Contributor currentC, Worker currentW)
        {
            InitializeComponent();
            c = currentC;
            w = currentW;
            t = new Talk();
            d = new DateTime();
            d = DateTime.Now;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //flag = true;
            //if (txtNote.Text == "")
            //    errorProvider1.SetError(txtNote, "הכנס ערך"); flag = false;
            //if (txtNote.Text != "")
            //    errorProvider1.Clear(); flag = true;
            //if (flag)
            //{
                FillTalk();
                MyDB.Talks.AddItem(t);
                MyDB.Talks.SaveChanges();
                foreach (var item in MyDB.RepelledContriburors.GetList())
                {
                    if (item.IdContributor == c.IdContributor)
                        rr = item;
                }
                if (rr != null)
                {
                    MyDB.RepelledContriburors.DeleteItem(rr);
                    MyDB.RepelledContriburors.SaveChanges();
                }


                foreach (var item in MyDB.ListToTalk.GetList())
                {
                    if (item.IdContributor == c.IdContributor)
                        ll = item;
                }
                if (ll != null)
                {
                    MyDB.ListToTalk.DeleteItem(ll);
                    MyDB.ListToTalk.SaveChanges();
                }

                this.Close();
            //}          
        }
        public void FillTalk()
        {
            t.codeTalk = MyDB.Talks.CodeTalk();
            t.dateInPastOfTalk = Convert.ToDateTime(d.ToShortDateString());
            t.timeInPastOfTalk = Convert.ToDateTime(d.ToLongTimeString());
            t.IdWorker = w.IdWorker;
            t.IdContributor = c.IdContributor;
            t.note = txtNote.Text;
            t.codeStatus = 4;
        }
    }
}
