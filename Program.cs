// // Демонстрация решения
// // 1. Создать массив
// // 2. Заполнить массив
// // 3. Печать массива
// // 4. Задание пользователем количества строк и столбцов в массиве.
// // 5. Умножение массива (матрицы) на число (10)

// // Задача 47. Задайте двумерный массив размером m×n, 
// //заполненный случайными вещественными числами.

// // m = 3, n = 4.

// // 0,5 7 -2 -0,2

// // 1 -3,3 8 -9,9

// // 8 7,8 -7,1 9


// // 1. Создать массив
// // double[,] a = new double[5, 10];
// double[,] CreateArray(int rows, int columns)
// {
//     return new double[rows, columns];
// }

// // 2. Заполнить массив
// void Fill(double[,] array, double minValue, double maxValue)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);
//     Random random = new Random();
//     for (int row = 0; row < rows; row++)
//     {
//         for (int column = 0; column < columns; column++)
//         {
//             array[row, column] = random.NextDouble();
//             // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         }
//     }
// }

// // 3. Печать массива
// void Print(double[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);

//     for (int row = 0; row < rows; row++)
//     {
//         for (int column = 0; column < columns; column++)
//         {
//             //Console.Write($"{array[row, column],5}");
//             Console.Write($"\t{array[row, column],6:F2}");
//             //($"Bill total:\t{billTotal,8:c}")
//         }
//         Console.WriteLine();
//     }
// }

// // 4. Задание пользователем количества строк и столбцов в массиве 
// // (с защитой от некорретного ввода данных).

// int Input(string text)
// {
//     bool f = false;
//     int number = 0;
//     while (!f)
//     {
//         System.Console.Write(text);
//         string str = Console.ReadLine();
//         f = int.TryParse(str, out number);
//     }
//     return number;
// }


// void Task()
// {
//     int m = Input("rows:");
//     int n = Input("columns:");

//     if (m >= 0 && n >= 0)
//     {
//         double[,] matrix = CreateArray(m, n);
//         Fill(matrix, 0, 1);
//         Print(matrix);
//         Console.WriteLine();

//     }
// }

// Task();

/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

double[,] a = new double[3, 4];

Random Random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = Random.NextDouble() * 100; 
        // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}

// push an existing repository from the command line
// git remote add origin https://github.com/AMORE76/August-2022.git
// git branch -M main
// git push -u origin main
