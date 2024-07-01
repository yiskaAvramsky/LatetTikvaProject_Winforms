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
    public partial class FrmPerformanceContribution : Form
    {
        bool flag;
        Contributor c;
        Worker w;
        PerformanceContribution p;
        Contribution ccc;
        Talk t;
        DateTime d;
        public FrmPerformanceContribution()
        {
            InitializeComponent();
        }
        public FrmPerformanceContribution(PerformanceContribution currentP, Worker currentW,Contributor currentC)//עדכון תרומה
        {
            InitializeComponent();
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbC.DataSource = lstC;
            c = currentC;
            FillTxtt();
            p = currentP;
            w = currentW;            
            button1.Text = "עדכון תרומה";
            List<string> lst = MyDB.KindOfContributions.GetList().Select(x => x.nameKind).ToList();
            cmbKinsds.DataSource = lst;
            FillTxt();
        }
        public FrmPerformanceContribution(Contributor currentC, Worker currentW)
        {
            InitializeComponent();
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbC.DataSource = lstC;
            c = currentC;
            FillTxtt();
            w = currentW;
            p = new PerformanceContribution();
            txtId.Text = c.IdContributor.ToString();
            ccc = new Contribution();
            List<string> lst = MyDB.KindOfContributions.GetList().Select(x =>  x.nameKind ).ToList();
            cmbKinsds.DataSource = lst;
            t = new Talk();
            d = new DateTime();
            d = DateTime.Now;
        }
        public void FillPerformanceContrbution()
        {
            flag = true;
            p.sumOfContribution = Convert.ToInt32(txtsum.Text);
            p.wayPaying = txtWayOfPay.Text;
            p.numOfPaying = Convert.ToInt32(txtNumOfPaies.Text);
            p.IdContributor = Convert.ToInt32(txtId.Text);
            try { p.dateOfContribution = Convert.ToDateTime(txtDateOfContribution.Text).Date; }
            catch { errorProvider1.SetError(txtDateOfContribution, "התאריך אינן תקין"); flag = false; }
            p.codeKindOfContribution = MyDB.KindOfContributions.GetList().FirstOrDefault(x => x.nameKind == cmbKinsds.Text).codeKindOfContribution;
            if(p.dateOfContribution.AddDays(1)<DateTime.Now)
            {
                errorProvider1.SetError(txtDateOfContribution, "התאריך אינו תקין");
                flag = false;
            }
        }
        public void FillTxt()
        {
            txtId.Text = p.IdContributor.ToString();
            txtsum.Text = p.sumOfContribution.ToString();
            txtNumOfPaies.Text = p.numOfPaying.ToString();
            txtWayOfPay.Text = p.wayPaying.ToString();
            txtDateOfContribution.Text = p.dateOfContribution.ToString();
            cmbKinsds.SelectedItem = MyDB.KindOfContributions.GetList().FirstOrDefault(x => x.codeKindOfContribution == p.codeKindOfContribution).nameKind;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "עדכון תרומה") 
            {
                FillPerformanceContrbution();
                p.codePerformanceContribution = MyDB.PerformanceContributions.CodePerformanceContrbution();
                if (flag)
                {
                    foreach (var item in MyDB.ListToTalk.GetList().Where(x => x.IdWorker == c.idWorker))
                    {
                        if (item.IdContributor == c.IdContributor)
                        {
                            MyDB.ListToTalk.DeleteItem(item);
                            MyDB.ListToTalk.SaveChanges();
                        }
                    }
                    foreach (var item in MyDB.RepelledContriburors.GetList().Where(x => x.IdWorker == c.idWorker))
                    {
                        if (item.IdContributor == c.IdContributor)
                        {
                            MyDB.RepelledContriburors.DeleteItem(item);
                            MyDB.RepelledContriburors.SaveChanges();
                        }
                    }
                    c.idWorker = 203882956;
                    c.noteOnContribution = txtCouse.Text;
                    c.sumOfLastContribution = p.sumOfContribution;
                    c.dateOfLastContribution = p.dateOfContribution;
                    MyDB.Contributors.UpdateItem(c);
                    MyDB.Contributors.SaveChanges();
                    MyDB.PerformanceContributions.AddItem(p);
                    MyDB.PerformanceContributions.SaveChanges();
                    FillTalk();
                    MyDB.Talks.AddItem(t);
                    MyDB.Talks.SaveChanges();
                    FillDidWorker();
                    MyDB.Contributions.AddItem(ccc);
                    MyDB.Contributions.SaveChanges();

                    MessageBox.Show("התרומה התווספה בהצלחה!");
                    this.Close();
                }
            }
            if (button1.Text == "עדכון תרומה") 
            {
                FillPerformanceContrbution();
                if (flag)
                {
                    foreach (var item in MyDB.Contributions.GetList())
                    {
                        if (item.codePerformanceContribution.ToString() == p.codePerformanceContribution.ToString())
                            ccc = item;
                    }
                    int b = Convert.ToInt32(p.sumOfContribution * 0.1);
                    ccc.bonus = b;
                    MyDB.Contributions.UpdateItem(ccc);
                    MyDB.Contributions.SaveChanges();
                    c.noteOnContribution = txtCouse.Text;
                    c.dateOfLastContribution = Convert.ToDateTime(txtDateOfContribution.Text);
                    c.sumOfLastContribution = Convert.ToInt32(txtsum.Text);
                    MyDB.Contributors.UpdateItem(c);
                    MyDB.Contributors.SaveChanges();
                    MyDB.PerformanceContributions.UpdateItem(p);
                    MyDB.PerformanceContributions.SaveChanges();
                    MessageBox.Show("השינויים נשמרו בהצלחה!");
                    this.Close();
                }
            }
        }
        public void FillTalk()
        {
            t.codeTalk = MyDB.Talks.CodeTalk();
            t.dateInPastOfTalk = Convert.ToDateTime(d.ToShortDateString());
            t.timeInPastOfTalk = Convert.ToDateTime(d.ToLongTimeString());
            t.IdWorker = w.IdWorker;
            t.IdContributor = c.IdContributor;
            t.note = txtCouse.Text;
            t.codeStatus = 2;
        }
        public void FillDidWorker()
        {
            ccc.codeContribution = MyDB.Contributions.CodeContrbution();
            ccc.IdWorker = w.IdWorker;
            ccc.codePerformanceContribution = p.codePerformanceContribution;
            int b = Convert.ToInt32(p.sumOfContribution * 0.1);
            ccc.bonus = b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPerformanceContributionInPast p = new FrmPerformanceContributionInPast(c);
            p.Show();
        }
        public void FillTxtt()
        {
            textBox1.Text = c.IdContributor.ToString();
            txtLName.Text = c.lNameOfContributor.ToString();
            txtFName.Text = c.fNameOfContributor;
            txtAdress.Text = c.address;
            txtNumOfHome.Text = c.numOfHome.ToString();
            txtPhone.Text = c.Tellephon;
            txtAnotherP.Text = c.AnotherTell;
            txtMail.Text = c.Mail;
            cmbC.SelectedItem = MyDB.Towns.GetList().FirstOrDefault(x => x.codeTown == c.codeTown).nameOfTown;
             
        }
        public void FillContributorr()
        {
            flag = true;
            errorProvider1.Clear();
            try { c.IdContributor = Convert.ToInt32(textBox1.Text); }
            catch { errorProvider1.SetError(txtId, "ת.ז. אינה תקינה"); flag = false; }
            c.lNameOfContributor = txtLName.Text;
            c.fNameOfContributor = txtFName.Text;
            c.address = txtAdress.Text;
            c.numOfHome = Convert.ToInt32(txtNumOfHome.Text);
            try { c.Tellephon = txtPhone.Text; }
            catch { errorProvider1.SetError(txtPhone, "טלפון אינו תקין"); flag = false; }
            try { c.AnotherTell = txtAnotherP.Text; }
            catch { errorProvider1.SetError(txtAnotherP, "טלפון אינו תקין"); flag = false; }
            try { c.Mail = txtMail.Text; }
            catch { errorProvider1.SetError(txtMail, "המייל אינו תקין"); flag = false; }
            c.codeTown = MyDB.Towns.GetList().First(x => x.nameOfTown == cmbC.SelectedItem.ToString()).codeTown;
            c.codeStatus = 1;
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            FillContributorr();
            if (flag)
            {
                MyDB.Contributors.UpdateItem(c);
                MyDB.Contributors.SaveChanges();

                MessageBox.Show("השינויים נשמרו בהצלחה!");

            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void txtsum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void txtNumOfPaies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void txtWayOfPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }

        private void cmbKinsds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void txtNumOfHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void txtAnotherP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }

        private void txtAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }

        private void cmbC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
