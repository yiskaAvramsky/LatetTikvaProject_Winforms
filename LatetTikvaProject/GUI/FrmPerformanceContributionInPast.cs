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
    public partial class FrmPerformanceContributionInPast : Form
    {
        public FrmPerformanceContributionInPast()
        {
            InitializeComponent();
        }
        public FrmPerformanceContributionInPast(Contributor c)
        {
            InitializeComponent();
            dgvPerformanceControbutionInPast.DataSource = MyDB.PerformanceContributions.GetList().Where(x=>x.IdContributor==c.IdContributor).Select(x => new { x.codePerformanceContribution, x.dateOfContribution, x.sumOfContribution, x.wayPaying, x.numOfPaying, x.ThisKindOfContribution.nameKind }).OrderBy(x=>x.dateOfContribution).OrderByDescending(x => x.dateOfContribution).ToList();
            dgvPerformanceControbutionInPast.Columns[0].HeaderText = "קוד תרומה";
            dgvPerformanceControbutionInPast.Columns[0].Visible = false;
            dgvPerformanceControbutionInPast.Columns[1].HeaderText = "תאריך תרומה";
            dgvPerformanceControbutionInPast.Columns[2].HeaderText = "סכום תרומה";
            dgvPerformanceControbutionInPast.Columns[3].HeaderText = "אופן תשלום";
            dgvPerformanceControbutionInPast.Columns[4].HeaderText = "מספר תשלומים";
            dgvPerformanceControbutionInPast.Columns[5].HeaderText = "סוג תרומה";
            label1.Text = "תרומות בעבר של: "+c.lNameOfContributor+" "+c.fNameOfContributor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
