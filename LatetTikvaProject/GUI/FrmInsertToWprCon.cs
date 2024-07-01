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
    public partial class FrmInsertToWprCon : Form
    {
        List<Contributor> lstt = new List<Contributor>();
        List<DataGridViewRow> lst= new List<DataGridViewRow>();
         
         
        public FrmInsertToWprCon()
        {
            InitializeComponent();
            dgvConToInsert.DataSource = MyDB.Contributors.GetList().Where(x => x.idWorker == 203882956).Where(x=>x.dateOfLastContribution.AddDays(60)<=DateTime.Now).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status,x.sumOfLastContribution}).OrderBy(x => x.lNameOfContributor).ThenBy(x => x.fNameOfContributor).ToList();
            dgvConToInsert.Columns[0].HeaderText = "ת.ז תורם";
            dgvConToInsert.Columns[1].HeaderText = "שם משפחה";
            dgvConToInsert.Columns[2].HeaderText = "שם פרטי";
            dgvConToInsert.Columns[3].HeaderText = "עיר";
            dgvConToInsert.Columns[4].HeaderText = "רחוב";
            dgvConToInsert.Columns[5].HeaderText = "מספר בית";
            dgvConToInsert.Columns[6].HeaderText = "טלפון";
            dgvConToInsert.Columns[7].HeaderText = "טלפון נוסף";
            dgvConToInsert.Columns[8].HeaderText = "מייל";
            dgvConToInsert.Columns[9].HeaderText = "סטטוס";
            dgvConToInsert.Columns[10].HeaderText = "ת.תרומה אחרונה";
            
        }

        private void btnChooseWor_Click(object sender, EventArgs e)
        {
           
            foreach (var item in dgvConToInsert.SelectedRows)
            {
              lst.Add((DataGridViewRow)item);
                //lst.Add(item);
            }
            FrmConditionOfWorker f = new FrmConditionOfWorker(lst);
            f.ShowDialog();
            dgvConToInsert.DataSource = MyDB.Contributors.GetList().Where(x => x.idWorker == 203882956).Where(x => x.dateOfLastContribution.AddDays(60) <= DateTime.Now).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status,x.sumOfLastContribution }).OrderBy(x => x.lNameOfContributor).ThenBy(x => x.fNameOfContributor).ToList();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "לא מעוניינים")                
                dgvConToInsert.DataSource = MyDB.Contributors.GetList().Where(x => x.idWorker == 203882956).Where(x => x.dateOfLastContribution.AddDays(60) <= DateTime.Now).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status,x.sumOfLastContribution }).OrderByDescending(x=>x.status== "לא מעונין שיוך").ToList();
            if (comboBox1.SelectedItem.ToString() == "סכום תרומה אחרונה")
                dgvConToInsert.DataSource = MyDB.Contributors.GetList().Where(x => x.idWorker == 203882956).Where(x => x.dateOfLastContribution.AddDays(60) <= DateTime.Now).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.sumOfLastContribution }).OrderByDescending(x => x.sumOfLastContribution).ToList();
            if (comboBox1.SelectedItem.ToString() == "חדשים")
                dgvConToInsert.DataSource = MyDB.Contributors.GetList().Where(x => x.idWorker == 203882956).Where(x => x.dateOfLastContribution.AddDays(60) <= DateTime.Now).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.sumOfLastContribution }).OrderByDescending(x => x.status == "חדש").ToList();
            if (comboBox1.SelectedItem.ToString() == "ביצוע עסקה")
                dgvConToInsert.DataSource = MyDB.Contributors.GetList().Where(x => x.idWorker == 203882956).Where(x => x.dateOfLastContribution.AddDays(60) <= DateTime.Now).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.sumOfLastContribution }).OrderByDescending(x => x.status == "ביצוע עסקה").ToList();
            if (comboBox1.SelectedItem.ToString() == "דחויים")
                dgvConToInsert.DataSource = MyDB.Contributors.GetList().Where(x => x.idWorker == 203882956).Where(x => x.dateOfLastContribution.AddDays(60) <= DateTime.Now).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.sumOfLastContribution }).OrderByDescending(x => x.status == "דחייה").ToList();
            if (comboBox1.SelectedItem.ToString() == "לא נענה")
                dgvConToInsert.DataSource = MyDB.Contributors.GetList().Where(x => x.idWorker == 203882956).Where(x => x.dateOfLastContribution.AddDays(60) <= DateTime.Now).Select(x => new { x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.sumOfLastContribution }).OrderByDescending(x => x.status == "לא נענה").ThenByDescending(x=>x.status== "מספר תפוס").ThenByDescending(x => x.status == "תא קולי").ToList();
        }
    }
}
