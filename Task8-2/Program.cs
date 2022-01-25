using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_2
{
    // Программно создайте текстовый файл и запишите в него 10 случайных чисел.
    // Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
    class Program
    {
        static void Main(string[] args)
        {
            // Создаю файл
            string path = "file.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            // Записываю в него 10 случайных чисел
            using (StreamWriter tenNumbers = new StreamWriter(path))
            {
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                    tenNumbers.WriteLine(random.Next(0, 100));                
            }
            // Програмно открываю файл и считаю сумму

            using (StreamReader sumNumbers = new StreamReader(path))
            {
                string [] array = new string[10];
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    array[i] = sumNumbers.ReadLine();
                    sum += Convert.ToInt32(array[i]);
                }
                Console.WriteLine(sum);  
             }
            Console.ReadKey();
        }
    }
}
