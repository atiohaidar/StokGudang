
namespace StokGudang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKadaluarsa = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTambahDus = new System.Windows.Forms.Button();
            this.numIsiDus = new System.Windows.Forms.NumericUpDown();
            this.lblIsi = new System.Windows.Forms.Label();
            this.numBeratDus = new System.Windows.Forms.NumericUpDown();
            this.lblBerat = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNamaDus = new System.Windows.Forms.TextBox();
            this.lblNamaGudang = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHapusDus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnEditDus = new System.Windows.Forms.Button();
            this.numEditDusIsi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numEditDusBerat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditDusNama = new System.Windows.Forms.TextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxKadaluarsa = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIsiDus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeratDus)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditDusIsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEditDusBerat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKadaluarsa);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnTambahDus);
            this.groupBox1.Controls.Add(this.numIsiDus);
            this.groupBox1.Controls.Add(this.lblIsi);
            this.groupBox1.Controls.Add(this.numBeratDus);
            this.groupBox1.Controls.Add(this.lblBerat);
            this.groupBox1.Controls.Add(this.lblNama);
            this.groupBox1.Controls.Add(this.txtNamaDus);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Dus";
            // 
            // lblKadaluarsa
            // 
            this.lblKadaluarsa.AutoSize = true;
            this.lblKadaluarsa.Location = new System.Drawing.Point(24, 111);
            this.lblKadaluarsa.Name = "lblKadaluarsa";
            this.lblKadaluarsa.Size = new System.Drawing.Size(80, 17);
            this.lblKadaluarsa.TabIndex = 8;
            this.lblKadaluarsa.Text = "Kadaluarsa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnTambahDus
            // 
            this.btnTambahDus.Location = new System.Drawing.Point(125, 146);
            this.btnTambahDus.Name = "btnTambahDus";
            this.btnTambahDus.Size = new System.Drawing.Size(224, 34);
            this.btnTambahDus.TabIndex = 6;
            this.btnTambahDus.Text = "Tambah Dus";
            this.btnTambahDus.UseVisualStyleBackColor = true;
            this.btnTambahDus.Click += new System.EventHandler(this.btnTambahDus_Click);
            // 
            // numIsiDus
            // 
            this.numIsiDus.Location = new System.Drawing.Point(125, 78);
            this.numIsiDus.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numIsiDus.Name = "numIsiDus";
            this.numIsiDus.Size = new System.Drawing.Size(224, 22);
            this.numIsiDus.TabIndex = 5;
            // 
            // lblIsi
            // 
            this.lblIsi.AutoSize = true;
            this.lblIsi.Location = new System.Drawing.Point(24, 80);
            this.lblIsi.Name = "lblIsi";
            this.lblIsi.Size = new System.Drawing.Size(21, 17);
            this.lblIsi.TabIndex = 4;
            this.lblIsi.Text = "Isi";
            // 
            // numBeratDus
            // 
            this.numBeratDus.Location = new System.Drawing.Point(125, 50);
            this.numBeratDus.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numBeratDus.Name = "numBeratDus";
            this.numBeratDus.Size = new System.Drawing.Size(224, 22);
            this.numBeratDus.TabIndex = 3;
            // 
            // lblBerat
            // 
            this.lblBerat.AutoSize = true;
            this.lblBerat.Location = new System.Drawing.Point(24, 52);
            this.lblBerat.Name = "lblBerat";
            this.lblBerat.Size = new System.Drawing.Size(88, 17);
            this.lblBerat.TabIndex = 2;
            this.lblBerat.Text = "Berat (gram)";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(24, 24);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(74, 17);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Dus";
            // 
            // txtNamaDus
            // 
            this.txtNamaDus.Location = new System.Drawing.Point(125, 21);
            this.txtNamaDus.Name = "txtNamaDus";
            this.txtNamaDus.Size = new System.Drawing.Size(224, 22);
            this.txtNamaDus.TabIndex = 0;
            // 
            // lblNamaGudang
            // 
            this.lblNamaGudang.AutoSize = true;
            this.lblNamaGudang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblNamaGudang.Location = new System.Drawing.Point(12, 9);
            this.lblNamaGudang.Name = "lblNamaGudang";
            this.lblNamaGudang.Size = new System.Drawing.Size(161, 46);
            this.lblNamaGudang.TabIndex = 1;
            this.lblNamaGudang.Text = "Gudang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxKadaluarsa);
            this.groupBox2.Controls.Add(this.btnHapusDus);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(373, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 386);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Kardus di Gudang";
            // 
            // btnHapusDus
            // 
            this.btnHapusDus.Location = new System.Drawing.Point(198, 341);
            this.btnHapusDus.Name = "btnHapusDus";
            this.btnHapusDus.Size = new System.Drawing.Size(560, 35);
            this.btnHapusDus.TabIndex = 1;
            this.btnHapusDus.Text = "Hapus Dus";
            this.btnHapusDus.UseVisualStyleBackColor = true;
            this.btnHapusDus.Click += new System.EventHandler(this.btnHapusDus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(19, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(739, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.btnEditDus);
            this.groupBox3.Controls.Add(this.numEditDusIsi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numEditDusBerat);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtEditDusNama);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(12, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 190);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Dus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kadaluarsa";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(125, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // btnEditDus
            // 
            this.btnEditDus.Location = new System.Drawing.Point(125, 146);
            this.btnEditDus.Name = "btnEditDus";
            this.btnEditDus.Size = new System.Drawing.Size(224, 34);
            this.btnEditDus.TabIndex = 6;
            this.btnEditDus.Text = "Edit Dus";
            this.btnEditDus.UseVisualStyleBackColor = true;
            this.btnEditDus.Click += new System.EventHandler(this.btnEditDus_Click);
            // 
            // numEditDusIsi
            // 
            this.numEditDusIsi.Location = new System.Drawing.Point(125, 78);
            this.numEditDusIsi.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numEditDusIsi.Name = "numEditDusIsi";
            this.numEditDusIsi.Size = new System.Drawing.Size(224, 22);
            this.numEditDusIsi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Isi";
            // 
            // numEditDusBerat
            // 
            this.numEditDusBerat.Location = new System.Drawing.Point(125, 50);
            this.numEditDusBerat.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numEditDusBerat.Name = "numEditDusBerat";
            this.numEditDusBerat.Size = new System.Drawing.Size(224, 22);
            this.numEditDusBerat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Berat (gram)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama Dus";
            // 
            // txtEditDusNama
            // 
            this.txtEditDusNama.Location = new System.Drawing.Point(125, 21);
            this.txtEditDusNama.Name = "txtEditDusNama";
            this.txtEditDusNama.Size = new System.Drawing.Size(224, 22);
            this.txtEditDusNama.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nama Dus";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Berat";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Isi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 42;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kadaluarsa";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // checkBoxKadaluarsa
            // 
            this.checkBoxKadaluarsa.AutoSize = true;
            this.checkBoxKadaluarsa.Location = new System.Drawing.Point(19, 349);
            this.checkBoxKadaluarsa.Name = "checkBoxKadaluarsa";
            this.checkBoxKadaluarsa.Size = new System.Drawing.Size(145, 21);
            this.checkBoxKadaluarsa.TabIndex = 2;
            this.checkBoxKadaluarsa.Text = "Check Kadaluarsa";
            this.checkBoxKadaluarsa.UseVisualStyleBackColor = true;
            this.checkBoxKadaluarsa.CheckedChanged += new System.EventHandler(this.checkBoxKadaluarsa_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblNamaGudang);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Stok Gudang";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIsiDus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeratDus)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditDusIsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEditDusBerat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKadaluarsa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTambahDus;
        private System.Windows.Forms.NumericUpDown numIsiDus;
        private System.Windows.Forms.Label lblIsi;
        private System.Windows.Forms.NumericUpDown numBeratDus;
        private System.Windows.Forms.Label lblBerat;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNamaDus;
        private System.Windows.Forms.Label lblNamaGudang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHapusDus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnEditDus;
        private System.Windows.Forms.NumericUpDown numEditDusIsi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numEditDusBerat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditDusNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox checkBoxKadaluarsa;
    }
}

