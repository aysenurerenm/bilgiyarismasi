namespace WindowsFormsApp2
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
            this.btna = new System.Windows.Forms.Button();
            this.btnö = new System.Windows.Forms.Button();
            this.btne = new System.Windows.Forms.Button();
            this.btnü = new System.Windows.Forms.Button();
            this.btnı = new System.Windows.Forms.Button();
            this.btno = new System.Windows.Forms.Button();
            this.btni = new System.Windows.Forms.Button();
            this.btnu = new System.Windows.Forms.Button();
            this.SORU = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SORU.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btna
            // 
            this.btna.Location = new System.Drawing.Point(104, 104);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(75, 23);
            this.btna.TabIndex = 0;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = true;
            // 
            // btnö
            // 
            this.btnö.Location = new System.Drawing.Point(303, 171);
            this.btnö.Name = "btnö";
            this.btnö.Size = new System.Drawing.Size(75, 23);
            this.btnö.TabIndex = 3;
            this.btnö.Text = "Ö";
            this.btnö.UseVisualStyleBackColor = true;
            // 
            // btne
            // 
            this.btne.Location = new System.Drawing.Point(204, 104);
            this.btne.Name = "btne";
            this.btne.Size = new System.Drawing.Size(75, 23);
            this.btne.TabIndex = 4;
            this.btne.Text = "E";
            this.btne.UseVisualStyleBackColor = true;
            // 
            // btnü
            // 
            this.btnü.Location = new System.Drawing.Point(252, 227);
            this.btnü.Name = "btnü";
            this.btnü.Size = new System.Drawing.Size(75, 23);
            this.btnü.TabIndex = 5;
            this.btnü.Text = "Ü";
            this.btnü.UseVisualStyleBackColor = true;
            // 
            // btnı
            // 
            this.btnı.Location = new System.Drawing.Point(303, 104);
            this.btnı.Name = "btnı";
            this.btnı.Size = new System.Drawing.Size(75, 23);
            this.btnı.TabIndex = 8;
            this.btnı.Text = "I";
            this.btnı.UseVisualStyleBackColor = true;
            // 
            // btno
            // 
            this.btno.Location = new System.Drawing.Point(204, 171);
            this.btno.Name = "btno";
            this.btno.Size = new System.Drawing.Size(75, 23);
            this.btno.TabIndex = 14;
            this.btno.Text = "O";
            this.btno.UseVisualStyleBackColor = true;
            // 
            // btni
            // 
            this.btni.Location = new System.Drawing.Point(104, 171);
            this.btni.Name = "btni";
            this.btni.Size = new System.Drawing.Size(75, 23);
            this.btni.TabIndex = 18;
            this.btni.Text = "İ";
            this.btni.UseVisualStyleBackColor = true;
            // 
            // btnu
            // 
            this.btnu.Location = new System.Drawing.Point(134, 227);
            this.btnu.Name = "btnu";
            this.btnu.Size = new System.Drawing.Size(75, 23);
            this.btnu.TabIndex = 21;
            this.btnu.Text = "U";
            this.btnu.UseVisualStyleBackColor = true;
            this.btnu.Click += new System.EventHandler(this.button22_Click);
            // 
            // SORU
            // 
            this.SORU.Controls.Add(this.richTextBox1);
            this.SORU.Location = new System.Drawing.Point(466, 50);
            this.SORU.Name = "SORU";
            this.SORU.Size = new System.Drawing.Size(322, 131);
            this.SORU.TabIndex = 22;
            this.SORU.TabStop = false;
            this.SORU.Text = "SORU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(466, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CEVAP";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(265, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(111, 59);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BAŞLA";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(466, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DURUM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOĞRU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "YANLIŞ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SORU);
            this.Controls.Add(this.btnu);
            this.Controls.Add(this.btni);
            this.Controls.Add(this.btno);
            this.Controls.Add(this.btnı);
            this.Controls.Add(this.btnü);
            this.Controls.Add(this.btne);
            this.Controls.Add(this.btnö);
            this.Controls.Add(this.btna);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SORU.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnö;
        private System.Windows.Forms.Button btne;
        private System.Windows.Forms.Button btnü;
        private System.Windows.Forms.Button btnı;
        private System.Windows.Forms.Button btno;
        private System.Windows.Forms.Button btni;
        private System.Windows.Forms.Button btnu;
        private System.Windows.Forms.GroupBox SORU;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

