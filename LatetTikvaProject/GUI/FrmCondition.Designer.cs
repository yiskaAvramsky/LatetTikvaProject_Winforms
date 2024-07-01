
namespace LatetTikvaProject.GUI
{
    partial class FrmCondition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCondition));
            this.button1 = new System.Windows.Forms.Button();
            this.btnConditionOfW = new System.Windows.Forms.Button();
            this.btnInsertToW = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(582, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "טיפול בלא מעונינים";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConditionOfW
            // 
            this.btnConditionOfW.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConditionOfW.Location = new System.Drawing.Point(582, 63);
            this.btnConditionOfW.Name = "btnConditionOfW";
            this.btnConditionOfW.Size = new System.Drawing.Size(121, 60);
            this.btnConditionOfW.TabIndex = 2;
            this.btnConditionOfW.Text = "מצב העובדים כעת";
            this.btnConditionOfW.UseVisualStyleBackColor = false;
            this.btnConditionOfW.Click += new System.EventHandler(this.btnConditionOfW_Click);
            // 
            // btnInsertToW
            // 
            this.btnInsertToW.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInsertToW.Location = new System.Drawing.Point(582, 126);
            this.btnInsertToW.Name = "btnInsertToW";
            this.btnInsertToW.Size = new System.Drawing.Size(121, 60);
            this.btnInsertToW.TabIndex = 3;
            this.btnInsertToW.Text = "שיוך תורמים לעובד";
            this.btnInsertToW.UseVisualStyleBackColor = false;
            this.btnInsertToW.Click += new System.EventHandler(this.btnInsertToW_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(582, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "נקה רשומות מעובד";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 372);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnC.Location = new System.Drawing.Point(582, 316);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(121, 60);
            this.btnC.TabIndex = 6;
            this.btnC.Text = ":סך תרומות היום לחיוב";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // FrmCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInsertToW);
            this.Controls.Add(this.btnConditionOfW);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmCondition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מצב און ליין";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConditionOfW;
        private System.Windows.Forms.Button btnInsertToW;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnC;
    }
}