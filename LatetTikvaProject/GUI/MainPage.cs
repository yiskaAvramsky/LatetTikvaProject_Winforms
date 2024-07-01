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
    public partial class MainPage : Form
    {
        FrmListW fW;
        Worker w;
        FrmPrincipal fP;
        public MainPage()
        {
            InitializeComponent();
             
        }

        private void enterP_Click(object sender, EventArgs e)
        {
            txtP.Visible = true;
            okP.Visible = true;
            label2.Visible = true;
            txtW.Visible = false;
            okW.Visible = false;
            label1.Visible = false;
            txtW.Text = "";
        }

        private void enterW_Click(object sender, EventArgs e)
        {
            txtW.Visible = true;
            okW.Visible = true;
            label1.Visible = true;
            label2.Visible = false;
            txtP.Visible = false;
            okP.Visible = false;
            txtP.Text = "";
        }

        private void okW_Click_1(object sender, EventArgs e)
        {
          
            w = MyDB.Workers.GetList().FirstOrDefault(x => x.IdWorker.ToString() == txtW.Text);
            if (w != null)
            {
                fW = new FrmListW(w);
                fW.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("תעודת הזהות אינה מופיעה במערכת, נא הקש שוב");
                txtW.Text = "";
            }
        }

        private void okP_Click(object sender, EventArgs e)
        {
            if(txtP.Text!=null&&txtP.Text=="1212")
            {
                fP = new FrmPrincipal();
                fP.Show();
            }
            else
            {
                MessageBox.Show("הסיסמא שהקשת שגויה");
                txtP.Text = "";
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()) && (e.KeyChar != '\b'))
                e.Handled = true;
        }
    }
     
}
