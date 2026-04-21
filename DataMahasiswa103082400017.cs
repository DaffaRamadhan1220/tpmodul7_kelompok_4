using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103082400017
{
    public string Nama { get; set; }
    public string Nim { get; set; }
    public string Fakultas { get; set; }

    public void ReadJSON()
    {
        string jsonFileName = "tp7_1_103082400017.json";

        if (!File.Exists(jsonFileName))
        {
            Console.WriteLine($"File {jsonFileName} tidak ditemukan!");
            Console.WriteLine($"Current directory: {Environment.CurrentDirectory}");
            return;
        }

        string jsonString = File.ReadAllText(jsonFileName);

        var data = JsonSerializer.Deserialize<DataMahasiswa103082400017>(jsonString);

        Console.WriteLine($"Nama {data.Nama} dengan nim {data.Nim} dari fakultas {data.Fakultas}");
    }
}