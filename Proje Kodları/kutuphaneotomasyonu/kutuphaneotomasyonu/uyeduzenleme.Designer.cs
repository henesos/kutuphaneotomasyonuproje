namespace kutuphaneotomasyonu
{
    partial class uyeduzenleme
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
            this.components = new System.ComponentModel.Container();
            this.kutuphaneveritabaniDataSet = new kutuphaneotomasyonu.kutuphaneveritabaniDataSet();
            this.uyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyeTableAdapter = new kutuphaneotomasyonu.kutuphaneveritabaniDataSetTableAdapters.uyeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kulid = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kulisim = new System.Windows.Forms.TextBox();
            this.kultelno = new System.Windows.Forms.TextBox();
            this.kultcno = new System.Windows.Forms.TextBox();
            this.kulsifre = new System.Windows.Forms.TextBox();
            this.kulmail = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.arabox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kulltur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneveritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kutuphaneveritabaniDataSet
            // 
            this.kutuphaneveritabaniDataSet.DataSetName = "kutuphaneveritabaniDataSet";
            this.kutuphaneveritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyeBindingSource
            // 
            this.uyeBindingSource.DataMember = "uye";
            this.uyeBindingSource.DataSource = this.kutuphaneveritabaniDataSet;
            // 
            // uyeTableAdapter
            // 
            this.uyeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(521, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(1097, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 62);
            this.button6.TabIndex = 38;
            this.button6.Text = "Listeyi Güncelle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(340, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 62);
            this.button1.TabIndex = 39;
            this.button1.Text = "Kullanıcıyı Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kulid
            // 
            this.kulid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kulid.Location = new System.Drawing.Point(137, 51);
            this.kulid.Name = "kulid";
            this.kulid.Size = new System.Drawing.Size(152, 24);
            this.kulid.TabIndex = 42;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(340, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 62);
            this.button4.TabIndex = 43;
            this.button4.Text = "Kullanıcıyı Sil";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label100.Location = new System.Drawing.Point(21, 51);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(76, 25);
            this.label100.TabIndex = 53;
            this.label100.Text = "Üye ID";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label101.Location = new System.Drawing.Point(21, 91);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(50, 25);
            this.label101.TabIndex = 54;
            this.label101.Text = "İsim";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label102.Location = new System.Drawing.Point(21, 131);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(75, 25);
            this.label102.TabIndex = 55;
            this.label102.Text = "Tel No";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label103.Location = new System.Drawing.Point(22, 171);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(85, 25);
            this.label103.TabIndex = 56;
            this.label103.Text = "T.C. No";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label104.Location = new System.Drawing.Point(22, 211);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(56, 25);
            this.label104.TabIndex = 57;
            this.label104.Text = "Şifre";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label106.Location = new System.Drawing.Point(21, 251);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(52, 25);
            this.label106.TabIndex = 58;
            this.label106.Text = "Mail";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(113, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 25);
            this.label15.TabIndex = 59;
            this.label15.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(113, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(113, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(113, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(113, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 25);
            this.label7.TabIndex = 64;
            this.label7.Text = ":";
            // 
            // kulisim
            // 
            this.kulisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kulisim.Location = new System.Drawing.Point(137, 93);
            this.kulisim.Name = "kulisim";
            this.kulisim.Size = new System.Drawing.Size(152, 24);
            this.kulisim.TabIndex = 65;
            // 
            // kultelno
            // 
            this.kultelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kultelno.Location = new System.Drawing.Point(137, 133);
            this.kultelno.Name = "kultelno";
            this.kultelno.Size = new System.Drawing.Size(152, 24);
            this.kultelno.TabIndex = 66;
            // 
            // kultcno
            // 
            this.kultcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kultcno.Location = new System.Drawing.Point(137, 173);
            this.kultcno.Name = "kultcno";
            this.kultcno.Size = new System.Drawing.Size(152, 24);
            this.kultcno.TabIndex = 67;
            // 
            // kulsifre
            // 
            this.kulsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kulsifre.Location = new System.Drawing.Point(137, 213);
            this.kulsifre.Name = "kulsifre";
            this.kulsifre.Size = new System.Drawing.Size(152, 24);
            this.kulsifre.TabIndex = 68;
            // 
            // kulmail
            // 
            this.kulmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kulmail.Location = new System.Drawing.Point(137, 253);
            this.kulmail.Name = "kulmail";
            this.kulmail.Size = new System.Drawing.Size(152, 24);
            this.kulmail.TabIndex = 69;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(12, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 67);
            this.button5.TabIndex = 80;
            this.button5.Text = "Ana Menüye Dön";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(797, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 29);
            this.radioButton1.TabIndex = 86;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İsim";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(882, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 29);
            this.radioButton2.TabIndex = 87;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "T.C. No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // arabox
            // 
            this.arabox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arabox.Location = new System.Drawing.Point(797, 50);
            this.arabox.Name = "arabox";
            this.arabox.Size = new System.Drawing.Size(196, 24);
            this.arabox.TabIndex = 88;
            this.arabox.TextChanged += new System.EventHandler(this.arabox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 89;
            this.label2.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(113, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(550, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 25);
            this.label8.TabIndex = 91;
            this.label8.Text = "Seçime Göre Arama   :";
            // 
            // kulltur
            // 
            this.kulltur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kulltur.FormattingEnabled = true;
            this.kulltur.Items.AddRange(new object[] {
            "yonetici",
            "uye",
            "yetkisiz"});
            this.kulltur.Location = new System.Drawing.Point(137, 293);
            this.kulltur.Name = "kulltur";
            this.kulltur.Size = new System.Drawing.Size(152, 26);
            this.kulltur.TabIndex = 92;
            // 
            // uyeduzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 514);
            this.Controls.Add(this.kulltur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arabox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.kulmail);
            this.Controls.Add(this.kulsifre);
            this.Controls.Add(this.kultcno);
            this.Controls.Add(this.kultelno);
            this.Controls.Add(this.kulisim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label106);
            this.Controls.Add(this.label104);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.kulid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uyeduzenleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Üyelik Düzenleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.uyeduzenleme_FormClosing);
            this.Load += new System.EventHandler(this.uyeduzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneveritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private kutuphaneveritabaniDataSet kutuphaneveritabaniDataSet;
        private System.Windows.Forms.BindingSource uyeBindingSource;
        private kutuphaneveritabaniDataSetTableAdapters.uyeTableAdapter uyeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kulid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kulisim;
        private System.Windows.Forms.TextBox kultelno;
        private System.Windows.Forms.TextBox kultcno;
        private System.Windows.Forms.TextBox kulsifre;
        private System.Windows.Forms.TextBox kulmail;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox arabox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox kulltur;
    }
}