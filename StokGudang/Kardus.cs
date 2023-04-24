using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokGudang
{
    public class Kardus
    {
        private string nama;
        private int berat;
        private int isi;
        private DateTime kadaluarsa;
        private int id;

        public int ID { get => id; }
        public string Nama { get => nama; }
        public int Berat { get => berat; }
        public int Isi { get => isi; }
        public DateTime Kadaluarsa { get => kadaluarsa; }

        public void EditKardus(string getNama, int getBerat, int getIsi, DateTime getKadaluarsa)
        {
            this.nama = getNama;
            this.berat = getBerat;
            this.isi = getIsi;
            this.kadaluarsa = getKadaluarsa;
        }

        public void CheckKadaluarsa()
        {
            throw new System.NotImplementedException();
        }

        public void IsiKardus(int getId, string getNama, int getBerat, int getIsi, DateTime getKadaluarsa)
        {
            this.id = getId;
            this.nama = getNama;
            this.berat = getBerat;
            this.isi = getIsi;
            this.kadaluarsa = getKadaluarsa;
        }
    }
}