namespace kutuphaneotomasyonu
{
    partial class oduncalmagecmisi
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
            this.kutuphaneveritabaniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneveritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneveritabaniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kutuphaneveritabaniDataSet
            // 
            this.kutuphaneveritabaniDataSet.DataSetName = "kutuphaneveritabaniDataSet";
            this.kutuphaneveritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kutuphaneveritabaniDataSetBindingSource
            // 
            this.kutuphaneveritabaniDataSetBindingSource.DataSource = this.kutuphaneveritabaniDataSet;
            this.kutuphaneveritabaniDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(904, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(359, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 65);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ana Menü";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oduncalmagecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 520);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "oduncalmagecmisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Geçmişim,";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oduncalmagecmisi_FormClosing);
            this.Load += new System.EventHandler(this.oduncalmagecmisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneveritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneveritabaniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kutuphaneveritabaniDataSet kutuphaneveritabaniDataSet;
        private System.Windows.Forms.BindingSource kutuphaneveritabaniDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}