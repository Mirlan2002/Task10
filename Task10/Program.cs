using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 6.1
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\file.txt", false, Encoding.UTF8);
            sw.Write("Привет world");
            sw.Close();

            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\file.txt", Encoding.UTF8);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            #endregion




            #region Задание 6.2
            StreamReader sr1 = new StreamReader(Directory.GetCurrentDirectory() + "\\numbers.txt", Encoding.UTF8);
            string allText = sr1.ReadToEnd();
            string[] splitted = allText.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            sr1.Close();
            double answer = 0;
            foreach(string s in splitted)
            {
                double d=0;
                double.TryParse(s, out d);
                answer += d;
            }
            Console.WriteLine(answer);
            #endregion




            #region Задание 6.4
            string[] directories = Directory.GetDirectories(Directory.GetCurrentDirectory());
            foreach (string s in directories)
                Console.WriteLine(s);

            string[] files= Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string s in files)
                Console.WriteLine(s);
            #endregion
        }
    }
}
