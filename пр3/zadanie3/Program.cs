using System;

namespace zadanie3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("#1"); // Нахождение минимального по модулю элемента массива
            int[] array = { 10, -3, -5, 2, 5 };
            int min = 214748364;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < min) // Проверка на логику
                {
                    min = Math.Abs(array[i]);
                    index = i;
                }

            }
            Console.WriteLine(index);
            Console.WriteLine("#2"); // Поиск повторяющихся эл-тов в массиве
            int[] massiv = { 1, 5, 2, 1, 2, 3 };
            int count = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                for (int j = 0; j < massiv.Length; j++)
                {
                    if (massiv[i] == massiv[j]) // Поиск одинаковых и подсчет их кол-ва
                    {
                        count++;
                    }
                }
                if (count == 1) // Выявление эл-тов без повторений
                {
                    Console.Write(massiv[i] + " ");
                }
                count = 0;
            }
            Console.WriteLine("#3");
            Console.Write("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] random = new int[N];
            Random r1 = new Random();
            count = 0;
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < N; i++)
            {
                random[i] = r1.Next(-50, 50);
                Console.Write(random[i] + " ");
                if (random[i] < 0)
                {

                    count++;
                }

            }
            
            int[] ready = new int[N-count];
            int f = 0;
            for (int i = 0; i < N; i++)
            {
                if (random[i] >= 0)
                {
                    ready[f] = random[i];
                    f++;
                }
            }
            Console.WriteLine("Отредактированный массив: ");
            for (int i = 0; i < N - count; i++)
            {
                Console.Write(ready[i] + " ");
            }
        }
    }
}