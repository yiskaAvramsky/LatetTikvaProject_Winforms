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
    public partial class FrmPerformanceCToPay : Form
    {
        public FrmPerformanceCToPay()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDB.Contributions.GetList().Where(x => x.ThisPerformanceContribution.dateOfContribution == DateTime.Now.Date).Select(x => new { x.ThisPerformanceContribution.ThisContributor.lNameOfContributor, x.ThisPerformanceContribution.ThisContributor.fNameOfContributor, x.ThisPerformanceContribution.sumOfContribution, x.bonus, x.ThisPerformanceContribution.codePerformanceContribution, x.codeContribution ,x.ThisWorker.lNameWorker,x.ThisWorker.fNameWorker}).ToList();
            dataGridView1.Columns[0].HeaderText = "שם משפחה תורם";
            dataGridView1.Columns[1].HeaderText = "שם פרטי תורם";
            dataGridView1.Columns[2].HeaderText = "סכום תרומה";
            dataGridView1.Columns[3].HeaderText = "בונוס מתרומה זו";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "שם משפחה עובד מטפל";
            dataGridView1.Columns[7].HeaderText = "שם פרטי עובד מטפל";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyDB.Contributions.GetList().Select(x => new { x.ThisPerformanceContribution.ThisContributor.lNameOfContributor, x.ThisPerformanceContribution.ThisContributor.fNameOfContributor, x.ThisPerformanceContribution.sumOfContribution, x.bonus, x.ThisPerformanceContribution.codePerformanceContribution, x.codeContribution, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker,x.ThisPerformanceContribution.dateOfContribution}).OrderByDescending(x=>x.dateOfContribution).ToList();
            dataGridView1.Columns[0].HeaderText = "שם משפחה תורם";
            dataGridView1.Columns[1].HeaderText = "שם פרטי תורם";
            dataGridView1.Columns[2].HeaderText = "סכום תרומה";
            dataGridView1.Columns[3].HeaderText = "בונוס מתרומה זו";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "שם משפחה עובד מטפל";
            dataGridView1.Columns[7].HeaderText = "שם פרטי עובד מטפל";
            dataGridView1.Columns[8].HeaderText = "תאריך תרומה";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyDB.Contributions.GetList().Where(x => x.ThisPerformanceContribution.dateOfContribution == DateTime.Now.Date).Select(x => new { x.ThisPerformanceContribution.ThisContributor.lNameOfContributor, x.ThisPerformanceContribution.ThisContributor.fNameOfContributor, x.ThisPerformanceContribution.sumOfContribution, x.bonus, x.ThisPerformanceContribution.codePerformanceContribution, x.codeContribution, x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker ,x.ThisPerformanceContribution.dateOfContribution}).ToList();
            dataGridView1.Columns[0].HeaderText = "שם משפחה תורם";
            dataGridView1.Columns[1].HeaderText = "שם פרטי תורם";
            dataGridView1.Columns[2].HeaderText = "סכום תרומה";
            dataGridView1.Columns[3].HeaderText = "בונוס מתרומה זו";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "שם משפחה עובד מטפל";
            dataGridView1.Columns[7].HeaderText = "שם פרטי עובד מטפל";
            dataGridView1.Columns[8].HeaderText = "תאריך תרומה";
        }
    }
}
