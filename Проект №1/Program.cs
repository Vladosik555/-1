using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Runtime;

namespace Проект__1
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static char[] FileText()
        {
            string path = Environment.CurrentDirectory + @"\Text.txt";
            string fileText = File.ReadAllText(path);
                char[] latters = new char[fileText.Length];
                for (int i = 0; i < fileText.Length; i++)
                {
                    latters[i] = fileText[i];
                }
                return latters;
        }
        static List<char> FileText1()
        {
            string let = Environment.CurrentDirectory + @"\Text.txt";
            string fileText = File.ReadAllText(let);
            List<char> latters1 = new List<char>();
            for (int i = 0; i < fileText.Length; i++)
            {
                latters1.Add(fileText[i]);
            }
            return latters1;
        }

        /// <summary>
        /// печатаем матрицу
        /// </summary>
        /// <param name="matrix"></param>
        static void PrintMatrix(int[,] matrix) 
         {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
         }
        /// <summary>
        /// перемножаем матрицы
        /// </summary>
        /// <param name="matrix_1"></param>
        /// <param name="matrix_2"></param>
        /// <returns></returns>
        static int[,] MultiplicationMatrix(int[,] matrix_1, int[,] matrix_2)
        {
            int number_one = matrix_1.GetLength(0);
            int number_two = matrix_1.GetLength(1);
            int number_three = matrix_2.GetLength(1);
            int[,] result = new int[number_one, number_three];
            for (int i = 0; i < number_one; i++)
            {
                for (int j = 0; j < number_three; j++)
                {
                    for (int k = 0; k < number_two; k++)
                    {
                        result[i, j] += matrix_1[i, k] * matrix_2[k, j];
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Перемножаем матрицы
        /// </summary>
        /// <param name="matrixmult"></param>
        /// <returns></returns>
        static int[,] MultiplicationMatrix1(LinkedList<int[,]> matrixmult) 
        {
            int[,] martixone = matrixmult.First.Value;
            int[,] matrixtwo = matrixmult.First.Value;
            int[,] result = new int[martixone.GetLength(0), matrixtwo.GetLength(1)];
            for (int i = 0; i < martixone.GetLength(0); i++)
            {
                for(int j = 0; j < matrixtwo.GetLength(1); j++)
                {
                    for (int m = 0; m < martixone.GetLength(1); m++)
                    {
                        result[i, j] += martixone[i, m] * matrixtwo[m, j];
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// печатаем матрицу
        /// </summary>
        /// <param name="matrix"></param>
        static void PrintMatrix1(LinkedList<LinkedList<int>> matrix)
        {
            for (int i = 0; i < matrix.ElementAt(0).Count; i++)
            {
                for (int j = 0; j < matrix.ElementAt(1).Count; j++)
                {
                    Console.Write(matrix + " ");
                }
                Console.WriteLine();
            }
        }
   
        /// <summary>
        /// создаем времена года
        /// </summary>
        enum Mounths
        {
            Январе, Феврале, Марте, Апреле, Мае, Июне, Июле, Августе, Сентябре, Октябре, Ноябре, Декабре
        }
        /// <summary>
        /// вычисляем среднюю температуру месяцев
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static double[] Mounth(int[,] array) 
        {
            double[] array1 = new double[12];
            int result = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result += array[i, j];
                }
                array1[i] = Math.Round((double)result / 30, 1);
            }
            return array1;
        }
        /// <summary>
        /// вычисляем среднюю температуру в месяце
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns></returns>
        static double[] Mounths1(Dictionary<string, int[] > degrees)
        {
            double[] array2 = new double[12];
            for (int i = 0; i < degrees.Count; i++)
            {
                array2[i] = Math.Round((double)degrees[((Mounths)i).ToString()].Sum() / 30, 1);
            }
            return array2;
        }




        static void Main(string[] args)
        {

            Console.WriteLine("Упражнение 6.1");
            Console.WriteLine("Данная прогрмма вычисляет количество гласных и согласных букв");
            char[] chars = FileText();
            string vowels = "ауоыиэяюёе";
            string consonants = "бвгджзйклмнпрстфхцчшщьъ";
            int count_vow = 0, count_conson = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (vowels.Contains(chars[i]))
                {
                    count_vow++;
                }
                else if(consonants.Contains(chars[i]))
                {
                    count_conson++;
                }
          
            }
            Console.WriteLine($"Количество гласных букв: {count_vow}");
            Console.WriteLine($"Количество согласных букв: {count_conson}");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 6.2"); 
            Console.WriteLine("Данная программа умножает 2 матрицы");
            int[,] matrix1 = new int[,]
            {
                {1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int[,] matrix2 = new int[,]
            {
                { 10, 11, 12 },
                { 13, 14, 15 },
                { 16, 17, 18 }
            };
            Console.WriteLine("Напишем первую матрицу: ");
            PrintMatrix(matrix1);
            Console.WriteLine("Напишем вторую матрицу: ");
            PrintMatrix(matrix2);
            Console.WriteLine("Умножение матриц: ");
            PrintMatrix(MultiplicationMatrix(matrix1, matrix2));          
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 6.3");
            Console.WriteLine("Данная программа показывает среднию температуру в месяце");
            int[,] temperature = new int[12,30];
            Random random = new Random();
            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    temperature[i, j] = random.Next(-25, 30);
                }
            }
            for (int y = 0; y < temperature.GetLength(0); y++)
            {
                Console.WriteLine($"В {(Mounths)y}");
                for (int x = 0; x < temperature.GetLength(1); x++)
                {
                    Console.Write(temperature[y, x] + " ");
                }
                Console.WriteLine();
            }
            int[] array_2 = new int[12];
            for (int i = 0; i < array_2.Length; i++)
            {
                Console.WriteLine($"\nВ {(Mounths)i} Средняя температура {Mounth(temperature)[i]} градусов по цельсию");
            }
            Console.WriteLine("Ддя того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Домашнее задание 6.1");
            Console.WriteLine("Данная программа считает гласные и согласные буквы c List");
            List<char> chars1 = FileText1();
            string vowels1 = "ауоыиэяюёе";
            string consonants1 = "бвгджзйклмнпрстфхцчшщьъ";
            int count_vow1 = 0, count_conson1 = 0;
            for (int i = 0; i < chars1.Count; i++)
            {
                if (vowels1.Contains(chars[i]))
                {
                    count_vow1++;
                }
                else if (consonants1.Contains(chars[i]))
                {
                    count_conson1++;
                }

            }
            Console.WriteLine($"Количество гласных букв: {count_vow1}");
            Console.WriteLine($"Количество согласных букв: {count_conson1}");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Домашнее задание 6.2");
            Console.WriteLine("Данная программа считает матрицу c ListLinked");
            LinkedList<int[,]> multmatrixx = new LinkedList<int[,]>();
            int[,] matrix3 = new int[,]
            {
                {21, 22, 23 },
                { 24, 25, 26 },
                { 27, 28, 29 }
            };
            int[,] matrix4 = new int[,]
            {
                { 30, 31, 32 },
                { 33, 34, 35 },
                { 36, 37, 38 }
            };
            multmatrixx.AddFirst(matrix3);
            Console.WriteLine("Напишем первую матрицу");
            PrintMatrix(matrix3);
            multmatrixx.AddLast(matrix4);
            Console.WriteLine("Напишем вторую матрицу");
            PrintMatrix(matrix4);
            Console.WriteLine("Перемножим матрицы");
            PrintMatrix(MultiplicationMatrix1(multmatrixx));
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            Console.WriteLine("Домашняя работа 6.3");
            Console.WriteLine("Данная программа показывает среднюю температуру с Dictionary");
            Dictionary<string, int[]> mounths1 = new Dictionary<string, int[]>();
            int[] temperature1 = new int[30];
            Random rand = new Random();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < temperature1.Length; j++)
                {
                    temperature1[i] = rand.Next(-25, 30);
                }
                mounths1.Add(((Mounths)i).ToString(), temperature1);
                temperature1 = new int[30];
            }
            foreach (var degre in mounths1)
            {
                
                for (int i = 0; i < 30; i++) 
                {

                }
            }
            double[] temp = Mounths1(mounths1);
            for (int i = 0; i < mounths1.Count; i++)
            {
                Console.WriteLine($"В {(Mounths)i} Средняя температура составляет {temp[i]}");
            }
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();





        }
    }
}