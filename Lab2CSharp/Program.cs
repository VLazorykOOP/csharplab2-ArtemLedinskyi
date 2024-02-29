using System.Runtime.InteropServices;

namespace Lab2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберіть завдання (1, 2, 3 або 4):");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(task1());
                    break;
                case 2:
                    Console.WriteLine(task2());
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }

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

static void task3() {
        Console.WriteLine("Введіть размір матриці (рядок и стовбець):");
        Console.Write("Кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Кількість стовбців: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] A = new int[rows, cols];

        Console.WriteLine("Введіть елементи матриці:");


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("A[{0},{1}]: ", i, j);
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Введіть степінь: ");
        int n = int.Parse(Console.ReadLine());

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = (int)Math.Pow(A[i, j], n);
                }
            }


        Console.WriteLine("A у степені " + n + ":");
        foreach(int elements in result)
        {
            Console.WriteLine(elements+"\t");
        }

    }


static void task4()
    {
            Console.Write("Введіть кількість рядків: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість елементів у кожному рядку: ");
            int m = int.Parse(Console.ReadLine());


            int[,] array = new int[n, m];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введіть елемент масиву для рядка {i + 1} і стовпця {j + 1}: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Введіть нижню межу підсумовування (k1): ");
            int k1 = int.Parse(Console.ReadLine());

            Console.Write("Введіть верхню межу підсумовування (k2): ");
            int k2 = int.Parse(Console.ReadLine());

            int[] sums = new int[n];


            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = k1 - 1; j < k2 && j < m; j++)
                {
                    sum += array[i, j];
                }
                sums[i] = sum;
            }


            Console.WriteLine("Суми елементів від k1 до k2 для кожного ряду:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ряд " + (i + 1) + ": " + sums[i]);
            }
        }
    


    }


}
