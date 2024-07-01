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
    public partial class FrmListContibutors : Form
    {
        Contributor c;
        public FrmListContibutors()
        {
            InitializeComponent();
            dgvListC.DataSource = MyDB.Contributors.GetList().Where(x=>x.sumOfLastContribution!=0).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.dateOfLastContribution, x.sumOfLastContribution, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker, x.noteOnContribution }).OrderBy(x => x.lNameOfContributor).ThenBy(x => x.fNameOfContributor).ToList();
            dgvListC.Columns[0].HeaderText = "ת.ז תורם";
            dgvListC.Columns[1].HeaderText = "שם משפחה";
            dgvListC.Columns[2].HeaderText = "שם פרטי";
            dgvListC.Columns[3].HeaderText = "עיר";
            dgvListC.Columns[4].HeaderText = "רחוב";
            dgvListC.Columns[5].HeaderText = "מספר בית";
            dgvListC.Columns[6].HeaderText = "טלפון";
            dgvListC.Columns[7].HeaderText = "טלפון נוסף";
            dgvListC.Columns[8].HeaderText = "מייל";
            dgvListC.Columns[9].HeaderText = "סטטוס";
            dgvListC.Columns[10].HeaderText = "ת.תרומה אחרונה";
            dgvListC.Columns[11].HeaderText = "סך תרומה אחרונה";
            dgvListC.Columns[12].HeaderText = "שם משפחה עובד מטפל";
            dgvListC.Columns[13].HeaderText = "שם פרטי עובד מטפל";
            dgvListC.Columns[14].HeaderText = "הערות";
            addC.Visible = false;
            
        }
        private void dgvListC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)////
        {

            c = new Contributor();
            foreach (var item in MyDB.Contributors.GetList())
            {
                if (item.IdContributor.ToString() == dgvListC.CurrentRow.Cells[0].Value.ToString())
                    c = item;
            }
            if (radioButton2.Checked)
            {
                FrmAddContributon ff = new FrmAddContributon(c);
                ff.ShowDialog();
                this.Show();
                dgvListC.DataSource = MyDB.Contributors.GetList().Where(x => x.sumOfLastContribution == 0).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker }).OrderBy(x => x.lNameOfContributor).ThenBy(x => x.fNameOfContributor).ToList();
            }
            else
            {
                FrmUpdateContributor f = new FrmUpdateContributor(c);
                f.ShowDialog();
                this.Show();
                dgvListC.DataSource = MyDB.Contributors.GetList().Where(x => x.sumOfLastContribution != 0).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.dateOfLastContribution, x.sumOfLastContribution, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker, x.noteOnContribution }).OrderBy(x => x.lNameOfContributor).ThenBy(x => x.fNameOfContributor).ToList();
            }
        }

         
        private void updateC_Click_1(object sender, EventArgs e)////
        {
            c = new Contributor();
            foreach (var item in MyDB.Contributors.GetList())
            {
                if (item.IdContributor.ToString() == dgvListC.CurrentRow.Cells[0].Value.ToString())
                    c = item;
            }
            if (radioButton2.Checked)
            {               
                FrmAddContributon ff = new FrmAddContributon(c);
                ff.ShowDialog();
                this.Show();
                dgvListC.DataSource = MyDB.Contributors.GetList().Where(x => x.sumOfLastContribution == 0).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker }).OrderBy(x => x.lNameOfContributor).ThenBy(x => x.fNameOfContributor).ToList();
            }
            else
            {
                FrmUpdateContributor f = new FrmUpdateContributor(c);
                f.ShowDialog();
                this.Show();
                dgvListC.DataSource = MyDB.Contributors.GetList().Where(x => x.sumOfLastContribution != 0).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.dateOfLastContribution, x.sumOfLastContribution, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker, x.noteOnContribution }).OrderBy(x => x.lNameOfContributor).ThenBy(x => x.fNameOfContributor).ToList();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            addC.Visible = true;
            dgvListC.DataSource = MyDB.Contributors.GetList().Where(x => x.sumOfLastContribution == 0).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker }).OrderBy(x => x.lNameOfContributor).ThenBy(x => x.fNameOfContributor).ToList();
            dgvListC.Columns[0].HeaderText = "ת.ז תורם";
            dgvListC.Columns[1].HeaderText = "שם משפחה";
            dgvListC.Columns[2].HeaderText = "שם פרטי";
            dgvListC.Columns[3].HeaderText = "עיר";
            dgvListC.Columns[4].HeaderText = "רחוב";
            dgvListC.Columns[5].HeaderText = "מספר בית";
            dgvListC.Columns[6].HeaderText = "טלפון";
            dgvListC.Columns[7].HeaderText = "טלפון נוסף";
            dgvListC.Columns[8].HeaderText = "מייל";
            dgvListC.Columns[9].HeaderText = "סטטוס";
            dgvListC.Columns[10].HeaderText = "שם משפחה עובד מטפל";
            dgvListC.Columns[11].HeaderText = "שם פרטי עובד מטפל";
             
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dgvListC.DataSource = MyDB.Contributors.GetList().Where(x => x.sumOfLastContribution != 0).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.dateOfLastContribution, x.sumOfLastContribution, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker, x.noteOnContribution }).OrderBy(x => x.lNameOfContributor).ThenBy(x => x.fNameOfContributor).ToList();
            dgvListC.Columns[0].HeaderText = "ת.ז תורם";
            dgvListC.Columns[1].HeaderText = "שם משפחה";
            dgvListC.Columns[2].HeaderText = "שם פרטי";
            dgvListC.Columns[3].HeaderText = "עיר";
            dgvListC.Columns[4].HeaderText = "רחוב";
            dgvListC.Columns[5].HeaderText = "מספר בית";
            dgvListC.Columns[6].HeaderText = "טלפון";
            dgvListC.Columns[7].HeaderText = "טלפון נוסף";
            dgvListC.Columns[8].HeaderText = "מייל";
            dgvListC.Columns[9].HeaderText = "סטטוס";
            dgvListC.Columns[10].HeaderText = "ת.תרומה אחרונה";
            dgvListC.Columns[11].HeaderText = "סך תרומה אחרונה";
            dgvListC.Columns[12].HeaderText = "שם משפחה עובד מטפל";
            dgvListC.Columns[13].HeaderText = "שם פרטי עובד מטפל";
            dgvListC.Columns[14].HeaderText = "הערות";
            addC.Visible = false;
        }

        private void dgvListC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addC_Click(object sender, EventArgs e)
        {
            FrmAddContributon f = new FrmAddContributon();
            f.ShowDialog();
            this.Show();
            dgvListC.DataSource = MyDB.Contributors.GetList().Where(x => x.sumOfLastContribution == 0).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker }).OrderBy(x => x.lNameOfContributor).ThenBy(x => x.fNameOfContributor).ToList();
        }
    }
}
