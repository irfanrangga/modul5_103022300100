using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300100
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            PemrosesanData.DapatkanNilaiTerbesar<long>(10, 30, 20);
            SimpleDatabase<long> db = new SimpleDatabase<long>();
            db.AddNewData(10);
            db.AddNewData(30);
            db.AddNewData(20);
            db.PrintAllData();
        }
    }
}
