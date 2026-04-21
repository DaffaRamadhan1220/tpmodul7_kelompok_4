using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class MataKuliah
{
	public string kode { get; set; }
	public string nama { get; set; }
}

public class KuliahMahasiswa12345678
{
	public List<MataKuliah> mata_kuliah { get; set; }

	public static void ReadJSON()
	{
		string json = File.ReadAllText("tp7_2_103082400006.json");
		KuliahMahasiswa12345678 data = JsonConvert.DeserializeObject<KuliahMahasiswa12345678>(json);

		Console.WriteLine("Daftar mata kuliah yang diambil:");

		int i = 1;
		foreach (var mk in data.mata_kuliah)
		{
			Console.WriteLine($"MK {i} {mk.kode} - {mk.nama}");
			i++;
		}
	}
}