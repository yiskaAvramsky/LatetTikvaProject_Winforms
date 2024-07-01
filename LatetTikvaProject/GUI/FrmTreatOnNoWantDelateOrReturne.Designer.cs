
namespace LatetTikvaProject.GUI
{
    partial class FrmTreatOnNoWantDelateOrReturne
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
            this.btnInPast = new System.Windows.Forms.Button();
            this.txtCouseNote = new System.Windows.Forms.RichTextBox();
            this.btnDelate = new System.Windows.Forms.Button();
            this.btnReturne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInPast
            // 
            this.btnInPast.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInPast.Location = new System.Drawing.Point(12, 21);
            this.btnInPast.Name = "btnInPast";
            this.btnInPast.Size = new System.Drawing.Size(113, 37);
            this.btnInPast.TabIndex = 0;
            this.btnInPast.Text = "תרומות בעבר";
            this.btnInPast.UseVisualStyleBackColor = false;
            this.btnInPast.Click += new System.EventHandler(this.btnInPast_Click);
            // 
            // txtCouseNote
            // 
            this.txtCouseNote.BackColor = System.Drawing.Color.White;
            this.txtCouseNote.Location = new System.Drawing.Point(12, 74);
            this.txtCouseNote.Name = "txtCouseNote";
            this.txtCouseNote.ReadOnly = true;
            this.txtCouseNote.Size = new System.Drawing.Size(268, 199);
            this.txtCouseNote.TabIndex = 1;
            this.txtCouseNote.Text = "";
            // 
            // btnDelate
            // 
            this.btnDelate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDelate.Location = new System.Drawing.Point(169, 293);
            this.btnDelate.Name = "btnDelate";
            this.btnDelate.Size = new System.Drawing.Size(94, 37);
            this.btnDelate.TabIndex = 2;
            this.btnDelate.Text = "מחיקה";
            this.btnDelate.UseVisualStyleBackColor = false;
            this.btnDelate.Click += new System.EventHandler(this.btnDelate_Click);
            // 
            // btnReturne
            // 
            this.btnReturne.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReturne.Location = new System.Drawing.Point(37, 293);
            this.btnReturne.Name = "btnReturne";
            this.btnReturne.Size = new System.Drawing.Size(92, 37);
            this.btnReturne.TabIndex = 3;
            this.btnReturne.Text = "החזרה לרשימה";
            this.btnReturne.UseVisualStyleBackColor = false;
            this.btnReturne.Click += new System.EventHandler(this.btnReturne_Click);
            // 
            // FrmTreatOnNoWantDelateOrReturne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 369);
            this.Controls.Add(this.btnReturne);
            this.Controls.Add(this.btnDelate);
            this.Controls.Add(this.txtCouseNote);
            this.Controls.Add(this.btnInPast);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmTreatOnNoWantDelateOrReturne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "טיפול בלא מעונינים";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInPast;
        private System.Windows.Forms.RichTextBox txtCouseNote;
        private System.Windows.Forms.Button btnDelate;
        private System.Windows.Forms.Button btnReturne;
    }
}