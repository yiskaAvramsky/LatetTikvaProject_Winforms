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
    public partial class FrmListW : Form
    {
        Worker w;
        Contributor c;
        ListToTalk t;
        //Repelled r;
        public FrmListW(Worker w1)
        {
            InitializeComponent();            
            DateTime time = new DateTime();
            time = DateTime.Now.ToLocalTime();            
            label2.Text = time.ToString();
            this.w = w1;
            dataGridViewList.DataSource = MyDB.ListToTalk.GetList().Where(x => x.IdWorker == w.IdWorker).Select(x => new { x.IdContributor, x.ThisContributor.lNameOfContributor, x.ThisContributor.fNameOfContributor, x.ThisContributor.ThisCity.nameOfTown, x.ThisContributor.sumOfLastContribution, x.ThisContributor.noteOnContribution, x.ThisStatus.status, x.codeListToTalk }).ToList();
            dataGridViewList.Columns[0].HeaderText = "ת.ז";
            dataGridViewList.Columns[1].HeaderText = "שם משפחה";
            dataGridViewList.Columns[2].HeaderText = "שם פרטי";
            dataGridViewList.Columns[3].HeaderText = "עיר";
            dataGridViewList.Columns[4].HeaderText = "סך תרומה אחרונה";
            dataGridViewList.Columns[5].HeaderText = "הערות";
            dataGridViewList.Columns[6].HeaderText = "סטטוס";
            dataGridViewList.Columns[7].HeaderText = "קוד רשומה להתקשרות";
            dataGridViewList.Columns[7].Visible = false;
            dataGridViewReppelled.DataSource = MyDB.RepelledContriburors.GetList().Where(x => x.IdWorker == w.IdWorker).Select(x => new { x.IdContributor, x.ThisContributor.lNameOfContributor, x.ThisContributor.fNameOfContributor, x.ThisContributor.ThisCity.nameOfTown, x.ThisContributor.sumOfLastContribution, x.ThisContributor.noteOnContribution, x.dateRepelled.Date, x.timeToRepelled.TimeOfDay, x.reseonRepelled/*, x.ThisStatus.status, x.codeRepelled*/}).OrderByDescending(x => x.Date).ThenByDescending(x => x.TimeOfDay).ToList();
            dataGridViewReppelled.Columns[0].HeaderText = "ת.ז";
            dataGridViewReppelled.Columns[1].HeaderText = "שם משפחה";
            dataGridViewReppelled.Columns[2].HeaderText = "שם פרטי";
            dataGridViewReppelled.Columns[3].HeaderText = "עיר";
            dataGridViewReppelled.Columns[4].HeaderText = "סך תרומה אחרונה";
            dataGridViewReppelled.Columns[5].HeaderText = "הערות";
            dataGridViewReppelled.Columns[6].HeaderText = "תאריך דחיה";
            dataGridViewReppelled.Columns[7].HeaderText = "שעת דחיה";
            dataGridViewReppelled.Columns[8].HeaderText = "סיבת דחיה";
            label4.Text = w.fNameWorker + " " + w.lNameWorker;
            
            //dataGridViewReppelled.Columns[9].HeaderText = "סטטוס";
            //dataGridViewReppelled.Columns[10].HeaderText = "קוד דחוי";
            //dataGridViewReppelled.Columns[10].Visible = false;
        }
        private void dataGridViewReppelled_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            c = new Contributor();
            //r = new Repelled();
            foreach (var item in MyDB.Contributors.GetList())
            {
                if (item.IdContributor.ToString() == dataGridViewReppelled.CurrentRow.Cells[0].Value.ToString())
                    c = item;
            }
            //r.codeRepelled = Convert.ToInt32(dataGridViewReppelled.CurrentRow.Cells[10].Value);
            FrmUpdateDetailsCoAndCallNow f = new FrmUpdateDetailsCoAndCallNow(c,w/*,r*/);
            this.Hide();
            f.ShowDialog();
            //dataGridViewList.DataSource = MyDB.ListToTalk.GetList().Where(x => x.IdWorker == w.IdWorker).Select(x => new { x.IdContributor, x.ThisContributor.lNameOfContributor, x.ThisContributor.fNameOfContributor, x.ThisContributor.ThisCity.nameOfTown, x.ThisContributor.sumOfLastContribution, x.ThisContributor.noteOnContribution, x.ThisStatus.status, x.codeListToTalk }).ToList();
            dataGridViewReppelled.DataSource = MyDB.RepelledContriburors.GetList().Where(x => x.IdWorker == w.IdWorker).Select(x => new { x.IdContributor, x.ThisContributor.lNameOfContributor, x.ThisContributor.fNameOfContributor, x.ThisContributor.ThisCity.nameOfTown, x.ThisContributor.sumOfLastContribution, x.ThisContributor.noteOnContribution, x.dateRepelled.Date, x.timeToRepelled.TimeOfDay, x.reseonRepelled/*, x.ThisStatus.status, x.codeRepelled */}).OrderByDescending(x => x.Date).ThenByDescending(x => x.TimeOfDay).ToList();
            this.Show();
        }

        private void dataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            c = new Contributor();
            t = new ListToTalk();
            foreach (var item in MyDB.Contributors.GetList())
            {
                if (item.IdContributor.ToString() == dataGridViewList.CurrentRow.Cells[0].Value.ToString())
                    c = item;
            }
            t.codeListToTalk = Convert.ToInt32(dataGridViewList.CurrentRow.Cells[7].Value);
            FrmUpdateDetailsCoAndCallNow f = new FrmUpdateDetailsCoAndCallNow(c,w,t);
            this.Hide();
            f.ShowDialog();
            dataGridViewList.DataSource = MyDB.ListToTalk.GetList().Where(x => x.IdWorker == w.IdWorker).Select(x => new { x.IdContributor, x.ThisContributor.lNameOfContributor, x.ThisContributor.fNameOfContributor, x.ThisContributor.ThisCity.nameOfTown, x.ThisContributor.sumOfLastContribution, x.ThisContributor.noteOnContribution, x.ThisStatus.status, x.codeListToTalk }).ToList();
            dataGridViewReppelled.DataSource = MyDB.RepelledContriburors.GetList().Where(x => x.IdWorker == w.IdWorker).Select(x => new { x.IdContributor, x.ThisContributor.lNameOfContributor, x.ThisContributor.fNameOfContributor, x.ThisContributor.ThisCity.nameOfTown, x.ThisContributor.sumOfLastContribution, x.ThisContributor.noteOnContribution, x.dateRepelled.Date, x.timeToRepelled.TimeOfDay, x.reseonRepelled/*, x.ThisStatus.status, x.codeRepelled */}).OrderByDescending(x => x.Date).ThenByDescending(x => x.TimeOfDay).ToList();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmContributionToday f = new FrmContributionToday(w);
            f.Show();
        }

        private void addC_Click(object sender, EventArgs e)
        {
            FrmAddContributon f = new FrmAddContributon(w.IdWorker);   
            
            f.ShowDialog();
            dataGridViewList.DataSource = MyDB.ListToTalk.GetList().Where(x => x.IdWorker == w.IdWorker).Where(x => x.ThisContributor.codeStatus != 3).Select(x => new { x.IdContributor, x.ThisContributor.lNameOfContributor, x.ThisContributor.fNameOfContributor, x.ThisContributor.ThisCity.nameOfTown, x.ThisContributor.sumOfLastContribution, x.ThisContributor.noteOnContribution, x.ThisStatus.status, x.codeListToTalk }).ToList();
            dataGridViewReppelled.DataSource = MyDB.RepelledContriburors.GetList().Where(x => x.IdWorker == w.IdWorker).Select(x => new { x.IdContributor, x.ThisContributor.lNameOfContributor, x.ThisContributor.fNameOfContributor, x.ThisContributor.ThisCity.nameOfTown, x.ThisContributor.sumOfLastContribution, x.ThisContributor.noteOnContribution, x.dateRepelled.Date, x.timeToRepelled.TimeOfDay, x.reseonRepelled/*, x.ThisStatus.status, x.codeRepelled */}).OrderByDescending(x => x.Date).ThenByDescending(x => x.TimeOfDay).ToList();
            this.Show();
        }

        private void FrmListW_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FrmFindC f = new FrmFindC(w);
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewList.DataSource = MyDB.ListToTalk.GetList().Where(x => x.IdWorker == w.IdWorker).Select(x => new { x.IdContributor, x.ThisContributor.lNameOfContributor, x.ThisContributor.fNameOfContributor, x.ThisContributor.ThisCity.nameOfTown, x.ThisContributor.sumOfLastContribution, x.ThisContributor.noteOnContribution, x.ThisStatus.status, x.codeListToTalk }).OrderByDescending(x=>x.sumOfLastContribution).ToList();
            dataGridViewReppelled.DataSource = MyDB.RepelledContriburors.GetList().Where(x => x.IdWorker == w.IdWorker).Select(x => new { x.IdContributor, x.ThisContributor.lNameOfContributor, x.ThisContributor.fNameOfContributor, x.ThisContributor.ThisCity.nameOfTown, x.ThisContributor.sumOfLastContribution, x.ThisContributor.noteOnContribution, x.dateRepelled.Date, x.timeToRepelled.TimeOfDay, x.reseonRepelled/*, x.ThisStatus.status, x.codeRepelled*/}).OrderByDescending(x=>x.sumOfLastContribution).ToList();
        }
    }
}
