using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace TestEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Читаю файл...");
            List<string[]> l = new List<string[]>();
            StreamReader sr = new StreamReader("Vkusno.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                l.Add(line.Split(' '));
            }
            Console.WriteLine("Люди, вес которых кратен трем:");
            try
            {
                var a = l.Where(x => Convert.ToInt32((x[3])) % 3 == 0);
                foreach (string[] needed in a)
                {
                    Console.WriteLine(string.Join(" ", needed));
                }
            }
            catch { Console.WriteLine("Ошибка! Неверные данные"); }
            sr.Close();
            Console.Write("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }
    }
}
