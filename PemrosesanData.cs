using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300100
{
    internal class PemrosesanData
    {
        public static void DapatkanNilaiTerbesar<T>(T a, T b, T c)
        {
            dynamic data1 = a;
            dynamic data2 = b;
            dynamic data3 = c;

            dynamic dataMax = data1;
            if(data2 > dataMax)
            {
                dataMax = data2;
            } else if(data3 > dataMax)
            {
                dataMax = data3;
            }

            Console.WriteLine("Nilai Terbesar: " + dataMax);
        }
    }
}
