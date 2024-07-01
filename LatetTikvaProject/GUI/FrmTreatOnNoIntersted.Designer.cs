
namespace LatetTikvaProject.GUI
{
    partial class FrmTreatOnNoIntersted
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
            this.dataGvTreatNoWant = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvTreatNoWant)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGvTreatNoWant
            // 
            this.dataGvTreatNoWant.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGvTreatNoWant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvTreatNoWant.Location = new System.Drawing.Point(25, 12);
            this.dataGvTreatNoWant.Name = "dataGvTreatNoWant";
            this.dataGvTreatNoWant.Size = new System.Drawing.Size(738, 398);
            this.dataGvTreatNoWant.TabIndex = 0;
            this.dataGvTreatNoWant.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGvTreatNoWant_CellDoubleClick);
            // 
            // FrmTreatOnNoIntersted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGvTreatNoWant);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmTreatOnNoIntersted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "לא מעונינים";
            ((System.ComponentModel.ISupportInitialize)(this.dataGvTreatNoWant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGvTreatNoWant;
    }
}