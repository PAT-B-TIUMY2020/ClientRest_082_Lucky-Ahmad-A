using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest_082_Lucky_Ahmad_A
{
    class ClassData
    {
        public void getData()
        {
            var json = new WebClient().DownloadString("http://localhost:1928/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            foreach (var mhs in data)
            {
                Console.WriteLine("NIM: " + mhs.nim);
                Console.WriteLine("Nama: " + mhs.nama);
                Console.WriteLine("Prodi: " + mhs.prodi);
                Console.WriteLine("Angkatan: " + mhs.angkatan);
            }

            Console.ReadLine();
        }


    }
}