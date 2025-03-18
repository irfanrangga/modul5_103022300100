using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300100
{
    internal class SimpleDatabase<T>
    {
        List<T> storedData;
        List<DateTime> inputDates = new List<DateTime>();

        public SimpleDatabase()
        {
            this.storedData = new List<T>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            int i = 0;
            foreach (T data in storedData)
            {
                Console.WriteLine("Data " + (i+1) + " berisi: " + data + ", yang disimpan pada waktu " + inputDates.ElementAt(i));
                i++;
            }
        }
    }
}
