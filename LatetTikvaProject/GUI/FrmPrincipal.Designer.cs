
namespace LatetTikvaProject.GUI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.workers = new System.Windows.Forms.Button();
            this.contributors = new System.Windows.Forms.Button();
            this.condituon = new System.Windows.Forms.Button();
            this.findCard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // workers
            // 
            this.workers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.workers.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.workers.Location = new System.Drawing.Point(576, 156);
            this.workers.Name = "workers";
            this.workers.Size = new System.Drawing.Size(112, 65);
            this.workers.TabIndex = 0;
            this.workers.Text = "רשימת עובדים";
            this.workers.UseVisualStyleBackColor = false;
            this.workers.Click += new System.EventHandler(this.workers_Click);
            // 
            // contributors
            // 
            this.contributors.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contributors.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.contributors.Location = new System.Drawing.Point(431, 156);
            this.contributors.Name = "contributors";
            this.contributors.Size = new System.Drawing.Size(112, 65);
            this.contributors.TabIndex = 1;
            this.contributors.Text = "רשימת תורמים";
            this.contributors.UseVisualStyleBackColor = false;
            this.contributors.Click += new System.EventHandler(this.contributors_Click);
            // 
            // condituon
            // 
            this.condituon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.condituon.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.condituon.Location = new System.Drawing.Point(271, 156);
            this.condituon.Name = "condituon";
            this.condituon.Size = new System.Drawing.Size(112, 65);
            this.condituon.TabIndex = 2;
            this.condituon.Text = "מצב און ליין";
            this.condituon.UseVisualStyleBackColor = false;
            this.condituon.Click += new System.EventHandler(this.condituon_Click);
            // 
            // findCard
            // 
            this.findCard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.findCard.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.findCard.Location = new System.Drawing.Point(114, 156);
            this.findCard.Name = "findCard";
            this.findCard.Size = new System.Drawing.Size(112, 65);
            this.findCard.TabIndex = 3;
            this.findCard.Text = "איתור כרטיס";
            this.findCard.UseVisualStyleBackColor = false;
            this.findCard.Click += new System.EventHandler(this.findCard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 137);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.findCard);
            this.Controls.Add(this.condituon);
            this.Controls.Add(this.contributors);
            this.Controls.Add(this.workers);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "כניסת מנהל";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button workers;
        private System.Windows.Forms.Button contributors;
        private System.Windows.Forms.Button condituon;
        private System.Windows.Forms.Button findCard;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}