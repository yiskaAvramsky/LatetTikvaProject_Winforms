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
    public partial class FrmFindC : Form
    {
        Contributor c;
        Worker w;
        int help;
        public FrmFindC()
        {
            InitializeComponent();
            c = new Contributor();
            w = new Worker();
            help = 1;
            dgvFindC.DataSource = MyDB.Contributors.GetList().Where(x => x.Tellephon == txtTell.Text || x.AnotherTell == txtTell.Text).Select(x => new { x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.sumOfLastContribution, x.Tellephon, x.AnotherTell, x.IdContributor }).ToList();
            dgvFindC.Columns[0].HeaderText = "שם משפחה";
            dgvFindC.Columns[1].HeaderText = "שם פרטי";
            dgvFindC.Columns[2].HeaderText = "עיר מגורים";
            dgvFindC.Columns[3].HeaderText = "סך תרומה אחרונה";
            dgvFindC.Columns[4].HeaderText = "טלפון";
            dgvFindC.Columns[5].HeaderText = "טלפון נוסף";
            dgvFindC.Columns[6].Visible = false;
        }
        public FrmFindC(Worker currentW)
        {
            InitializeComponent();
            c = new Contributor();
            w = currentW;
            help = 2;
            dgvFindC.DataSource = MyDB.Contributors.GetList().Where(x => x.Tellephon == txtTell.Text || x.AnotherTell == txtTell.Text).Select(x => new { x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.sumOfLastContribution, x.Tellephon, x.AnotherTell, x.IdContributor }).ToList();
            dgvFindC.Columns[0].HeaderText = "שם משפחה";
            dgvFindC.Columns[1].HeaderText = "שם פרטי";
            dgvFindC.Columns[2].HeaderText = "עיר מגורים";
            dgvFindC.Columns[3].HeaderText = "סך תרומה אחרונה";
            dgvFindC.Columns[4].HeaderText = "טלפון";
            dgvFindC.Columns[5].HeaderText = "טלפון נוסף";
            dgvFindC.Columns[6].Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTell.Text == " ")
                MessageBox.Show("נא הקש מספר לאיתור!");
            if (help == 1)
            {
                dgvFindC.DataSource = MyDB.Contributors.GetList().Where(x => x.Tellephon == txtTell.Text || x.AnotherTell == txtTell.Text).Select(x => new { x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.sumOfLastContribution, x.Tellephon, x.AnotherTell, x.IdContributor }).ToList();
            }
            if(help==2)
            {
                dgvFindC.DataSource = MyDB.Contributors.GetList().Where(x=>x.idWorker==w.IdWorker).Where(x => x.Tellephon == txtTell.Text || x.AnotherTell == txtTell.Text).Select(x => new { x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.sumOfLastContribution, x.Tellephon, x.AnotherTell, x.IdContributor }).ToList();
            }
        }

        private void dgvFindC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var item in MyDB.Contributors.GetList())
            {
                if (item.IdContributor.ToString() == dgvFindC.CurrentRow.Cells[6].Value.ToString())
                    c = item;
                
            }
            w = MyDB.Workers.GetList().FirstOrDefault(x => x.IdWorker == 203882956);
            FrmUpdateDetailsCoAndCallNow f = new FrmUpdateDetailsCoAndCallNow(c,w);
            this.Hide();
            f.Show();
        }

        private void btnCleane_Click(object sender, EventArgs e)
        {
            txtTell.Text = "";
            dgvFindC.DataSource = MyDB.Contributors.GetList().Where(x => x.Tellephon == txtTell.Text || x.AnotherTell == txtTell.Text).Select(x => new { x.lNameOfContributor, x.fNameOfContributor, x.ThisCity.nameOfTown, x.sumOfLastContribution, x.Tellephon, x.AnotherTell, x.IdContributor }).ToList();
        }

        private void txtTell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }
    }
}
