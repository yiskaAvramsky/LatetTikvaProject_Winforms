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
    public partial class FrmCondition : Form
    {
        string s;
        int sum=0;
        public FrmCondition()
        {
            InitializeComponent();
            foreach (var item in MyDB.Contributions.GetList().Where(x=>x.ThisPerformanceContribution.dateOfContribution==DateTime.Now.Date))
            {
                sum += item.ThisPerformanceContribution.sumOfContribution;
            }
            btnC.Text += sum.ToString();
        }

        private void btnInsertToW_Click(object sender, EventArgs e)
        {
            FrmInsertToWprCon f = new FrmInsertToWprCon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnConditionOfW_Click(object sender, EventArgs e)
        {
            FrmConditionOfWorker f = new FrmConditionOfWorker();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTreatOnNoIntersted f = new FrmTreatOnNoIntersted();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s = "נקה רשומות";
            FrmConditionOfWorker f = new FrmConditionOfWorker(s);
            f.Show();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            FrmPerformanceCToPay f = new FrmPerformanceCToPay();
            
            f.ShowDialog();
            this.Show();
        }
    }
}
