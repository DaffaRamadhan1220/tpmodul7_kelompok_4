using System;

namespace tpmodul7_kelompok_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103082400047 mahasiswa = new DataMahasiswa103082400047();
            mahasiswa.ReadJSON();

            Console.WriteLine(); 

            DataMatkul103082400047 matkul = new DataMatkul103082400047();
            matkul.ReadJSON();

            Console.ReadKey();
        }
    }
}