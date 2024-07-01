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
    public partial class FrmContributionToday : Form
    {
        Worker w;
        PerformanceContribution p;
        Contributor c;
        public FrmContributionToday(Worker currentW)
        {
            InitializeComponent();
            w = currentW;
            dgvConToday.DataSource = MyDB.Contributions.GetList().Where(x => x.IdWorker == w.IdWorker).Where(x => x.ThisPerformanceContribution.dateOfContribution == DateTime.Now.Date).Select(x => new { x.ThisPerformanceContribution.ThisContributor.lNameOfContributor, x.ThisPerformanceContribution.ThisContributor.fNameOfContributor, x.ThisPerformanceContribution.sumOfContribution, x.bonus, x.ThisPerformanceContribution.codePerformanceContribution,x.codeContribution}).ToList();
            dgvConToday.Columns[0].HeaderText = "שם משפחה תורם";
            dgvConToday.Columns[1].HeaderText = "שם פרטי תורם";
            dgvConToday.Columns[2].HeaderText = "סכום תרומה";
            dgvConToday.Columns[3].HeaderText = "בונוס מתרומה זו";
            dgvConToday.Columns[4].Visible = false;
            dgvConToday.Columns[5].Visible = false;
        }

        private void dgvConToday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p = new PerformanceContribution();
            foreach (var item in MyDB.PerformanceContributions.GetList())
            {
                if (item.codePerformanceContribution.ToString() == dgvConToday.CurrentRow.Cells[4].Value.ToString())
                {
                    p = item;
                }
            }
            foreach (var item in MyDB.Contributors.GetList())
            {
                if (item.IdContributor == p.IdContributor)
                    c = item;
            }
            FrmPerformanceContribution f = new FrmPerformanceContribution(p,w,c);
            this.Hide();
            f.ShowDialog();
            dgvConToday.DataSource = MyDB.Contributions.GetList().Where(x => x.IdWorker == w.IdWorker).Where(x => x.ThisPerformanceContribution.dateOfContribution == DateTime.Now.Date).Select(x => new { x.ThisPerformanceContribution.ThisContributor.lNameOfContributor, x.ThisPerformanceContribution.ThisContributor.fNameOfContributor, x.ThisPerformanceContribution.sumOfContribution, x.bonus, x.ThisPerformanceContribution.codePerformanceContribution, x.codeContribution }).ToList();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvConToday_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            p = new PerformanceContribution();
            foreach (var item in MyDB.PerformanceContributions.GetList())
            {
                if (item.codePerformanceContribution.ToString() == dgvConToday.CurrentRow.Cells[4].Value.ToString())
                {
                    p = item;
                }
            }
            foreach (var item in MyDB.Contributors.GetList())
            {
                if (item.IdContributor == p.IdContributor)
                    c = item;
            }
            FrmPerformanceContribution f = new FrmPerformanceContribution(p, w, c);
            this.Hide();
            f.ShowDialog();
            dgvConToday.DataSource = MyDB.Contributions.GetList().Where(x => x.IdWorker == w.IdWorker).Where(x => x.ThisPerformanceContribution.dateOfContribution == DateTime.Now.Date).Select(x => new { x.ThisPerformanceContribution.ThisContributor.lNameOfContributor, x.ThisPerformanceContribution.ThisContributor.fNameOfContributor, x.ThisPerformanceContribution.sumOfContribution, x.bonus, x.ThisPerformanceContribution.codePerformanceContribution, x.codeContribution }).ToList();
            this.Show();
        }
    }
}
