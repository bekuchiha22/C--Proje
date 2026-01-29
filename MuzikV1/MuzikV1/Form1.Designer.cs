namespace MuzikV1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydisil = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnSarkiEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSanatciGuncelleme = new System.Windows.Forms.Button();
            this.btnSanatciSil = new System.Windows.Forms.Button();
            this.btnSanatciEkle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabcontrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tabPage1);
            this.tabcontrol1.Controls.Add(this.tabPage2);
            this.tabcontrol1.Controls.Add(this.tabPage3);
            this.tabcontrol1.Controls.Add(this.tabPage4);
            this.tabcontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol1.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(1047, 584);
            this.tabcontrol1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Controls.Add(this.btnKaydisil);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.radioButton3);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.btnSarkiEkle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1039, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Şarkı Yönetimi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(238, 0);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(149, 67);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Kaydı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnKaydisil
            // 
            this.btnKaydisil.Location = new System.Drawing.Point(144, 0);
            this.btnKaydisil.Name = "btnKaydisil";
            this.btnKaydisil.Size = new System.Drawing.Size(98, 67);
            this.btnKaydisil.TabIndex = 8;
            this.btnKaydisil.Text = "Kaydı Sil";
            this.btnKaydisil.UseVisualStyleBackColor = true;
            this.btnKaydisil.Click += new System.EventHandler(this.btnKaydisil_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(412, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(91, 24);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Arama/Listeleme";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(997, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(891, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(764, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(655, 40);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Türe göre arama";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(524, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(128, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sanatçıya göre arama";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(412, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İsme Göre Arama";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSarkiEkle
            // 
            this.btnSarkiEkle.Location = new System.Drawing.Point(0, 0);
            this.btnSarkiEkle.Name = "btnSarkiEkle";
            this.btnSarkiEkle.Size = new System.Drawing.Size(148, 67);
            this.btnSarkiEkle.TabIndex = 0;
            this.btnSarkiEkle.Text = "Şarkı Ekle";
            this.btnSarkiEkle.UseVisualStyleBackColor = true;
            this.btnSarkiEkle.Click += new System.EventHandler(this.btnSarkiEkle_Click_2);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSanatciGuncelleme);
            this.tabPage2.Controls.Add(this.btnSanatciSil);
            this.tabPage2.Controls.Add(this.btnSanatciEkle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1039, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sanatçı Yönetimi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSanatciGuncelleme
            // 
            this.btnSanatciGuncelleme.Location = new System.Drawing.Point(220, -1);
            this.btnSanatciGuncelleme.Name = "btnSanatciGuncelleme";
            this.btnSanatciGuncelleme.Size = new System.Drawing.Size(128, 55);
            this.btnSanatciGuncelleme.TabIndex = 12;
            this.btnSanatciGuncelleme.Text = "Güncelle";
            this.btnSanatciGuncelleme.UseVisualStyleBackColor = true;
            // 
            // btnSanatciSil
            // 
            this.btnSanatciSil.Location = new System.Drawing.Point(117, -1);
            this.btnSanatciSil.Name = "btnSanatciSil";
            this.btnSanatciSil.Size = new System.Drawing.Size(106, 55);
            this.btnSanatciSil.TabIndex = 11;
            this.btnSanatciSil.Text = " Sil";
            this.btnSanatciSil.UseVisualStyleBackColor = true;
            this.btnSanatciSil.Click += new System.EventHandler(this.btnSanatciSil_Click);
            // 
            // btnSanatciEkle
            // 
            this.btnSanatciEkle.Location = new System.Drawing.Point(0, 0);
            this.btnSanatciEkle.Name = "btnSanatciEkle";
            this.btnSanatciEkle.Size = new System.Drawing.Size(122, 54);
            this.btnSanatciEkle.TabIndex = 10;
            this.btnSanatciEkle.Text = " Sanatçı Ekle";
            this.btnSanatciEkle.UseVisualStyleBackColor = true;
            this.btnSanatciEkle.Click += new System.EventHandler(this.btnSanatciEkle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1039, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tür Yönetimi";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tür düzenleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 55);
            this.button3.TabIndex = 14;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 54);
            this.button4.TabIndex = 13;
            this.button4.Text = "Tür ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1039, 558);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kullanıcı Yönetimi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 584);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabcontrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSarkiEkle;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydisil;
        private System.Windows.Forms.Button btnSanatciGuncelleme;
        private System.Windows.Forms.Button btnSanatciSil;
        private System.Windows.Forms.Button btnSanatciEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

