
namespace LatetTikvaProject.GUI
{
    partial class FrmFindC
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
            this.dgvFindC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTell = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCleane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFindC
            // 
            this.dgvFindC.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvFindC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindC.Location = new System.Drawing.Point(39, 26);
            this.dgvFindC.Name = "dgvFindC";
            this.dgvFindC.Size = new System.Drawing.Size(481, 211);
            this.dgvFindC.TabIndex = 0;
            this.dgvFindC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindC_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "חפש לפי מספר טלפון";
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(235, 257);
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(121, 21);
            this.txtTell.TabIndex = 2;
            this.txtTell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTell_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOk.Location = new System.Drawing.Point(185, 255);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(31, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCleane
            // 
            this.btnCleane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCleane.Location = new System.Drawing.Point(39, 246);
            this.btnCleane.Name = "btnCleane";
            this.btnCleane.Size = new System.Drawing.Size(88, 40);
            this.btnCleane.TabIndex = 4;
            this.btnCleane.Text = "נקה חיפושים";
            this.btnCleane.UseVisualStyleBackColor = false;
            this.btnCleane.Click += new System.EventHandler(this.btnCleane_Click);
            // 
            // FrmFindC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 307);
            this.Controls.Add(this.btnCleane);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFindC);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmFindC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "איתור כרטיס";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFindC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTell;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCleane;
    }
}