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
    public partial class FrmTreatOnNoIntersted : Form
    {
        Contributor c;
        public FrmTreatOnNoIntersted()
        {
            InitializeComponent();
            dataGvTreatNoWant.DataSource = MyDB.Contributors.GetList().Where(x => x.codeStatus == 4).Select(x => new {x.IdContributor, x.lNameOfContributor ,x.fNameOfContributor,x.Tellephon,x.AnotherTell,x.Mail,x.ThisStatus.status,x.sumOfLastContribution,x.ThisWorker.lNameWorker,x.ThisWorker.fNameWorker,x.noteOnContribution}).ToList();
            dataGvTreatNoWant.Columns[0].HeaderText = "ת.ז";
            dataGvTreatNoWant.Columns[1].HeaderText = "שם משפחה";
            dataGvTreatNoWant.Columns[2].HeaderText = "שם פרטי";
            dataGvTreatNoWant.Columns[3].HeaderText = "טלפון";
            dataGvTreatNoWant.Columns[4].HeaderText = "טלפון נוסף";
            dataGvTreatNoWant.Columns[5].HeaderText = "מייל";
            dataGvTreatNoWant.Columns[6].HeaderText = "סטטוס";
            dataGvTreatNoWant.Columns[7].HeaderText = "סכום תרומה אחרונה";
            dataGvTreatNoWant.Columns[8].HeaderText = "שם משפחה עובד מטפל";
            dataGvTreatNoWant.Columns[9].HeaderText = "שפ פרטי עובד מטפל";
            dataGvTreatNoWant.Columns[10].HeaderText = "הערות";
            dataGvTreatNoWant.Columns[0].Visible = false;
        }

        private void dataGvTreatNoWant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            c = new Contributor();
            foreach (var item in MyDB.Contributors.GetList())
            {
                if (item.IdContributor.ToString() == dataGvTreatNoWant.CurrentRow.Cells[0].Value.ToString())
                    c = item;
            }
            FrmTreatOnNoWantDelateOrReturne f = new FrmTreatOnNoWantDelateOrReturne(c);
            f.ShowDialog();
            dataGvTreatNoWant.DataSource = MyDB.Contributors.GetList().Where(x => x.codeStatus == 4).Select(x => new {x.IdContributor, x.lNameOfContributor, x.fNameOfContributor, x.Tellephon, x.AnotherTell, x.Mail, x.ThisStatus.status, x.sumOfLastContribution, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker, x.noteOnContribution }).ToList();
        }
    }
}
