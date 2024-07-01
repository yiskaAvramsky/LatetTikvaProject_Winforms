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
    public partial class FrmConditionOfWorker : Form
    {
        Worker w;
        List<string> listn = new List<string>();
        ListToTalk l;
        Contributor c;
        Status s;        
        List<DataGridViewRow> lst;
        public FrmConditionOfWorker()
        {
            InitializeComponent();            
            foreach (var item in MyDB.Workers.GetList())
            {
                listn.Add(item.fNameWorker + " " + item.lNameWorker);
            }
            cmbNameOfW.DataSource = listn;
        }
        public FrmConditionOfWorker(string ss)
        {
            InitializeComponent();
            btnOk.Text = ss;
            foreach (var item in MyDB.Workers.GetList())
            {
                listn.Add(item.fNameWorker + " " + item.lNameWorker);
            }
            cmbNameOfW.DataSource = listn;
        }
        public FrmConditionOfWorker(List<DataGridViewRow> currentLstC)
        {
            InitializeComponent();
            btnOk.Text = "שלח";
            foreach (var item in MyDB.Workers.GetList())
            {
                listn.Add(item.fNameWorker + " " + item.lNameWorker);
            }
            cmbNameOfW.DataSource = listn;
            lst = currentLstC;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "אישור")
            {
                w = MyDB.Workers.GetList().FirstOrDefault(x => (cmbNameOfW.SelectedItem.ToString().Contains(x.lNameWorker) && cmbNameOfW.SelectedItem.ToString().Contains(x.fNameWorker)));
                FrmListW fW = new FrmListW(w);
                fW.Show();
            }
            if(btnOk.Text == "שלח")
            {
                foreach (var item in lst)
                {
                    c = MyDB.Contributors.GetList().FirstOrDefault(x => x.IdContributor.ToString() == item.Cells[0].Value.ToString());
                    c.idWorker = MyDB.Workers.GetList().FirstOrDefault(x =>(cmbNameOfW.SelectedItem.ToString().Contains(x.fNameWorker)&&cmbNameOfW.SelectedItem.ToString().Contains(x.lNameWorker))).IdWorker;
                    MyDB.Contributors.UpdateItem(c);
                    MyDB.Contributors.SaveChanges();
                    FillListToTalk();
                    MyDB.ListToTalk.AddItem(l);
                    MyDB.ListToTalk.SaveChanges();
                }
                //foreach (var item in MyDB.ListToTalk.GetList().Where(x =>x.IdWorker==c.idWorker))//לא עזר לריענון
                //{
                //    MyDB.ListToTalk.UpdateItem(item);
                //    MyDB.ListToTalk.SaveChanges();
                //}
               
                MessageBox.Show("השיוך התבצע!");//בפעם הראשונה זה מראה לי תורמים כפולים ואחרי סגירה והרצה אני רואה טוב
                this.Close();
            }
            if(btnOk.Text== "נקה רשומות")
            {
                w = MyDB.Workers.GetList().FirstOrDefault(x => (cmbNameOfW.SelectedItem.ToString().Contains(x.lNameWorker) && cmbNameOfW.SelectedItem.ToString().Contains(x.fNameWorker)));
                foreach (var item in MyDB.ListToTalk.GetList().Where(x=>x.IdWorker==w.IdWorker))
                {
                    c = MyDB.Contributors.GetList().FirstOrDefault(x => x.IdContributor == item.IdContributor);
                    c.idWorker = 203882956;
                    MyDB.Contributors.UpdateItem(c);
                    MyDB.Contributors.SaveChanges();
                    MyDB.ListToTalk.DeleteItem(item);
                    MyDB.ListToTalk.SaveChanges();
                }
                foreach (var item in MyDB.RepelledContriburors.GetList().Where(x => x.IdWorker == w.IdWorker))
                {
                    c = MyDB.Contributors.GetList().FirstOrDefault(x => x.IdContributor == item.IdContributor);
                    c.idWorker = 203882956;
                    MyDB.Contributors.UpdateItem(c);
                    MyDB.Contributors.SaveChanges();
                    MyDB.RepelledContriburors.DeleteItem(item);
                    MyDB.RepelledContriburors.SaveChanges();
                }
                MessageBox.Show("המחיקה התבצעה!"); 
                this.Close();
            }
        }
        public void FillListToTalk()
        {
            l = new ListToTalk();
            l.codeListToTalk = MyDB.ListToTalk.CodeListsToTalk();
            l.IdWorker = MyDB.Workers.GetList().FirstOrDefault(x => (cmbNameOfW.SelectedItem.ToString().Contains(x.fNameWorker) && cmbNameOfW.SelectedItem.ToString().Contains(x.lNameWorker))).IdWorker;
            l.IdContributor = c.IdContributor;
            l.codeStatus = c.codeStatus;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
