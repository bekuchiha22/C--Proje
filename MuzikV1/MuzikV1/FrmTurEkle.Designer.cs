namespace MuzikV1
{
    partial class FrmTurEkle
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
            this.btnTurDuzenleme = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTurEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTurDuzenleme
            // 
            this.btnTurDuzenleme.Location = new System.Drawing.Point(446, 198);
            this.btnTurDuzenleme.Name = "btnTurDuzenleme";
            this.btnTurDuzenleme.Size = new System.Drawing.Size(128, 55);
            this.btnTurDuzenleme.TabIndex = 21;
            this.btnTurDuzenleme.Text = "Tür düzenleme";
            this.btnTurDuzenleme.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(343, 198);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 55);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnTurEkle
            // 
            this.btnTurEkle.Location = new System.Drawing.Point(226, 199);
            this.btnTurEkle.Name = "btnTurEkle";
            this.btnTurEkle.Size = new System.Drawing.Size(122, 54);
            this.btnTurEkle.TabIndex = 19;
            this.btnTurEkle.Text = "Yeni tür ekle";
            this.btnTurEkle.UseVisualStyleBackColor = true;
            this.btnTurEkle.Click += new System.EventHandler(this.btnTurEkle_Click);
            // 
            // FrmTurEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTurDuzenleme);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTurEkle);
            this.Name = "FrmTurEkle";
            this.Text = "FrmTurEkle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTurDuzenleme;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTurEkle;
    }
}