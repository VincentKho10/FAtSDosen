namespace FAtSDosen
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
            this.cbJadwal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPresensi = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pbQrcode = new System.Windows.Forms.PictureBox();
            this.lsHosted = new System.Windows.Forms.ListBox();
            this.netStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // cbJadwal
            // 
            this.cbJadwal.FormattingEnabled = true;
            this.cbJadwal.ItemHeight = 13;
            this.cbJadwal.Location = new System.Drawing.Point(16, 28);
            this.cbJadwal.Name = "cbJadwal";
            this.cbJadwal.Size = new System.Drawing.Size(215, 21);
            this.cbJadwal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jadwal";
            // 
            // btnPresensi
            // 
            this.btnPresensi.Location = new System.Drawing.Point(124, 74);
            this.btnPresensi.Name = "btnPresensi";
            this.btnPresensi.Size = new System.Drawing.Size(107, 23);
            this.btnPresensi.TabIndex = 2;
            this.btnPresensi.Text = "Mulai Presensi";
            this.btnPresensi.UseVisualStyleBackColor = true;
            this.btnPresensi.Click += new System.EventHandler(this.btnPresensi_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(693, 415);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(95, 23);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload Presensi";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pbQrcode
            // 
            this.pbQrcode.Location = new System.Drawing.Point(275, 12);
            this.pbQrcode.Name = "pbQrcode";
            this.pbQrcode.Size = new System.Drawing.Size(513, 397);
            this.pbQrcode.TabIndex = 5;
            this.pbQrcode.TabStop = false;
            // 
            // lsHosted
            // 
            this.lsHosted.FormattingEnabled = true;
            this.lsHosted.Location = new System.Drawing.Point(16, 132);
            this.lsHosted.Name = "lsHosted";
            this.lsHosted.ScrollAlwaysVisible = true;
            this.lsHosted.Size = new System.Drawing.Size(218, 277);
            this.lsHosted.TabIndex = 6;
            // 
            // netStatus
            // 
            this.netStatus.AutoSize = true;
            this.netStatus.ForeColor = System.Drawing.Color.Red;
            this.netStatus.Location = new System.Drawing.Point(121, 100);
            this.netStatus.Name = "netStatus";
            this.netStatus.Size = new System.Drawing.Size(73, 13);
            this.netStatus.TabIndex = 7;
            this.netStatus.Text = "Disconnected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.netStatus);
            this.Controls.Add(this.lsHosted);
            this.Controls.Add(this.pbQrcode);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnPresensi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJadwal);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbQrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJadwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPresensi;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pbQrcode;
        private System.Windows.Forms.ListBox lsHosted;
        private System.Windows.Forms.Label netStatus;
    }
}

