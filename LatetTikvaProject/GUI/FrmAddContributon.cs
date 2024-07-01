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
    public partial class FrmAddContributon : Form
    {
        Contributor c;
        Contributor cHelp;
        FormStatus f;
        ListToTalk ltotalk;
        int help;
        
        
        bool flag = true;
         
        public FrmAddContributon()//הוספה ממנהל
        {
            InitializeComponent();
            c = new Contributor();
            c.idWorker = 203882956;
            f = FormStatus.add;
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbC.DataSource = lstC;
            cmbC.SelectedItem = null;
        }
        public FrmAddContributon(int cuurentIdWorker)//הוספה מעובד
        {
            InitializeComponent();
            c = new Contributor();
            c.idWorker = cuurentIdWorker;
            f = FormStatus.add;
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbC.DataSource = lstC;
            cmbC.SelectedItem = null;
            ltotalk = new ListToTalk();
            help = 1;
        }
        public FrmAddContributon(Contributor currentContributor)//עדכון
        {
            InitializeComponent();
            btnAdd.Text = "עדכון פרטי תורם";
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            f = FormStatus.update;
            cmbC.DataSource = lstC;
            c = currentContributor;
            FillTxt();
        }

        private void btnAdd_Click(object sender, EventArgs e)//הוספה ןעדכון
        {
            if (f == FormStatus.add)
            {
                cHelp = MyDB.Contributors.GetList().FirstOrDefault(x => x.IdContributor.ToString() == txtId.Text);
                if (cHelp != null)
                {
                    MessageBox.Show("התורם כבר קיים במערכת!");
                    flag = false;

                }
                cHelp = MyDB.Contributors.GetList().FirstOrDefault(x => x.IdContributor.ToString() == txtId.Text);
                if (cHelp == null)
                    flag = true;
            }
            if (f==FormStatus.add && (flag))
            {
                FillContributor();
                c.codeStatus = 1;
                if (flag)
                {
                    MyDB.Contributors.AddItem(c);
                    MyDB.Contributors.SaveChanges();
                    if (help == 1)
                    {
                        FiiListToTalk();
                        MyDB.ListToTalk.AddItem(ltotalk);
                        MyDB.ListToTalk.SaveChanges();
                    }
                    MessageBox.Show("התורם התוסף בהצלחה!");
                    this.Close();
                }
            }
            if(f==FormStatus.update)
            {
               
                FillContributor();
                c.idWorker = c.idWorker;
                c.codeStatus = c.codeStatus;
                if (flag)
                {
                    MyDB.Contributors.UpdateItem(c);
                    MyDB.Contributors.SaveChanges();

                    MessageBox.Show("השינויים נשמרו בהצלחה!");
                    this.Close();
                }
            }
        }
        public void FiiListToTalk()
        {
            ltotalk.codeListToTalk = MyDB.ListToTalk.CodeListsToTalk();
            ltotalk.IdWorker = c.idWorker;
            ltotalk.IdContributor = Convert.ToInt32(txtId.Text);
            ltotalk.codeStatus = 1;
        }
        public void FillContributor()
        {
            flag = true;
            errorProvider1.Clear();
            try { c.IdContributor = Convert.ToInt32(txtId.Text);}
            catch { errorProvider1.SetError(txtId, "ת.ז. אינה תקינה"); flag = false; }
            c.lNameOfContributor = txtLName.Text;
            if (txtLName.Text.Length <= 1)
            {
                errorProvider1.SetError(txtLName, "השם אינו תקין"); flag = false;
            }
            c.fNameOfContributor = txtFName.Text;
            if (txtFName.Text.Length <= 1)
            {
                errorProvider1.SetError(txtFName, "השם אינו תקין"); flag = false;
            }
            c.address = txtAdress.Text;
            c.numOfHome = Convert.ToInt32(txtNunOfHome.Text);
            try { c.Tellephon = txtPhone.Text; }
            catch { errorProvider1.SetError(txtPhone, "טלפון אינו תקין"); flag = false; }
            try { c.AnotherTell = txtAnotherP.Text; }
            catch { errorProvider1.SetError(txtAnotherP, "טלפון אינו תקין"); flag = false; }
            try { c.Mail = txtMail.Text; }
            catch { errorProvider1.SetError(txtMail, "המייל אינו תקין"); flag = false; }
            c.codeTown = MyDB.Towns.GetList().First(x => x.nameOfTown == cmbC.SelectedItem.ToString()).codeTown;
            c.sumOfLastContribution = 0;
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

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cmbC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }
    }
}
