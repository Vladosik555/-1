using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Проект__2
{
    struct students
    {
        public string sername;
        public string name;
        public string birthday;
        public string exam;
        public int ball;
    }
    /*
    static void Students(string[] students) 
    {
        
    }
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Задание номер 1");
            Console.WriteLine("Данная прогрмма перемешивает номера картинок");
            List<int> picture = new List<int>();
            for (int i = 0; i < 24; i++)
            {
                int tmp = picture[24];
                picture.RemoveAt(0);
                picture.Insert(random.Next(picture.Count), tmp);
                Console.WriteLine(picture[i]);
            }
            Console.ReadKey();
            // данная команда позволяет перемешивать коллекцию
            
            

        }
    }
}
