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
    public partial class FrmUpdateContributor : Form
    {
        string n;
        Contributor c;
        bool flag = true;
        public FrmUpdateContributor(Contributor currentC)
        {
            InitializeComponent();
            c = currentC;
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbC.DataSource = lstC;
            FillTxt();
        }
        public FrmUpdateContributor(Contributor currentC,string nn)
        {
            n = nn;
            InitializeComponent();
            c = currentC;
            txtDateOfLastContribution.Visible = false;
            txtSumOfLastContribution.Visible = false;
            txtNote.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbC.DataSource = lstC;
            FillTxt();
        }
        public void FillTxt()
        {
            txtId.Text = c.IdContributor.ToString();
            txtLName.Text = c.lNameOfContributor.ToString();
            txtFName.Text = c.fNameOfContributor;
            txtAdress.Text = c.address;
            txtNunOfHome.Text = c.numOfHome.ToString();
            txtPhone.Text = c.Tellephon;
            txtAnotherP.Text = c.AnotherTell;
            txtMail.Text = c.Mail;
            cmbC.SelectedItem = MyDB.Towns.GetList().FirstOrDefault(x => x.codeTown == c.codeTown).nameOfTown;
            txtDateOfLastContribution.Text =c.dateOfLastContribution.ToString();
            txtSumOfLastContribution.Text = c.sumOfLastContribution.ToString();
            txtNote.Text = c.noteOnContribution;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillContributor();
            if (flag)
            {
                MyDB.Contributors.UpdateItem(c);
                MyDB.Contributors.SaveChanges();

                MessageBox.Show("השינויים נשמרו בהצלחה!");
                this.Close();
            }
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
            c.numOfHome = Convert.ToInt32(txtNunOfHome.Text);
            try { c.Tellephon = txtPhone.Text; }
            catch { errorProvider1.SetError(txtPhone, "טלפון אינו תקין"); flag = false; }
            try { c.AnotherTell = txtAnotherP.Text; }
            catch { errorProvider1.SetError(txtAnotherP, "טלפון אינו תקין"); flag = false; }
            try { c.Mail = txtMail.Text; }
            catch { errorProvider1.SetError(txtMail, "המייל אינו תקין"); flag = false; }
            c.codeTown = MyDB.Towns.GetList().First(x => x.nameOfTown == cmbC.SelectedItem.ToString()).codeTown;
            c.codeStatus = c.codeStatus; ;
            //c.idWorker = c.idWorker;
            c.sumOfLastContribution = Convert.ToInt32(txtSumOfLastContribution.Text);
            c.dateOfLastContribution = Convert.ToDateTime(txtDateOfLastContribution.Text);
            c.noteOnContribution = txtNote.Text;
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            FrmAddCity f = new FrmAddCity();
            f.ShowDialog();
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbC.DataSource = lstC;
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void txtNunOfHome_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSumOfLastContribution_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }

        private void txtAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
             
        }
    }
}
