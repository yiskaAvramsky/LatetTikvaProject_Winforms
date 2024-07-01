
namespace LatetTikvaProject.GUI
{
    partial class FrmInsertToWprCon
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
            this.dgvConToInsert = new System.Windows.Forms.DataGridView();
            this.btnChooseWor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConToInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConToInsert
            // 
            this.dgvConToInsert.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvConToInsert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConToInsert.Location = new System.Drawing.Point(45, 60);
            this.dgvConToInsert.Name = "dgvConToInsert";
            this.dgvConToInsert.Size = new System.Drawing.Size(708, 313);
            this.dgvConToInsert.TabIndex = 0;
            // 
            // btnChooseWor
            // 
            this.btnChooseWor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnChooseWor.Location = new System.Drawing.Point(340, 382);
            this.btnChooseWor.Name = "btnChooseWor";
            this.btnChooseWor.Size = new System.Drawing.Size(128, 43);
            this.btnChooseWor.TabIndex = 2;
            this.btnChooseWor.Text = "בחר עובד לשיוך";
            this.btnChooseWor.UseVisualStyleBackColor = false;
            this.btnChooseWor.Click += new System.EventHandler(this.btnChooseWor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = ":מיון";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "חדשים",
            "לא מעוניינים",
            "ביצוע עסקה",
            "דחויים",
            "סכום תרומה אחרונה",
            "לא נענה"});
            this.comboBox1.Location = new System.Drawing.Point(579, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(540, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInsertToWprCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseWor);
            this.Controls.Add(this.dgvConToInsert);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmInsertToWprCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "שיוך תורמים";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConToInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConToInsert;
        private System.Windows.Forms.Button btnChooseWor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}