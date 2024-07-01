
namespace LatetTikvaProject.GUI
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.enterP = new System.Windows.Forms.Button();
            this.enterW = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.okP = new System.Windows.Forms.Button();
            this.okW = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // enterP
            // 
            this.enterP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.enterP.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.enterP.Location = new System.Drawing.Point(317, 244);
            this.enterP.Name = "enterP";
            this.enterP.Size = new System.Drawing.Size(113, 64);
            this.enterP.TabIndex = 0;
            this.enterP.Text = "לכניסת מנהל";
            this.enterP.UseVisualStyleBackColor = false;
            this.enterP.Click += new System.EventHandler(this.enterP_Click);
            // 
            // enterW
            // 
            this.enterW.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.enterW.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.enterW.Location = new System.Drawing.Point(485, 244);
            this.enterW.Name = "enterW";
            this.enterW.Size = new System.Drawing.Size(115, 66);
            this.enterW.TabIndex = 1;
            this.enterW.Text = "לכניסת עובד";
            this.enterW.UseVisualStyleBackColor = false;
            this.enterW.Click += new System.EventHandler(this.enterW_Click);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(317, 333);
            this.txtP.Name = "txtP";
            this.txtP.PasswordChar = 'x';
            this.txtP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtP.Size = new System.Drawing.Size(113, 21);
            this.txtP.TabIndex = 2;
            this.txtP.Visible = false;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(485, 333);
            this.txtW.Name = "txtW";
            this.txtW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtW.Size = new System.Drawing.Size(115, 21);
            this.txtW.TabIndex = 3;
            this.txtW.Visible = false;
            this.txtW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtW_KeyPress);
            // 
            // okP
            // 
            this.okP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.okP.Location = new System.Drawing.Point(350, 361);
            this.okP.Name = "okP";
            this.okP.Size = new System.Drawing.Size(46, 23);
            this.okP.TabIndex = 4;
            this.okP.Text = "OK";
            this.okP.UseVisualStyleBackColor = false;
            this.okP.Visible = false;
            this.okP.Click += new System.EventHandler(this.okP_Click);
            // 
            // okW
            // 
            this.okW.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.okW.Location = new System.Drawing.Point(523, 360);
            this.okW.Name = "okW";
            this.okW.Size = new System.Drawing.Size(43, 24);
            this.okW.TabIndex = 5;
            this.okW.Text = "OK";
            this.okW.UseVisualStyleBackColor = false;
            this.okW.Visible = false;
            this.okW.Click += new System.EventHandler(this.okW_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 119);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 118);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(558, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = ":ת.ז";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(371, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = ":סיסמא";
            this.label2.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(889, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okW);
            this.Controls.Add(this.okP);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.enterW);
            this.Controls.Add(this.enterP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "לתת תקוה-כניסה";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterP;
        private System.Windows.Forms.Button enterW;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Button okP;
        private System.Windows.Forms.Button okW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}