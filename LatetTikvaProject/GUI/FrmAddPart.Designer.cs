
namespace LatetTikvaProject.GUI
{
    partial class FrmAddPart
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNamePartToAdd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnToAddP = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNamePartToAdd);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnToAddP);
            this.groupBox3.Location = new System.Drawing.Point(30, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(186, 109);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "הוספת תפקיד";
            // 
            // txtNamePartToAdd
            // 
            this.txtNamePartToAdd.Location = new System.Drawing.Point(38, 40);
            this.txtNamePartToAdd.Name = "txtNamePartToAdd";
            this.txtNamePartToAdd.Size = new System.Drawing.Size(109, 21);
            this.txtNamePartToAdd.TabIndex = 8;
            this.txtNamePartToAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamePartToAdd_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "שם תפקיד";
            // 
            // btnToAddP
            // 
            this.btnToAddP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnToAddP.Location = new System.Drawing.Point(56, 67);
            this.btnToAddP.Name = "btnToAddP";
            this.btnToAddP.Size = new System.Drawing.Size(75, 23);
            this.btnToAddP.TabIndex = 7;
            this.btnToAddP.Text = "אישור";
            this.btnToAddP.UseVisualStyleBackColor = false;
            this.btnToAddP.Click += new System.EventHandler(this.btnToAddP_Click);
            // 
            // FrmAddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 183);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmAddPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת תפקיד";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNamePartToAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnToAddP;
    }
}