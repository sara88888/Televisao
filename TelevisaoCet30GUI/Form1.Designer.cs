namespace TelevisaoCet30GUI
{
    partial class Form1
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
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ButtonOnOff = new System.Windows.Forms.Button();
            this.ButtonDiminuiCanal = new System.Windows.Forms.Button();
            this.ButtonAumentaCanal = new System.Windows.Forms.Button();
            this.LabelCanal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelVolume = new System.Windows.Forms.Label();
            this.ButtonAumentaVolume = new System.Windows.Forms.Button();
            this.ButtonDiminuiVolume = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TrackBarVolume1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(30, 296);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(118, 20);
            this.LabelStatus.TabIndex = 0;
            this.LabelStatus.Text = "Status da TV";
            // 
            // ButtonOnOff
            // 
            this.ButtonOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOnOff.Location = new System.Drawing.Point(161, 331);
            this.ButtonOnOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonOnOff.Name = "ButtonOnOff";
            this.ButtonOnOff.Size = new System.Drawing.Size(82, 57);
            this.ButtonOnOff.TabIndex = 1;
            this.ButtonOnOff.Text = "On";
            this.ButtonOnOff.UseVisualStyleBackColor = true;
            this.ButtonOnOff.Click += new System.EventHandler(this.ButtonOnOff_Click);
            // 
            // ButtonDiminuiCanal
            // 
            this.ButtonDiminuiCanal.Enabled = false;
            this.ButtonDiminuiCanal.Location = new System.Drawing.Point(39, 25);
            this.ButtonDiminuiCanal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDiminuiCanal.Name = "ButtonDiminuiCanal";
            this.ButtonDiminuiCanal.Size = new System.Drawing.Size(76, 35);
            this.ButtonDiminuiCanal.TabIndex = 2;
            this.ButtonDiminuiCanal.Text = "-";
            this.ButtonDiminuiCanal.UseVisualStyleBackColor = true;
            this.ButtonDiminuiCanal.Click += new System.EventHandler(this.ButtonDiminuiCanal_Click);
            // 
            // ButtonAumentaCanal
            // 
            this.ButtonAumentaCanal.Enabled = false;
            this.ButtonAumentaCanal.Location = new System.Drawing.Point(226, 25);
            this.ButtonAumentaCanal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAumentaCanal.Name = "ButtonAumentaCanal";
            this.ButtonAumentaCanal.Size = new System.Drawing.Size(80, 35);
            this.ButtonAumentaCanal.TabIndex = 3;
            this.ButtonAumentaCanal.Text = "+";
            this.ButtonAumentaCanal.UseVisualStyleBackColor = true;
            this.ButtonAumentaCanal.Click += new System.EventHandler(this.ButtonAumentaCanal_Click);
            // 
            // LabelCanal
            // 
            this.LabelCanal.AutoSize = true;
            this.LabelCanal.Location = new System.Drawing.Point(164, 32);
            this.LabelCanal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCanal.Name = "LabelCanal";
            this.LabelCanal.Size = new System.Drawing.Size(23, 20);
            this.LabelCanal.TabIndex = 4;
            this.LabelCanal.Text = "- -";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonDiminuiCanal);
            this.groupBox1.Controls.Add(this.LabelCanal);
            this.groupBox1.Controls.Add(this.ButtonAumentaCanal);
            this.groupBox1.Location = new System.Drawing.Point(33, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(362, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelVolume);
            this.groupBox2.Controls.Add(this.ButtonAumentaVolume);
            this.groupBox2.Controls.Add(this.ButtonDiminuiVolume);
            this.groupBox2.Location = new System.Drawing.Point(33, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(362, 69);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume";
            // 
            // LabelVolume
            // 
            this.LabelVolume.Location = new System.Drawing.Point(164, 29);
            this.LabelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.Size = new System.Drawing.Size(36, 35);
            this.LabelVolume.TabIndex = 2;
            this.LabelVolume.Text = "- -";
            // 
            // ButtonAumentaVolume
            // 
            this.ButtonAumentaVolume.Location = new System.Drawing.Point(230, 22);
            this.ButtonAumentaVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAumentaVolume.Name = "ButtonAumentaVolume";
            this.ButtonAumentaVolume.Size = new System.Drawing.Size(80, 35);
            this.ButtonAumentaVolume.TabIndex = 1;
            this.ButtonAumentaVolume.Text = "+";
            this.ButtonAumentaVolume.UseVisualStyleBackColor = true;
            this.ButtonAumentaVolume.Click += new System.EventHandler(this.ButtonAumentaVolume_Click);
            // 
            // ButtonDiminuiVolume
            // 
            this.ButtonDiminuiVolume.Location = new System.Drawing.Point(39, 22);
            this.ButtonDiminuiVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDiminuiVolume.Name = "ButtonDiminuiVolume";
            this.ButtonDiminuiVolume.Size = new System.Drawing.Size(76, 35);
            this.ButtonDiminuiVolume.TabIndex = 0;
            this.ButtonDiminuiVolume.Text = "-";
            this.ButtonDiminuiVolume.UseVisualStyleBackColor = true;
            this.ButtonDiminuiVolume.Click += new System.EventHandler(this.ButtonDiminuiVolume_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TrackBarVolume1);
            this.groupBox3.Location = new System.Drawing.Point(33, 166);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(362, 125);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Volume 1";
            // 
            // TrackBarVolume1
            // 
            this.TrackBarVolume1.Location = new System.Drawing.Point(39, 29);
            this.TrackBarVolume1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrackBarVolume1.Maximum = 30;
            this.TrackBarVolume1.Name = "TrackBarVolume1";
            this.TrackBarVolume1.Size = new System.Drawing.Size(270, 69);
            this.TrackBarVolume1.TabIndex = 6;
            this.TrackBarVolume1.Scroll += new System.EventHandler(this.TrackBarVolume1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonOnOff);
            this.Controls.Add(this.LabelStatus);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Button ButtonOnOff;
        private System.Windows.Forms.Button ButtonDiminuiCanal;
        private System.Windows.Forms.Button ButtonAumentaCanal;
        private System.Windows.Forms.Label LabelCanal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelVolume;
        private System.Windows.Forms.Button ButtonAumentaVolume;
        private System.Windows.Forms.Button ButtonDiminuiVolume;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar TrackBarVolume1;
    }
}