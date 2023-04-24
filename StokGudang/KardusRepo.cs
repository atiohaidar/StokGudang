using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokGudang
{
	public class KardusRepo
	{
		public List<Kardus> listKardus = new List<Kardus>();
		public int kardusID = 0;
		public void SaveData()
		{
			if (File.Exists("data.csv"))
				File.Delete("data.csv");
			StreamWriter sw = new StreamWriter("data.csv");
			sw.WriteLine("#kardusID, kardusNama, kardusBerat, kardusIsi, kardusKadaluarsa");
			foreach (Kardus getKardus in listKardus)
				sw.WriteLine(getKardus.ID.ToString() + "," + getKardus.Nama.ToString() + "," + getKardus.Berat.ToString() + "," + getKardus.Isi.ToString() + "," + getKardus.Kadaluarsa.ToString() + "");
			sw.Close();
		}
		public void LoadData()
		{
			if (File.Exists("data.csv"))
			{
				StreamReader sr = new StreamReader("data.csv");
				string line = sr.ReadLine();
				while (line != null)
				{
					if (!line.Contains("#"))
					{
						string[] strSplit = line.Split(',');
						int id = int.Parse(strSplit[0]);
						string nama = strSplit[1];
						int berat = int.Parse(strSplit[2]);
						int isi = int.Parse(strSplit[3]);
						DateTime kadaluarsa = DateTime.Parse(strSplit[4]);
						Kardus newKardus = new Kardus();
						newKardus.IsiKardus(id, nama, berat, isi, kadaluarsa);
						listKardus.Add(newKardus);
					}
					line = sr.ReadLine();
				}
				sr.Close();
			}
		}
		public int GetFreeID()
		{
			int nowID = 0;
			while (true)
			{
				bool adaYgSama = false;
				foreach (Kardus checkKardus in listKardus)
				{
					if (checkKardus.ID == nowID)
						adaYgSama = true;
				}
				if (adaYgSama)
					nowID += 1;
				else
					break;
			}
			return nowID;
		}

	}
}
