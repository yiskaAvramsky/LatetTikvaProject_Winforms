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
    public partial class FrmDetailTa : Form
    {
        Contributor c;
        Talk tt;
        public FrmDetailTa(Contributor contribut, Talk currentt)
        {
            InitializeComponent();
            c = contribut;
            tt = currentt;
            label9.Text = c.lNameOfContributor;
            label10.Text = c.fNameOfContributor;
            label11.Text = c.Tellephon;
            label12.Text = c.AnotherTell;
            label13.Text = MyDB.Talks.GetList().FirstOrDefault(x => x.codeTalk == tt.codeTalk).dateInPastOfTalk.ToShortDateString().ToString();
            label14.Text = MyDB.Talks.GetList().FirstOrDefault(x => x.codeTalk == tt.codeTalk).timeInPastOfTalk.ToShortTimeString().ToString();
            label15.Text = MyDB.Talks.GetList().FirstOrDefault(x => x.codeTalk == tt.codeTalk).ThisWorker.lNameWorker.ToString();
            textBox1.Text= MyDB.Talks.GetList().FirstOrDefault(x => x.codeTalk == tt.codeTalk).note;
        }

        private void FrmDetailTa_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
