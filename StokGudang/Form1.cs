using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// Referensi/Project Awal By: https://www.youtube.com/watch?v=KDNRAScWMMo&list=PLcirg7O5Myxp43qXVGTmApDUbWwInmuw9&index=11
// keterangan: ini udah dibagi bagi yang menurutku tiap fungsinnya udah spesifik ngerjaiin itu aja, ga ngurus yang lain. tanggung jawanya udah dipisah
namespace StokGudang
{
    public partial class Form1 : Form
    {
        public KardusService kardusService = new KardusService();


		public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kardusService.kardusRepo.LoadData();
            RefreshDataGrid();
        }

       
        

        private void RefreshDataGridKadaluarsa()
        {
            dataGridView1.Rows.Clear();
            foreach (Kardus getKardus in kardusService.kardusRepo.listKardus)
            {
                if ((getKardus.Kadaluarsa - DateTime.Now).TotalDays <= 0)
                {
                    string[] newRow = { "", "", "", "", "" };
                    newRow[0] = getKardus.ID.ToString();
                    newRow[1] = getKardus.Nama;
                    newRow[2] = getKardus.Berat.ToString();
                    newRow[3] = getKardus.Isi.ToString();
                    newRow[4] = getKardus.Kadaluarsa.ToString();
                    dataGridView1.Rows.Add(newRow);
                }
            }
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Kardus getKardus in kardusService.kardusRepo.listKardus)
            {
                string[] newRow = { "", "", "", "", "" };
                newRow[0] = getKardus.ID.ToString();
                newRow[1] = getKardus.Nama;
                newRow[2] = getKardus.Berat.ToString();
                newRow[3] = getKardus.Isi.ToString();
                newRow[4] = getKardus.Kadaluarsa.ToString();
                dataGridView1.Rows.Add(newRow);
            }
        }

       

        private void btnTambahDus_Click(object sender, EventArgs e)
        {
            kardusService.tambahKardus(txtNamaDus.Text, (int)numBeratDus.Value, (int)numIsiDus.Value, dateTimePicker1.Value);
            RefreshDataGrid();
        }

       

        private void btnHapusDus_Click(object sender, EventArgs e)
        {
            kardusService.hapusKardus(dataGridView1.Rows);
            RefreshDataGrid();
			
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Kardus getKardus = kardusService.getSelectedKardus(dataGridView1.Rows);
			groupBox3.Enabled = true;
            txtEditDusNama.Text = getKardus.Nama;
            numEditDusBerat.Value = getKardus.Berat;
            numEditDusIsi.Value = getKardus.Isi;
            dateTimePicker2.Value = getKardus.Kadaluarsa;
        }

        private void btnEditDus_Click(object sender, EventArgs e)
        {
            
            kardusService.editKardus(dataGridView1.Rows,txtEditDusNama.Text, (int)numEditDusBerat.Value, (int)numEditDusIsi.Value, dateTimePicker2.Value);
            RefreshDataGrid();
			
            groupBox3.Enabled = false;
        }

        private void checkBoxKadaluarsa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKadaluarsa.Checked)
                RefreshDataGridKadaluarsa();
            else
                RefreshDataGrid();
        }
    }
}
