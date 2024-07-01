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
    public partial class FrmAddPart : Form
    {
        public FrmAddPart()
        {
            InitializeComponent();
        }

        private void btnToAddP_Click(object sender, EventArgs e)
        {
            Part p = new Part() { namePart = txtNamePartToAdd.Text, codePart = MyDB.Parts.CodePart() };
            MyDB.Parts.AddItem(p);
            MyDB.Parts.SaveChanges();

            MessageBox.Show("התפקיד נוסף בהצלחה!");
            this.Close();
        }

        private void txtNamePartToAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()) && !Validation.IsEnglish(e.KeyChar.ToString()) && (e.KeyChar != '\b') && (e.KeyChar != ' '))
                e.Handled = true;
        }
    }
}
