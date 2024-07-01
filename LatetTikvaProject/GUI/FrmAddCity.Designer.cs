
namespace LatetTikvaProject.GUI
{
    partial class FrmAddCity
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNameTownToAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddTown = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNameTownToAdd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnAddTown);
            this.groupBox2.Location = new System.Drawing.Point(61, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(156, 105);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "הוספת עיר";
            // 
            // txtNameTownToAdd
            // 
            this.txtNameTownToAdd.Location = new System.Drawing.Point(20, 40);
            this.txtNameTownToAdd.Name = "txtNameTownToAdd";
            this.txtNameTownToAdd.Size = new System.Drawing.Size(109, 21);
            this.txtNameTownToAdd.TabIndex = 8;
            this.txtNameTownToAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameTownToAdd_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = " שם עיר";
            // 
            // btnAddTown
            // 
            this.btnAddTown.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddTown.Location = new System.Drawing.Point(38, 67);
            this.btnAddTown.Name = "btnAddTown";
            this.btnAddTown.Size = new System.Drawing.Size(75, 23);
            this.btnAddTown.TabIndex = 7;
            this.btnAddTown.Text = "אישור";
            this.btnAddTown.UseVisualStyleBackColor = false;
            this.btnAddTown.Click += new System.EventHandler(this.btnAddTown_Click);
            // 
            // FrmAddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 173);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmAddCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוםפת עיר";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNameTownToAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddTown;
    }
}