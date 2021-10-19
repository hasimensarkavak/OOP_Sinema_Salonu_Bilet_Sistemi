
namespace vize_odev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salonPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btBilet = new System.Windows.Forms.Button();
            this.girisPanel = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.indirimKoduBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salonBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.salonPanel.SuspendLayout();
            this.girisPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // salonPanel
            // 
            this.salonPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.salonPanel.Controls.Add(this.label7);
            this.salonPanel.Location = new System.Drawing.Point(366, 43);
            this.salonPanel.Name = "salonPanel";
            this.salonPanel.Size = new System.Drawing.Size(480, 400);
            this.salonPanel.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(37, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(406, 50);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lütfen Gösterim Seçiniz";
            // 
            // btBilet
            // 
            this.btBilet.Location = new System.Drawing.Point(136, 349);
            this.btBilet.Name = "btBilet";
            this.btBilet.Size = new System.Drawing.Size(75, 23);
            this.btBilet.TabIndex = 0;
            this.btBilet.Text = "Bilet Al";
            this.btBilet.UseVisualStyleBackColor = true;
            this.btBilet.Click += new System.EventHandler(this.btBilet_Click);
            // 
            // girisPanel
            // 
            this.girisPanel.BackColor = System.Drawing.Color.DarkSalmon;
            this.girisPanel.Controls.Add(this.maskedTextBox1);
            this.girisPanel.Controls.Add(this.label10);
            this.girisPanel.Controls.Add(this.checkBox1);
            this.girisPanel.Controls.Add(this.indirimKoduBox);
            this.girisPanel.Controls.Add(this.textBox2);
            this.girisPanel.Controls.Add(this.textBox1);
            this.girisPanel.Controls.Add(this.label6);
            this.girisPanel.Controls.Add(this.label5);
            this.girisPanel.Controls.Add(this.label4);
            this.girisPanel.Controls.Add(this.label3);
            this.girisPanel.Controls.Add(this.label2);
            this.girisPanel.Controls.Add(this.label1);
            this.girisPanel.Controls.Add(this.btBilet);
            this.girisPanel.Controls.Add(this.salonBox);
            this.girisPanel.Location = new System.Drawing.Point(12, 43);
            this.girisPanel.Name = "girisPanel";
            this.girisPanel.Size = new System.Drawing.Size(335, 400);
            this.girisPanel.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(127, 182);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Örnek İndirim Kodu: INDIRIM";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(102, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 19);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "İndirim Kodum Var";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // indirimKoduBox
            // 
            this.indirimKoduBox.Location = new System.Drawing.Point(127, 297);
            this.indirimKoduBox.Name = "indirimKoduBox";
            this.indirimKoduBox.Size = new System.Drawing.Size(100, 23);
            this.indirimKoduBox.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "İndirim Kodu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gösterim:";
            // 
            // salonBox
            // 
            this.salonBox.FormattingEnabled = true;
            this.salonBox.Items.AddRange(new object[] {
            "Salon 1, Avangers, 12:30, 9 Haziran",
            "Salon 2, G.O.R.A, 16:00, 12 Haziran",
            "Salon 3, Interstellar, 14:20, 29 Haziran"});
            this.salonBox.Location = new System.Drawing.Point(90, 26);
            this.salonBox.Name = "salonBox";
            this.salonBox.Size = new System.Drawing.Size(200, 23);
            this.salonBox.TabIndex = 1;
            this.salonBox.SelectedIndexChanged += new System.EventHandler(this.salonBox_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(403, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sinema";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Koltuk: Sıra No-Koltuk No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 468);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.girisPanel);
            this.Controls.Add(this.salonPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.salonPanel.ResumeLayout(false);
            this.salonPanel.PerformLayout();
            this.girisPanel.ResumeLayout(false);
            this.girisPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel salonPanel;
        private System.Windows.Forms.Panel girisPanel;
        private System.Windows.Forms.ComboBox salonBox;
        private System.Windows.Forms.Button btBilet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox indirimKoduBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

