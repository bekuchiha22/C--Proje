namespace MuzikV1
{
    partial class SarkiEkle
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnYazarKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Crimson;
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIptal.Location = new System.Drawing.Point(445, 173);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(116, 37);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "Vazgeç";
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // btnYazarKaydet
            // 
            this.btnYazarKaydet.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnYazarKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYazarKaydet.Location = new System.Drawing.Point(300, 173);
            this.btnYazarKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazarKaydet.Name = "btnYazarKaydet";
            this.btnYazarKaydet.Size = new System.Drawing.Size(118, 37);
            this.btnYazarKaydet.TabIndex = 10;
            this.btnYazarKaydet.Text = "Kaydet";
            this.btnYazarKaydet.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şarkı  Yazar Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şarkı Adı";
            // 
            // txtYazarSoyadi
            // 
            this.txtYazarSoyadi.Location = new System.Drawing.Point(300, 128);
            this.txtYazarSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtYazarSoyadi.Name = "txtYazarSoyadi";
            this.txtYazarSoyadi.Size = new System.Drawing.Size(261, 20);
            this.txtYazarSoyadi.TabIndex = 7;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(300, 95);
            this.txtYazarAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(261, 20);
            this.txtYazarAdi.TabIndex = 6;
            // 
            // SarkiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnYazarKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYazarSoyadi);
            this.Controls.Add(this.txtYazarAdi);
            this.Name = "SarkiEkle";
            this.Text = "SarkiEkle";
            this.Load += new System.EventHandler(this.SarkiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnYazarKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYazarSoyadi;
        private System.Windows.Forms.TextBox txtYazarAdi;
    }
}