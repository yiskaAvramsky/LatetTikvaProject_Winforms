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
    public partial class FrmPrincipal : Form
    {
        FrmWorkersList fWL;
        FrmListContibutors fCL;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void workers_Click(object sender, EventArgs e)
        {
            fWL = new FrmWorkersList();
            this.Hide();
            fWL.ShowDialog();
            this.Show();
        }

        private void contributors_Click(object sender, EventArgs e)
        {
            fCL = new FrmListContibutors();
            this.Hide();
            fCL.ShowDialog();
            this.Show();
        }

        private void findCard_Click(object sender, EventArgs e)
        {
            FrmFindC f = new FrmFindC();
            f.Show();
        }

        private void condituon_Click(object sender, EventArgs e)
        {
            FrmCondition f = new FrmCondition();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
