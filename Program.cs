using System;

namespace tpmodul7_kelompok_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103082400040 mahasiswa = new DataMahasiswa103082400040();
            mahasiswa.ReadJSON();
            KuliahMahasiswa103082400040.ReadJSON();
        }
    }
}