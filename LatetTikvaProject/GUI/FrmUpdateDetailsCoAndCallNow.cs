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
    public partial class FrmUpdateDetailsCoAndCallNow : Form
    {
        Contributor c;
        Worker w;
        ListToTalk t;
        //Repelled r;
        bool flag = true;
        string n;
        int help;
        Talk tt;
        FrmPerformanceContributionInPast p;
        public FrmUpdateDetailsCoAndCallNow()
        {
            InitializeComponent();
            
        }
        public FrmUpdateDetailsCoAndCallNow(Contributor currentContributor, Worker currentW, ListToTalk cuurentT)//נכנס מהרשומות להתקשרות בכדי שיתעדכן סםטטום של השיחה 
        {
            InitializeComponent();
            help = 1;
            c= currentContributor;
            w = currentW;
            t = cuurentT;
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbC.DataSource = lstC;
            FillTxt();
            n = w.lNameWorker + " " + w.fNameWorker;
            dgvTalkInPast.DataSource = MyDB.Talks.GetList().Where(x => x.IdContributor.ToString() == this.txtId.Text).Select(x=>new {x.codeTalk,x.dateInPastOfTalk ,שעה= x.timeInPastOfTalk.ToShortTimeString(), x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker, x.ThisStatus.status, x.note }).OrderByDescending(x=>x.dateInPastOfTalk).OrderByDescending(x=>x.שעה).ToList();
            dgvTalkInPast.Columns[1].HeaderText = "תאריך טיפול";
            dgvTalkInPast.Columns[2].HeaderText = "שעת טיפול";
            dgvTalkInPast.Columns[3].HeaderText = "שם משפחה עובד";
            dgvTalkInPast.Columns[4].HeaderText = "שם פרטי עובד";
            dgvTalkInPast.Columns[5].HeaderText = "סטטוס";
            dgvTalkInPast.Columns[6].HeaderText = "הערות";
            dgvTalkInPast.Columns[0].Visible = false;
        }
        public FrmUpdateDetailsCoAndCallNow(Contributor currentContributor, Worker currentW/*, Repelled currentR*/)
        {
            InitializeComponent();
            help = 2;
            c = currentContributor;
            w = currentW;
            //r = currentR;
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbC.DataSource = lstC;
            FillTxt();
            n = w.lNameWorker + " " + w.fNameWorker;
            dgvTalkInPast.DataSource = MyDB.Talks.GetList().Where(x => x.IdContributor.ToString() == this.txtId.Text).Select(x => new { x.codeTalk, x.dateInPastOfTalk, שעה = x.timeInPastOfTalk.ToShortTimeString(), x.ThisWorker.lNameWorker, x.ThisWorker.fNameWorker, x.ThisStatus.status, x.note }).OrderByDescending(x => x.dateInPastOfTalk).OrderByDescending(x => x.שעה).ToList();
            dgvTalkInPast.Columns[1].HeaderText = "תאריך טיפול";
            dgvTalkInPast.Columns[2].HeaderText = "שעת טיפול";
            dgvTalkInPast.Columns[3].HeaderText = "שם משפחה עובד";
            dgvTalkInPast.Columns[4].HeaderText = "שם פרטי עובד";
            dgvTalkInPast.Columns[5].HeaderText = "סטטוס";
            dgvTalkInPast.Columns[6].HeaderText = "הערות";
            dgvTalkInPast.Columns[0].Visible = false;
        }
        public void FillContributor()
        {
            flag = true;
            errorProvider1.Clear();
            try { c.IdContributor = Convert.ToInt32(txtId.Text); }
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
            c.noteOnContribution = txtNote.Text;

        }

        public void FillTxt()
        {
            txtId.Text = c.IdContributor.ToString();
            txtLName.Text = c.lNameOfContributor.ToString();
            txtFName.Text = c.fNameOfContributor;
            txtAdress.Text = c.address;
            txtNumOfHome.Text = c.numOfHome.ToString();
            txtPhone.Text = c.Tellephon;
            txtAnotherP.Text = c.AnotherTell;
            txtMail.Text = c.Mail;
            cmbC.SelectedItem = MyDB.Towns.GetList().FirstOrDefault(x => x.codeTown == c.codeTown).nameOfTown;
            txtNote.Text = c.noteOnContribution;
        }
        public void FillContributorr()
        {
            flag = true;
            errorProvider1.Clear();
            try { c.IdContributor = Convert.ToInt32(txtId.Text); }
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
            c.noteOnContribution = txtNote.Text;

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

        private void inPast_Click(object sender, EventArgs e)
        {
            p = new FrmPerformanceContributionInPast(c);
            p.Show();

        }

        private void btnAnsered_Click(object sender, EventArgs e)
        {
            if (help == 1)
            {
                FrmResultOfCall f = new FrmResultOfCall(c, w, t);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else 
            {
                FrmResultOfCall f = new FrmResultOfCall(c, w);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnNoAnsered_Click(object sender, EventArgs e)
        {
            if (help == 1)
            {
                FrmCouseNoAnsered f = new FrmCouseNoAnsered(c, w, txtNote.Text, t);
                this.Hide();
                f.ShowDialog();
                this.Show();
                this.Close();
            }
            else
            {
                FrmCouseNoAnsered f = new FrmCouseNoAnsered(c, w, txtNote.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
                this.Close();
            }
        }

        private void FrmUpdateDetailsCoAndCallNow_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvTalkInPast_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var item in MyDB.Talks.GetList())
            {
                if (item.codeTalk.ToString() == dgvTalkInPast.CurrentRow.Cells[0].Value.ToString())
                    tt = item;
            }
            FrmDetailTa f = new FrmDetailTa(c,tt) ;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmListW f = new FrmListW(w);
            this.Close();
            f.Show();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
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
