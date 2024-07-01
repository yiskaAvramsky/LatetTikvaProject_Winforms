
namespace LatetTikvaProject.GUI
{
    partial class FrmListContibutors
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
            this.dgvListC = new System.Windows.Forms.DataGridView();
            this.updateC = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.addC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListC
            // 
            this.dgvListC.BackgroundColor = System.Drawing.Color.White;
            this.dgvListC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListC.Location = new System.Drawing.Point(27, 39);
            this.dgvListC.Name = "dgvListC";
            this.dgvListC.Size = new System.Drawing.Size(745, 350);
            this.dgvListC.TabIndex = 0;
            this.dgvListC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListC_CellContentClick);
            this.dgvListC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListC_CellDoubleClick);
            // 
            // updateC
            // 
            this.updateC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.updateC.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateC.Location = new System.Drawing.Point(460, 396);
            this.updateC.Name = "updateC";
            this.updateC.Size = new System.Drawing.Size(118, 42);
            this.updateC.TabIndex = 10;
            this.updateC.Text = "עדכון תורם";
            this.updateC.UseVisualStyleBackColor = false;
            this.updateC.Click += new System.EventHandler(this.updateC_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(670, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(102, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "תורמים וותיקים";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(553, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(102, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "תורמים חדשים";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // addC
            // 
            this.addC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addC.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addC.Location = new System.Drawing.Point(239, 395);
            this.addC.Name = "addC";
            this.addC.Size = new System.Drawing.Size(118, 43);
            this.addC.TabIndex = 15;
            this.addC.Text = "הוספת תורם";
            this.addC.UseVisualStyleBackColor = false;
            this.addC.Click += new System.EventHandler(this.addC_Click);
            // 
            // FrmListContibutors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addC);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.updateC);
            this.Controls.Add(this.dgvListC);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmListContibutors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "תורמים ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListC;
        private System.Windows.Forms.Button updateC;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button addC;
    }
}