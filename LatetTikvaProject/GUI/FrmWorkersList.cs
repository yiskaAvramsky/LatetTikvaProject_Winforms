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
    public partial class FrmWorkersList : Form
    {
        FrmAddW f;
        public FrmWorkersList()
        {
            InitializeComponent();
            dgvWL.DataSource = MyDB.Workers.GetList().Select(x=>new { x.IdWorker, x.lNameWorker, x.fNameWorker, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.IfPriceForTravel, x.priceForHour, x.dateOfBirth, x.dateBeginingWork,x.ThisPart.namePart}).ToList();
            dgvWL.Columns[0].HeaderText = "תעודת זהות";
            dgvWL.Columns[1].HeaderText = "שם משפחה";
            dgvWL.Columns[2].HeaderText = "שם פרטי";
            dgvWL.Columns[3].HeaderText = "עיר";
            dgvWL.Columns[4].HeaderText = "כתובת";
            dgvWL.Columns[5].HeaderText = "מספר בית";
            dgvWL.Columns[6].HeaderText = "האם שכר לנסיעות";
            dgvWL.Columns[7].HeaderText = "שכר לשעה";
            dgvWL.Columns[8].HeaderText = "ת.לידה";
            dgvWL.Columns[9].HeaderText = "ת.כניסה לעבודה";
            dgvWL.Columns[10].HeaderText = "תפקיד";
        }

       

        private void addW_Click(object sender, EventArgs e)
        {
            f = new FrmAddW();             
            f.ShowDialog();
            this.Show();
            dgvWL.DataSource = MyDB.Workers.GetList().Select(x => new { x.IdWorker, x.lNameWorker, x.fNameWorker, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.IfPriceForTravel, x.priceForHour, x.dateOfBirth, x.dateBeginingWork, x.ThisPart.namePart }).ToList();
        }

        private void delateW_Click(object sender, EventArgs e)
        {
            Worker w = MyDB.Workers.GetList().FirstOrDefault(x => x.IdWorker.ToString() == dgvWL.CurrentRow.Cells[0].Value.ToString());

            DialogResult r = MessageBox.Show("העובד שנבחר הוא: " + w.fNameWorker + " " + w.lNameWorker + " האם אתה בטוח שברצונך למוחקו", "מחיקת עובד", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MyDB.Workers.DeleteItem(w);
                MyDB.Workers.SaveChanges();

                dgvWL.DataSource = MyDB.Workers.GetList().Select(x => new { x.IdWorker, x.lNameWorker, x.fNameWorker, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.IfPriceForTravel, x.priceForHour, x.dateOfBirth, x.dateBeginingWork, x.ThisPart.namePart }).ToList();
            }
        }



        private void updateW_Click_1(object sender, EventArgs e)
        {
            Worker w = new Worker();
            foreach (var item in MyDB.Workers.GetList())
            {
                if (item.IdWorker.ToString() == dgvWL.CurrentRow.Cells[0].Value.ToString())
                    w = item;
            }
            FrmAddW f = new FrmAddW(w);           
            f.ShowDialog();
            this.Show();
            dgvWL.DataSource = MyDB.Workers.GetList().Select(x => new { x.IdWorker, x.lNameWorker, x.fNameWorker, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.IfPriceForTravel, x.priceForHour, x.dateOfBirth, x.dateBeginingWork, x.ThisPart.namePart }).ToList();
        }

        private void dgvWL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Worker w = new Worker();
            foreach (var item in MyDB.Workers.GetList())
            {
                if (item.IdWorker.ToString() == dgvWL.CurrentRow.Cells[0].Value.ToString())
                    w = item;
            }
            FrmAddW f = new FrmAddW(w);           
            f.ShowDialog();
            this.Show();
            dgvWL.DataSource = MyDB.Workers.GetList().Select(x => new { x.IdWorker, x.lNameWorker, x.fNameWorker, x.ThisCity.nameOfTown, x.address, x.numOfHome, x.IfPriceForTravel, x.priceForHour, x.dateOfBirth, x.dateBeginingWork, x.ThisPart.namePart }).ToList();
        }
    }
}
