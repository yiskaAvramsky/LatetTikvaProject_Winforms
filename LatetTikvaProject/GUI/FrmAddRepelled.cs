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
    public partial class FrmAddRepelled : Form
    {
        Contributor c;
        Worker w;
        Repelled r;
        Talk t;
        DateTime d;
        ListToTalk l;
        bool flag;
        public FrmAddRepelled()
        {
            InitializeComponent();
        }
        public FrmAddRepelled(Contributor currentC, Worker currentW)
        {
            InitializeComponent();
            c = currentC;
            w = currentW;
            r = new Repelled();
            t = new Talk();
            d = new DateTime();
            d = DateTime.Now;
        }

      public void FillRepelled()
        {
            flag = true;
            r.codeRepelled = MyDB.RepelledContriburors.CodeRepelled();
            r.IdWorker = w.IdWorker;
            r.IdContributor = c.IdContributor;
            r.reseonRepelled = txtCouse.Text;
            r.dateRepelled = dateTimePicker1.Value.Date;
            //r.timeToRepelled = Convert.ToDateTime(txtTime.Text);
            try { r.timeToRepelled = Convert.ToDateTime(txtTime.Text); }
            catch { errorProvider1.SetError(txtTime, "השעה אינה תקינה"); flag = false; }
           if(r.dateRepelled.AddDays(1)<DateTime.Now)
           {
                errorProvider1.SetError(dateTimePicker1, "התאריך אינו תקין") ;
                flag = false;
           }
           if(r.dateRepelled.Date == DateTime.Now.Date)
                if(r.timeToRepelled<= DateTime.Now)
                {
                    errorProvider1.SetError(txtTime, "השעה אינה תקינה");
                    flag = false;
                }
            
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {            
            FillTalk();
            MyDB.Talks.AddItem(t);
            MyDB.Talks.SaveChanges();
            FillRepelled();
            foreach (var item in MyDB.RepelledContriburors.GetList())
            {
                if (item.IdContributor == r.IdContributor)
                {
                    MyDB.RepelledContriburors.DeleteItem(item);
                    MyDB.RepelledContriburors.SaveChanges();
                }
            }
            if (flag)
            {
                MyDB.RepelledContriburors.AddItem(r);
                MyDB.RepelledContriburors.SaveChanges();
                foreach (var item in MyDB.ListToTalk.GetList().Where(x => x.IdContributor == c.IdContributor))
                {
                    MyDB.ListToTalk.DeleteItem(item);
                    MyDB.ListToTalk.SaveChanges();
                }
                
                c.codeStatus = 3;
                MyDB.Contributors.UpdateItem(c);
                MyDB.Contributors.SaveChanges();
                this.Close();
            }
        }
        public void FillTalk()
        {
            t.codeTalk = MyDB.Talks.CodeTalk();
            t.dateInPastOfTalk = Convert.ToDateTime(d.ToShortDateString());   
            t.timeInPastOfTalk = Convert.ToDateTime(d.ToLongTimeString());    
            t.IdWorker = w.IdWorker;
            t.IdContributor = c.IdContributor;
            t.note = txtCouse.Text;
            t.codeStatus = 3;
        }

    }
}
