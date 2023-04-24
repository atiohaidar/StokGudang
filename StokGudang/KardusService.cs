using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokGudang
{
	public class KardusService
	{
		public KardusRepo kardusRepo = new KardusRepo();

		public KardusService() { }
		public void tambahKardus(string nama, int berat, int isi, DateTime kadaluarsa)
		{
			Kardus kardusBaru = new Kardus();
			kardusRepo.kardusID = kardusRepo.GetFreeID();//
			kardusBaru.IsiKardus(kardusRepo.kardusID, nama, berat, isi, kadaluarsa);

			kardusRepo.listKardus.Add(kardusBaru);//
			kardusRepo.SaveData();//



		}
		public Kardus getSelectedKardus(DataGridViewRowCollection dataRows)
		{

			int getID = 0;
			for (int i = 0; i < dataRows.Count; i += 1)
			{
				if (dataRows[i].Selected)
				{
					getID = int.Parse(dataRows[i].Cells[0].Value.ToString()); // buat ngambil id
					break;
				}
			}
			Kardus getKardus = new Kardus();
			foreach (Kardus checkKardus in kardusRepo.listKardus)
			{
				if (checkKardus.ID == getID)
					getKardus = checkKardus;
			}
			return getKardus;
		}
		public void hapusKardus(DataGridViewRowCollection dataRows)
		{
			Kardus getKardus = getSelectedKardus(dataRows);//
			if (kardusRepo.listKardus.Contains(getKardus))//
				kardusRepo.listKardus.Remove(getKardus);//
			kardusRepo.SaveData();//
		}
		public void editKardus(DataGridViewRowCollection dataRows, string nama, int berat, int isi, DateTime kadaluarsa)
		{
			Kardus getKardus = getSelectedKardus(dataRows);
			getKardus.EditKardus(nama, berat, isi, kadaluarsa);
			kardusRepo.SaveData();//

		}


	}
}
