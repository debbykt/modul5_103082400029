using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Generic method

namespace modul5_103082400029
{
    class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic x = a;
            dynamic y = b;
            dynamic z = c;
            return x + y + z;
        }
    }
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine(
                    $"Data {i + 1} berisi : {storedData[i]}, disimpan pada waktu : {inputDates[i]}"
                );
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Penjumlahan p = new Penjumlahan();

            long a = 10;
            long b = 30;
            long c = 82;

            var hasil = p.JumlahTigaAngka(a, b, c);

            Console.WriteLine("Hasil : " + hasil);

            SimpleDataBase<long> db = new SimpleDataBase<long>();

            db.AddNewData(10);
            db.AddNewData(30);
            db.AddNewData(82);

            db.PrintAllData();

        }
    }
}
