using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Assembly.GetEntryAssembly().Location;
            string filename = "FileForTask2.txt";
            Random rnd = new Random();
            long sum=0;
            int count = 10;
            using (var tw = new StreamWriter(filename))
            {
                for (int i = 0; i< count; i++)
                {
                    int num=rnd.Next();
                    tw.WriteLine(num);
                }
            }
            using (var tw = new StreamReader(filename))
            {
                for (int i = 0; i< count; i++)
                {
                    int num = Convert.ToInt32(tw.ReadLine());
                    sum += num;
                }
            }
            Console.WriteLine("Сумма десяти чисел в файле равна "+sum);
            Console.ReadKey();
        }
    }
}
