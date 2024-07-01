
namespace LatetTikvaProject.GUI
{
    partial class FrmCouseNoAnsered
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCouseNoAnsered));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNoAnsered = new System.Windows.Forms.Button();
            this.btnBussy = new System.Windows.Forms.Button();
            this.btnTaKoly = new System.Windows.Forms.Button();
            this.btnNoConnected = new System.Windows.Forms.Button();
            this.btnRturn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(315, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "בחר סיבת אין מענה";
            // 
            // btnNoAnsered
            // 
            this.btnNoAnsered.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNoAnsered.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNoAnsered.Location = new System.Drawing.Point(318, 133);
            this.btnNoAnsered.Name = "btnNoAnsered";
            this.btnNoAnsered.Size = new System.Drawing.Size(123, 32);
            this.btnNoAnsered.TabIndex = 1;
            this.btnNoAnsered.Text = "לא נענה";
            this.btnNoAnsered.UseVisualStyleBackColor = false;
            this.btnNoAnsered.Click += new System.EventHandler(this.btnNoAnsered_Click);
            // 
            // btnBussy
            // 
            this.btnBussy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBussy.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBussy.Location = new System.Drawing.Point(318, 182);
            this.btnBussy.Name = "btnBussy";
            this.btnBussy.Size = new System.Drawing.Size(123, 29);
            this.btnBussy.TabIndex = 2;
            this.btnBussy.Text = "מספר תפוס";
            this.btnBussy.UseVisualStyleBackColor = false;
            this.btnBussy.Click += new System.EventHandler(this.btnBussy_Click);
            // 
            // btnTaKoly
            // 
            this.btnTaKoly.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTaKoly.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnTaKoly.Location = new System.Drawing.Point(318, 228);
            this.btnTaKoly.Name = "btnTaKoly";
            this.btnTaKoly.Size = new System.Drawing.Size(123, 30);
            this.btnTaKoly.TabIndex = 3;
            this.btnTaKoly.Text = "תא קולי";
            this.btnTaKoly.UseVisualStyleBackColor = false;
            this.btnTaKoly.Click += new System.EventHandler(this.btnTaKoly_Click);
            // 
            // btnNoConnected
            // 
            this.btnNoConnected.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNoConnected.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNoConnected.Location = new System.Drawing.Point(318, 273);
            this.btnNoConnected.Name = "btnNoConnected";
            this.btnNoConnected.Size = new System.Drawing.Size(123, 32);
            this.btnNoConnected.TabIndex = 4;
            this.btnNoConnected.Text = "מספר לא תקין";
            this.btnNoConnected.UseVisualStyleBackColor = false;
            this.btnNoConnected.Click += new System.EventHandler(this.btnNoConnected_Click);
            // 
            // btnRturn
            // 
            this.btnRturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRturn.Location = new System.Drawing.Point(213, 416);
            this.btnRturn.Name = "btnRturn";
            this.btnRturn.Size = new System.Drawing.Size(86, 31);
            this.btnRturn.TabIndex = 5;
            this.btnRturn.Text = "הקודם";
            this.btnRturn.UseVisualStyleBackColor = false;
            this.btnRturn.Visible = false;
            this.btnRturn.Click += new System.EventHandler(this.btnRturn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 423);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(12, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "הקודם";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmCouseNoAnsered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRturn);
            this.Controls.Add(this.btnNoConnected);
            this.Controls.Add(this.btnTaKoly);
            this.Controls.Add(this.btnBussy);
            this.Controls.Add(this.btnNoAnsered);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmCouseNoAnsered";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "אין מענה";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoAnsered;
        private System.Windows.Forms.Button btnBussy;
        private System.Windows.Forms.Button btnTaKoly;
        private System.Windows.Forms.Button btnNoConnected;
        private System.Windows.Forms.Button btnRturn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}