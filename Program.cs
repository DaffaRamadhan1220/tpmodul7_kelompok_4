using System;

namespace tpmodul7_kelompok_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103082400028 mahasiswa = new DataMahasiswa103082400028();
            mahasiswa.ReadJSON();

            KuliahMahasiswa103082400028 kuliah = new KuliahMahasiswa103082400028();
            kuliah.ReadJSON();
        }
    }
}