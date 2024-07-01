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
    public partial class FrmAddCity : Form
    {
        public FrmAddCity()
        {
            InitializeComponent();
           
        }

        private void btnAddTown_Click(object sender, EventArgs e)
        {

            Town t = new Town() { nameOfTown = txtNameTownToAdd.Text, codeTown = MyDB.Towns.CodeTown() };
            MyDB.Towns.AddItem(t);
            MyDB.Towns.SaveChanges();

            MessageBox.Show("העיר נוספה בהצלחה!");
            this.Close();
           
        }

        private void txtNameTownToAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }
    }
}
