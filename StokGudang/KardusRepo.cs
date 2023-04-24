using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;

namespace StokGudang
{
	public class KardusRepo
	{
		string conString = "server=127.0.0.1;database=apkgudang;uid=root;pwd=;";
		MySqlConnection myConnection;

		public List<Kardus> listKardus = new List<Kardus>();
		public int kardusID = 0;
		public bool mySqlConnect()
		{
			myConnection = new MySqlConnection(conString);
			try
			{
				myConnection.Open();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;

			}

		}
		public void mySqlClose()
		{
			myConnection.Close();
			Console.Write("berhsil aterputus");

		}
		public string checkConnection()
		{
			myConnection = new MySqlConnection(conString);
			try
			{

				myConnection.Open();
				myConnection.Close();
				return "berhasil";
			}
			catch (Exception ex)
			{
				return ex.Message;

			}
		}
		public void SaveData()
		{
			if (mySqlConnect())
			{
				string query = "delete from kardus";
				try
				{

					var cmd = new MySqlCommand(query, myConnection);
					var reader = cmd.ExecuteNonQuery();
					foreach (Kardus getKardus in listKardus)
					{
						query = string.Format("insert into kardus values('{0}', '{1}', '{2}', '{3}', '{4}' )", getKardus.ID.ToString(), getKardus.Nama.ToString(), getKardus.Berat.ToString() ,getKardus.Isi.ToString(), getKardus.Kadaluarsa.ToString() ) ;
						 cmd = new MySqlCommand(query, myConnection);
						 reader = cmd.ExecuteNonQuery();

					}
						
				}
				catch (MySqlException ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
				mySqlClose();
			}

		
		}
		public void LoadData()
		{
			
			if (mySqlConnect())
			{
				String query = "select * from kardus";
				var cmd = new MySqlCommand(query, myConnection);
				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					int id = reader.GetInt32(0); // 0 itu index nya
					string nama = reader.GetString(1);
					int berat = reader.GetInt32(2);
					int isi = reader.GetInt32(3);
					DateTime kadaluarsa = reader.GetDateTime(4);
					Kardus newKardus = new Kardus();
					newKardus.IsiKardus(id, nama, berat, isi, kadaluarsa);
					listKardus.Add(newKardus);


				}

				mySqlClose();


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
