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
    public partial class FrmResultOfCall : Form
    {
        Contributor c;
        Worker w;
        ListToTalk ltoTalk;
        int help;
        public FrmResultOfCall()
        {
            InitializeComponent();
        }
        public FrmResultOfCall(Contributor curruntC, Worker currentW)
        {
            InitializeComponent();
            c = curruntC;
            w = currentW;
            help = 2;
        }
        public FrmResultOfCall(Contributor curruntC, Worker currentW, ListToTalk currentToTalk)
        {
            InitializeComponent();
            c = curruntC;
            w = currentW;
            ltoTalk = currentToTalk;
            help = 1;
        }

        private void btnPerformanceContribution_Click(object sender, EventArgs e)
        {
            if (help == 1)
            {  
                foreach (var item in MyDB.ListToTalk.GetList())
                {
                    if (item.codeListToTalk == ltoTalk.codeListToTalk)
                        ltoTalk = item;
                }
                ltoTalk.codeStatus = 2;
                MyDB.ListToTalk.UpdateItem(ltoTalk);
                MyDB.ListToTalk.SaveChanges();    
            }
            c.codeStatus = 2;
            MyDB.Contributors.UpdateItem(c);
            MyDB.Contributors.SaveChanges();
            FrmPerformanceContribution p = new FrmPerformanceContribution(c, w);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void btnRepelled_Click(object sender, EventArgs e)
        {
            if (help == 1)
            {    
                foreach (var item in MyDB.ListToTalk.GetList())
                {
                    if (item.codeListToTalk == ltoTalk.codeListToTalk)
                        ltoTalk = item;
                }
                ltoTalk.codeStatus = 3;
                MyDB.ListToTalk.UpdateItem(ltoTalk);
                MyDB.ListToTalk.SaveChanges();
            }
            
            FrmAddRepelled f = new FrmAddRepelled(c, w);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnNoWant_Click(object sender, EventArgs e)
        {
            if (help == 1)
            { 
                foreach (var item in MyDB.ListToTalk.GetList())
                {
                    if (item.codeListToTalk == ltoTalk.codeListToTalk)
                        ltoTalk = item;
                }
                ltoTalk.codeStatus = 4;
                MyDB.ListToTalk.UpdateItem(ltoTalk);
                MyDB.ListToTalk.SaveChanges();
            }
            c.codeStatus = 4;
            MyDB.Contributors.UpdateItem(c);
            MyDB.Contributors.SaveChanges();
            FrmNoIntersted f = new FrmNoIntersted(c, w);
            f.ShowDialog();
            this.Close();     
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(help==1)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
