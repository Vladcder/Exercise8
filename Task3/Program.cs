using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filename = "FileForTask3.txt";
            int numberOfLines=0;
            int numberOfWords=0;
            int numberOfChars=0;
            string delim = " ,."; 
           

            using (var tw = new StreamReader(filename))
            {
                while (!tw.EndOfStream)
                {
                    var line= tw.ReadLine();
                    numberOfChars += line.Length;
                    line.Trim();
                    var fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    numberOfWords += fields.Length;
                    numberOfLines++;

                }
            }
            Console.WriteLine("Количество строк равно " +numberOfLines+"\nКоличество слов равно "+numberOfWords+"\nКоличество символов с проблеами равно "+numberOfChars);
            Console.ReadKey();

        }
    }
}
