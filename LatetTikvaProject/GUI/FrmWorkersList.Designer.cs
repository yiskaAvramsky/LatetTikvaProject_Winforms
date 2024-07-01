
namespace LatetTikvaProject.GUI
{
    partial class FrmWorkersList
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
            this.dgvWL = new System.Windows.Forms.DataGridView();
            this.addW = new System.Windows.Forms.Button();
            this.updateW = new System.Windows.Forms.Button();
            this.delateW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWL
            // 
            this.dgvWL.BackgroundColor = System.Drawing.Color.White;
            this.dgvWL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWL.Location = new System.Drawing.Point(24, 12);
            this.dgvWL.Name = "dgvWL";
            this.dgvWL.Size = new System.Drawing.Size(747, 354);
            this.dgvWL.TabIndex = 0;
            //this.dgvWL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWL_CellContentClick);
            this.dgvWL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWL_CellDoubleClick);
            // 
            // addW
            // 
            this.addW.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addW.Location = new System.Drawing.Point(520, 384);
            this.addW.Name = "addW";
            this.addW.Size = new System.Drawing.Size(118, 33);
            this.addW.TabIndex = 1;
            this.addW.Text = "הוספת עובד";
            this.addW.UseVisualStyleBackColor = false;
            this.addW.Click += new System.EventHandler(this.addW_Click);
            // 
            // updateW
            // 
            this.updateW.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.updateW.Location = new System.Drawing.Point(348, 384);
            this.updateW.Name = "updateW";
            this.updateW.Size = new System.Drawing.Size(120, 33);
            this.updateW.TabIndex = 1;
            this.updateW.Text = "עדכון עובד";
            this.updateW.UseVisualStyleBackColor = false;
            this.updateW.Click += new System.EventHandler(this.updateW_Click_1);
            // 
            // delateW
            // 
            this.delateW.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.delateW.Location = new System.Drawing.Point(163, 384);
            this.delateW.Name = "delateW";
            this.delateW.Size = new System.Drawing.Size(135, 33);
            this.delateW.TabIndex = 1;
            this.delateW.Text = "מחיקת עובד";
            this.delateW.UseVisualStyleBackColor = false;
            this.delateW.Click += new System.EventHandler(this.delateW_Click);
            // 
            // FrmWorkersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delateW);
            this.Controls.Add(this.updateW);
            this.Controls.Add(this.addW);
            this.Controls.Add(this.dgvWL);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmWorkersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "עובדים";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWL;
        private System.Windows.Forms.Button addW;
        private System.Windows.Forms.Button updateW;
        private System.Windows.Forms.Button delateW;
    }
}