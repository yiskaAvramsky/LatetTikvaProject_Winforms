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
    public partial class FrmAddW : Form
    {
        Worker w;
        Worker wHelp;
        FormStatus f;
        bool flag = true;
        public FrmAddW()
        {
            InitializeComponent();
            w = new Worker();
            f = FormStatus.add;
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown ).ToList();
            cmbCity.DataSource = lstC;
            cmbCity.SelectedItem = null;
            List<string> lst = MyDB.Parts.GetList().Select(x => x.namePart).ToList();
            cmbPart.DataSource = lst;
            cmbPart.SelectedItem= null;
        }
        public FrmAddW(Worker currentWorker)
        {
            InitializeComponent();
            w = currentWorker;
            f = FormStatus.update;
            btnAdd.Text = "עדכון פרטי עובד";
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbCity.DataSource = lstC;
            List<string> lst = MyDB.Parts.GetList().Select(x => x.namePart).ToList();
            cmbPart.DataSource = lst;
            FillTxt();
        }

        public void FillTxt()
        {
            txtId.Text = w.IdWorker.ToString();
            txtLName.Text = w.lNameWorker.ToString();
            txtFName.Text = w.fNameWorker;
            txtAdress.Text = w.address;
            txtNumOfHome.Text = w.numOfHome.ToString();
            cmbPart.SelectedItem = MyDB.Parts.GetList().FirstOrDefault(x => x.codePart == w.codePart).namePart;
            cmbCity.SelectedItem = MyDB.Towns.GetList().FirstOrDefault(x => x.codeTown == w.codeTown).nameOfTown;
            txtPayForHour.Text = w.priceForHour.ToString();
            txtDateBirth.Text = w.dateOfBirth.ToString();
            txtDateBiginingWork.Text = w.dateBeginingWork.ToString();
            ifPayOfTravels.Checked = w.IfPriceForTravel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (f == FormStatus.add)
            {
                wHelp = MyDB.Workers.GetList().FirstOrDefault(x => x.IdWorker.ToString() == txtId.Text);
                if (wHelp != null)
                {
                    MessageBox.Show("העובד כבר קיים במערכת!");
                    flag = false;

                }
                if (wHelp == null)
                {
                    wHelp = MyDB.Workers.GetList().FirstOrDefault(x =>(x.lNameWorker == txtLName.Text&&x.fNameWorker==txtFName.Text));
                    if (wHelp != null)
                    {
                        MessageBox.Show("קיים במערכת עובד עם שם זהה");
                        flag = false;
                    }
                }
                wHelp = MyDB.Workers.GetList().FirstOrDefault(x => x.IdWorker.ToString() == txtId.Text);
                wHelp = MyDB.Workers.GetList().FirstOrDefault(x => x.lNameWorker == txtLName.Text);
                if (wHelp == null)
                    flag = true;
                
            }

            if (f == FormStatus.add&&(flag))
            {
               
                FillWorker();
                if(flag)
                { 
                  MyDB.Workers.AddItem(w);
                  MyDB.Workers.SaveChanges();

                  MessageBox.Show("העובד התוסף בהצלחה!");
                  this.Close();
                }
            }
            if (f == FormStatus.update)
            {

                FillWorker();
                if (flag)
                {
                    MyDB.Workers.UpdateItem(w);
                    MyDB.Workers.SaveChanges();

                    MessageBox.Show("השינויים נשמרו בהצלחה!");
                    this.Close();
                }
            }
           
        }
        public void FillWorker()
        {
            flag = true;
            errorProvider1.Clear();
            try { w.IdWorker = Convert.ToInt32(txtId.Text); }
            catch { errorProvider1.SetError(txtId, "ת.ז אינה תקינה"); flag = false; }
            w.lNameWorker = txtLName.Text;
            if( txtLName.Text.Length<=1)
            {
                errorProvider1.SetError(txtLName, "השם אינו תקין"); flag = false;
            }
            w.fNameWorker = txtFName.Text;
            if (txtFName.Text.Length <= 1)
            {
                errorProvider1.SetError(txtFName, "השם אינו תקין"); flag = false;
            }
            w.address = txtAdress.Text;
            w.numOfHome = Convert.ToInt32(txtNumOfHome.Text);
            //foreach (var item in MyDB.Parts.GetList())
            //{
            //   if(item.namePart==cmbPart.Text)
            //        w.codePart = MyDB.Parts.GetList().First(x => x.namePart == cmbPart.SelectedItem.ToString()).codePart;
            //   else
            //        errorProvider1.SetError(cmbPart, "התפקיד אינו נמצע במערכת אנא הוסף"); flag = false;
            //}
            w.codePart = MyDB.Parts.GetList().First(x => x.namePart == cmbPart.SelectedItem.ToString()).codePart;
            w.IfPriceForTravel =ifPayOfTravels.Checked;
            w.priceForHour = Convert.ToInt32(txtPayForHour.Text);
            w.codeTown = MyDB.Towns.GetList().First(x => x.nameOfTown == cmbCity.SelectedItem.ToString()).codeTown;
            try { w.dateOfBirth = Convert.ToDateTime(txtDateBirth.Text); }
            catch { errorProvider1.SetError(txtDateBirth, "התאריך אינו תקין"); flag = false; }
            try { w.dateBeginingWork = Convert.ToDateTime(txtDateBiginingWork.Text); }
            catch { errorProvider1.SetError(txtDateBiginingWork, "התאריך אינו תקין"); flag = false; }
            if (w.dateOfBirth.AddDays(43800) <= DateTime.Now || w.dateOfBirth.AddYears(14)>=DateTime.Now.Date)
            {
                errorProvider1.SetError(txtDateBirth, "התאריך לידה אינו תקין");
                flag = false;
            }
            if (w.dateBeginingWork<=w.dateOfBirth.AddYears(14))
            {
                errorProvider1.SetError(txtDateBiginingWork, "התאריך תחילת עבודה אינו תקין");
                flag = false;
            }

        }
        private void btnAddCity_Click(object sender, EventArgs e)
        {
            FrmAddCity f = new FrmAddCity();
            f.ShowDialog();
            List<string> lstC = MyDB.Towns.GetList().Select(x => x.nameOfTown).ToList();
            cmbCity.DataSource = lstC;
        }
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            FrmAddPart f = new FrmAddPart();
            f.ShowDialog();
            List<string> lst = MyDB.Parts.GetList().Select(x => x.namePart).ToList();
            cmbPart.DataSource = lst;

        }

        private void FrmAddW_Load(object sender, EventArgs e)
        {

        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e .KeyChar != '\b'))
                e.Handled = true;
         }

        private void txtNumOfHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void txtPayForHour_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbCity_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }

        private void cmbPart_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }
    }
}
