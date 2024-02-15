using System.Runtime.InteropServices;

namespace Lab2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(task1());
            Console.WriteLine(task2());


        }
        static string task1()
        {
            int singlearray = task1singlearray();
            int doublearray = task1doublearray();
            return $"Відповідь до одновимірного масиву {singlearray}\nВідповідь для двовимірного масиву {doublearray}";
        }
        static int task1singlearray()
        {
            Console.WriteLine("Введіть розмірність одновимірного масиву : ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введіть елемент : ");
                array[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Введіть нижню межу : ");
            int lower = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть верхню межу : ");
            int upper = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (int i in array)
            {
                if (i < lower || i > upper)
                {
                    count++;
                }
            }

            return count;
        }

        static int task1doublearray()
        {
            Console.WriteLine("Введіть розмірність двовимірного масиву : ");

            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[,] array = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("Введіть елемент: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Введіть нижню межу : ");
            int lower = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть верхню межу : ");
            int upper = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (array[i, j] < lower || array[i, j] > upper)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static int task2()
        {
            Console.WriteLine("Введіть розмір масиву : ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введіть елемент : ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = array[0];
            int lastIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (array[i] <= min)
                {
                    min = array[i];
                    lastIndex = i;
                }
            }
            return lastIndex;
        }
    }
}