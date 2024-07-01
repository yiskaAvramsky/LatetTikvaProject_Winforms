
namespace LatetTikvaProject.GUI
{
    partial class FrmResultOfCall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResultOfCall));
            this.btnPerformanceContribution = new System.Windows.Forms.Button();
            this.btnRepelled = new System.Windows.Forms.Button();
            this.btnNoWant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPerformanceContribution
            // 
            this.btnPerformanceContribution.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPerformanceContribution.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPerformanceContribution.Location = new System.Drawing.Point(286, 140);
            this.btnPerformanceContribution.Name = "btnPerformanceContribution";
            this.btnPerformanceContribution.Size = new System.Drawing.Size(133, 40);
            this.btnPerformanceContribution.TabIndex = 0;
            this.btnPerformanceContribution.Text = "ביצוע עסקה";
            this.btnPerformanceContribution.UseVisualStyleBackColor = false;
            this.btnPerformanceContribution.Click += new System.EventHandler(this.btnPerformanceContribution_Click);
            // 
            // btnRepelled
            // 
            this.btnRepelled.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRepelled.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRepelled.Location = new System.Drawing.Point(286, 197);
            this.btnRepelled.Name = "btnRepelled";
            this.btnRepelled.Size = new System.Drawing.Size(133, 42);
            this.btnRepelled.TabIndex = 1;
            this.btnRepelled.Text = "דחייה";
            this.btnRepelled.UseVisualStyleBackColor = false;
            this.btnRepelled.Click += new System.EventHandler(this.btnRepelled_Click);
            // 
            // btnNoWant
            // 
            this.btnNoWant.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNoWant.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNoWant.Location = new System.Drawing.Point(286, 255);
            this.btnNoWant.Name = "btnNoWant";
            this.btnNoWant.Size = new System.Drawing.Size(133, 44);
            this.btnNoWant.TabIndex = 2;
            this.btnNoWant.Text = "לא מעונין";
            this.btnNoWant.UseVisualStyleBackColor = false;
            this.btnNoWant.Click += new System.EventHandler(this.btnNoWant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(312, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "תוצאות מענה";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReturn.Location = new System.Drawing.Point(144, 402);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(93, 29);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "הקודם";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 423);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(11, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "הקודם";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmResultOfCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(694, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoWant);
            this.Controls.Add(this.btnRepelled);
            this.Controls.Add(this.btnPerformanceContribution);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmResultOfCall";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מענה";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerformanceContribution;
        private System.Windows.Forms.Button btnRepelled;
        private System.Windows.Forms.Button btnNoWant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}