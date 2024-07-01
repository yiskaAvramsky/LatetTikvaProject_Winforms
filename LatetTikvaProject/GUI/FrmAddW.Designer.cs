
namespace LatetTikvaProject.GUI
{
    partial class FrmAddW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNumOfHome = new System.Windows.Forms.TextBox();
            this.txtPayForHour = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDateBiginingWork = new System.Windows.Forms.MaskedTextBox();
            this.txtDateBirth = new System.Windows.Forms.MaskedTextBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.ifPayOfTravels = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ת.ז";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "שם משפחה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "שם פרטי";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "כתובת";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "מספר בית";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ת.לידה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "עיר";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "תפקיד";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "שכר לשעה";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(40, 42);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(101, 21);
            this.txtLName.TabIndex = 1;
            this.txtLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLName_KeyPress);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(40, 72);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(101, 21);
            this.txtFName.TabIndex = 1;
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(40, 99);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(101, 21);
            this.txtAdress.TabIndex = 1;
            this.txtAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdress_KeyPress);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(40, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(101, 21);
            this.txtId.TabIndex = 1;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtNumOfHome
            // 
            this.txtNumOfHome.Location = new System.Drawing.Point(40, 127);
            this.txtNumOfHome.Name = "txtNumOfHome";
            this.txtNumOfHome.Size = new System.Drawing.Size(101, 21);
            this.txtNumOfHome.TabIndex = 1;
            this.txtNumOfHome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumOfHome_KeyPress);
            // 
            // txtPayForHour
            // 
            this.txtPayForHour.Location = new System.Drawing.Point(39, 264);
            this.txtPayForHour.Name = "txtPayForHour";
            this.txtPayForHour.Size = new System.Drawing.Size(101, 21);
            this.txtPayForHour.TabIndex = 1;
            this.txtPayForHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayForHour_KeyPress);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(40, 156);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(101, 21);
            this.cmbCity.TabIndex = 2;
            this.cmbCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCity_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "ת.תחילת עבודה";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDateBiginingWork);
            this.groupBox1.Controls.Add(this.txtDateBirth);
            this.groupBox1.Controls.Add(this.btnAddCity);
            this.groupBox1.Controls.Add(this.btnAddPart);
            this.groupBox1.Controls.Add(this.cmbPart);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.txtNumOfHome);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.txtPayForHour);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ifPayOfTravels);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(255, 384);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי עובד";
            // 
            // txtDateBiginingWork
            // 
            this.txtDateBiginingWork.Location = new System.Drawing.Point(39, 318);
            this.txtDateBiginingWork.Mask = "00/00/0000";
            this.txtDateBiginingWork.Name = "txtDateBiginingWork";
            this.txtDateBiginingWork.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateBiginingWork.Size = new System.Drawing.Size(100, 21);
            this.txtDateBiginingWork.TabIndex = 7;
            this.txtDateBiginingWork.ValidatingType = typeof(System.DateTime);
            // 
            // txtDateBirth
            // 
            this.txtDateBirth.Location = new System.Drawing.Point(39, 291);
            this.txtDateBirth.Mask = "00/00/0000";
            this.txtDateBirth.Name = "txtDateBirth";
            this.txtDateBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateBirth.Size = new System.Drawing.Size(100, 21);
            this.txtDateBirth.TabIndex = 7;
            this.txtDateBirth.ValidatingType = typeof(System.DateTime);
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddCity.Location = new System.Drawing.Point(40, 183);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(100, 21);
            this.btnAddCity.TabIndex = 6;
            this.btnAddCity.Text = "הוספת עיר";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddPart.Location = new System.Drawing.Point(39, 237);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(100, 23);
            this.btnAddPart.TabIndex = 6;
            this.btnAddPart.Text = "הוספת תפקיד";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // cmbPart
            // 
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(39, 210);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(101, 21);
            this.cmbPart.TabIndex = 5;
            this.cmbPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPart_KeyPress);
            // 
            // ifPayOfTravels
            // 
            this.ifPayOfTravels.AutoSize = true;
            this.ifPayOfTravels.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ifPayOfTravels.Location = new System.Drawing.Point(40, 353);
            this.ifPayOfTravels.Name = "ifPayOfTravels";
            this.ifPayOfTravels.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ifPayOfTravels.Size = new System.Drawing.Size(141, 18);
            this.ifPayOfTravels.TabIndex = 4;
            this.ifPayOfTravels.Text = "האם תשלום לנסיעות";
            this.ifPayOfTravels.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(84, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "הוספת עובד";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 449);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmAddW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "פרטי עובד";
            this.Load += new System.EventHandler(this.FrmAddW_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNumOfHome;
        private System.Windows.Forms.TextBox txtPayForHour;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ifPayOfTravels;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.MaskedTextBox txtDateBiginingWork;
        private System.Windows.Forms.MaskedTextBox txtDateBirth;
    }
}