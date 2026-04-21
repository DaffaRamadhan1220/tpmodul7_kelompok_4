using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class MataKuliah
{
	public string kode { get; set; }
	public string nama { get; set; }
}

public class DataMatkul103082400047
{
	public List<MataKuliah> mata_kuliah { get; set; }

	public void ReadJSON()
	{
		string jsonFileName = "tp7_2_103082400047.json";

		if (!File.Exists(jsonFileName))
		{
			Console.WriteLine($"File {jsonFileName} tidak ditemukan!");
			Console.WriteLine($"Current directory: {Environment.CurrentDirectory}");
			return;
		}

		string jsonString = File.ReadAllText(jsonFileName);

		var data = JsonSerializer.Deserialize<DataMatkul103082400047>(jsonString);

		Console.WriteLine("Daftar mata kuliah yang diambil:");

		int i = 1;
		foreach (var mk in data.mata_kuliah)
		{
			Console.WriteLine($"MK {i} {mk.kode} - {mk.nama}");
			i++;
		}
	}
}