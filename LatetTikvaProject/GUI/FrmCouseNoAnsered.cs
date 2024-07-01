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
    public partial class FrmCouseNoAnsered : Form
    {
        Contributor c;
        Talk t;
        Worker w;
        ListToTalk ltoTalk;
        string notee;
        DateTime d;
        int help;
        public FrmCouseNoAnsered(Contributor currentC, Worker currentW, string note)
        {
            InitializeComponent();
            d = new DateTime();
            d = DateTime.Now;
            t = new Talk();
            c = currentC;
            w = currentW;
            notee = note;
            help = 2;
        }
        public FrmCouseNoAnsered(Contributor currentC, Worker currentW, string note, ListToTalk currentT)
        {
            InitializeComponent();
            d = new DateTime();
            d = DateTime.Now;
            t = new Talk();
            ltoTalk = currentT;
            c = currentC;
            w = currentW;
            notee = note;
            help = 1;
        }

        private void btnNoAnsered_Click(object sender, EventArgs e)//עובד
        {
            if (help == 1)
            {            
                foreach (var item in MyDB.ListToTalk.GetList())
                {
                    if (item.codeListToTalk == ltoTalk.codeListToTalk)
                        ltoTalk = item;
                }
                ltoTalk.codeStatus = 5;
                MyDB.ListToTalk.UpdateItem(ltoTalk);
                MyDB.ListToTalk.SaveChanges();            
            }
             
           FillTalk();
           t.codeStatus = 5;
           c.codeStatus = 5;
           MyDB.Contributors.UpdateItem(c);
           MyDB.Contributors.SaveChanges();
           MyDB.Talks.AddItem(t);
           MyDB.Talks.SaveChanges();
           this.Close();   
        }
        public void FillTalk()
        {
            t.codeTalk = MyDB.Talks.CodeTalk();
            t.dateInPastOfTalk = Convert.ToDateTime(d.ToShortDateString());
            t.timeInPastOfTalk = Convert.ToDateTime(d.ToShortTimeString());
            t.IdWorker = w.IdWorker;
            t.IdContributor = c.IdContributor;
            t.note = notee;
        }

        private void btnBussy_Click(object sender, EventArgs e)//לא עובד
        {
            if (help == 1)
            {
                foreach (var item in MyDB.ListToTalk.GetList())
                {
                    if (item.codeListToTalk == ltoTalk.codeListToTalk)
                        ltoTalk = item;
                }
                ltoTalk.codeStatus = 6;
                MyDB.ListToTalk.UpdateItem(ltoTalk);
                MyDB.ListToTalk.SaveChanges();
            }
            FillTalk();
            t.codeStatus = 6;
            c.codeStatus = 6;
            MyDB.Contributors.UpdateItem(c);
            MyDB.Contributors.SaveChanges();
            MyDB.Talks.AddItem(t);
            MyDB.Talks.SaveChanges();
            this.Close();
        }

        private void btnTaKoly_Click(object sender, EventArgs e)//לא עובד
        {
            if (help == 1)
            {
                foreach (var item in MyDB.ListToTalk.GetList())
                {
                    if (item.codeListToTalk == ltoTalk.codeListToTalk)
                        ltoTalk = item;
                }
                ltoTalk.codeStatus = 7;
                MyDB.ListToTalk.UpdateItem(ltoTalk);
                MyDB.ListToTalk.SaveChanges();
            }
            FillTalk();
            t.codeStatus = 7;
            c.codeStatus = 7;
            MyDB.Contributors.UpdateItem(c);
            MyDB.Contributors.SaveChanges();
            MyDB.Talks.AddItem(t);
            MyDB.Talks.SaveChanges();
            this.Close();
        }

        private void btnNoConnected_Click(object sender, EventArgs e)//לא עובד
        {
            if (help == 1)
            {    
                foreach (var item in MyDB.ListToTalk.GetList())
                {
                    if (item.codeListToTalk == ltoTalk.codeListToTalk)
                        ltoTalk = item;
                }
                ltoTalk.codeStatus = 8;
                MyDB.ListToTalk.UpdateItem(ltoTalk);
                MyDB.ListToTalk.SaveChanges();
            }
            FillTalk();
            t.codeStatus = 8;
            c.codeStatus = 8;
            MyDB.Contributors.UpdateItem(c);
            MyDB.Contributors.SaveChanges();
            MyDB.Talks.AddItem(t);
            MyDB.Talks.SaveChanges();          
            DialogResult r = MessageBox.Show("האם חייגת לשני המספרים? " , "שאלת מערכת", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                foreach (var item in MyDB.RepelledContriburors.GetList().Where(x=>x.IdContributor==c.IdContributor))
                {
                    MyDB.RepelledContriburors.DeleteItem(item);    
                    MyDB.RepelledContriburors.SaveChanges();    
                }
                foreach (var item in MyDB.ListToTalk.GetList().Where(x => x.IdContributor == c.IdContributor))
                {
                    MyDB.ListToTalk.DeleteItem(item);
                    MyDB.ListToTalk.SaveChanges();
                }
                MyDB.Contributors.DeleteItem(c);
                MyDB.Contributors.SaveChanges();
            }
            this.Close();
        }

        private void btnRturn_Click(object sender, EventArgs e)
        {
            if (help == 1)
            {
                FrmUpdateDetailsCoAndCallNow f = new FrmUpdateDetailsCoAndCallNow(c, w, ltoTalk);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                FrmUpdateDetailsCoAndCallNow f = new FrmUpdateDetailsCoAndCallNow(c, w);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (help == 1)
            {
                FrmUpdateDetailsCoAndCallNow f = new FrmUpdateDetailsCoAndCallNow(c, w, ltoTalk);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                FrmUpdateDetailsCoAndCallNow f = new FrmUpdateDetailsCoAndCallNow(c, w);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
