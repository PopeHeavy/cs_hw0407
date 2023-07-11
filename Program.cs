/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
 по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

// int[,] userArr = Create2DArr(new Random().Next(2, 10), new Random().Next(2, 10));
// Console.WriteLine("Initial Array:");
// ShowArray(userArr);
// Console.WriteLine("Sorting Result");
// ShowArray(ArraySorter(userArr));

// int[,] Create2DArr(int rows, int columns, int minVal = 0, int maxVal = 9)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minVal, maxVal + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] showArray)
// {
//     for (int i = 0; i < showArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showArray.GetLength(1); j++)
//         {
//             Console.Write(showArray[i, j] + " ");
//         }
//         Console.WriteLine(" ");
//     }
// }

// int[,] ArraySorter(int[,] sortArray)
// {
//     int pass = 0;
//     for (int i = 0; i < sortArray.GetLength(0); i++)
//     {
//         for (int j = 1; j < sortArray.GetLength(1); j++)
//         {
//             if (sortArray[i, j] > sortArray[i, j - 1])
//             {
//                 (sortArray[i, j], sortArray[i, j - 1]) = (sortArray[i, j - 1], sortArray[i, j]);
//                 pass += 1;
//             }
//             if (j == (sortArray.GetLength(1) - 1) && pass != 0)
//             {
//                 j = 0;
//                 pass = 0;
//             }
//         }
//         pass = 0;
//     }
//     return sortArray;
// }

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
 находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

// int[,] array = Create2DArr(10, 10);
// ShowArray(array);
// MinLine(array);

// int[,] Create2DArr(int rows, int columns, int minVal = 0, int maxVal = 9)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minVal, maxVal + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] showArray)
// {
//     for (int i = 0; i < showArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showArray.GetLength(1); j++)
//         {
//             Console.Write(showArray[i, j] + " ");
//         }
//         Console.WriteLine(" ");
//     }
// }

// void MinLine(int[,] procArray)
// {
//     int[] sum = new int[procArray.GetLength(0)];
//     for (int i = 0; i < procArray.GetLength(0); i++)
//         for (int j = 0; j < procArray.GetLength(1); j++)
//             sum[i] += procArray[i, j];
//     int min = 0;
//     for (int i = 1; i < sum.Length; i++)
//         if (sum[i] < sum[i - 1]) min = i;
//     Console.WriteLine($"Line with smallest sum is {min + 1}");
// }



/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

// int[,] array1 = Create2DArr(5, 5);
// int[,] array2 = Create2DArr(5, 5);
// Console.WriteLine("Array 1:");
// ShowArray(array1);
// Console.WriteLine("Array 2:");
// ShowArray(array2);

// Console.WriteLine("Result");
// ShowArray(ArrayMultiply(array1, array2));

// int[,] Create2DArr(int rows, int columns, int minVal = 0, int maxVal = 9)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minVal, maxVal + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] showArray)
// {
//     for (int i = 0; i < showArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < showArray.GetLength(1); j++)
//         {
//             Console.Write(showArray[i, j] + " ");
//         }
//         Console.WriteLine(" ");
//     }
// }


// int[,] ArrayMultiply(int[,] arr1, int[,] arr2)
// {
//     int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
//     if (arr1.GetLength(1) != arr2.GetLength(0))
//     {
//         Console.WriteLine("Can't multiply");
//         return result;
//     }
//     int sum = 0;
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr1.GetLength(1); k++)
//             {
//                 sum += (arr1[i, k] * arr2[k, j]);
//             }
//             result[i, j] = sum;
//             sum = 0;
//         }
//     }
//     return result;
// }


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

// Show3dArray(Create3DArr(2, 2, 2));

// int[,,] Create3DArr(int rows, int columns, int depth)
// {
//     int[,,] createdArray = new int[rows, columns, depth];
//     int[] randomNumber = UniqueNumber(rows * columns * depth, 100);
//     int count = 0;
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             for (int k = 0; k < depth; k++)
//             {
//                 createdArray[i, j, k] = randomNumber[count];
//                 count++;
//             }
//     return createdArray;
// }

// void Show3dArray(int[,,] arrToShow)
// {
//     for (int k = 0; k < arrToShow.GetLength(2); k++)
//     {
//         for (int i = 0; i < arrToShow.GetLength(0); i++)
//         {
//             for (int j = 0; j < arrToShow.GetLength(1); j++)
//             {
//                 Console.Write($"{arrToShow[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine("");
//         }
//     }
// }

// int[] UniqueNumber(int length, int digits)
// {
//     int[] numbers = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         numbers[i] = new Random().Next(digits / 10, digits);
//         for (int j = i; j > 0; j--)
//             if (numbers[i] == numbers[j - 1])
//             {
//                 i -= 1;
//                 break;
//             }
//     }
//     return numbers;
// }

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

// ShowHelixArray(Helix(4, 4));
// Console.WriteLine(" ");


// void ShowHelixArray(int[,] arrToShow)
// {
//     for (int i = 0; i < arrToShow.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrToShow.GetLength(1); j++)
//         {
//             if (arrToShow[i, j] / 10 == 0)
//                 Console.Write("0" + arrToShow[i, j] + " ");
//             else
//                 Console.Write(arrToShow[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// int[,] Helix(int rows, int columns)
// {
//     int[,] result = new int[rows, columns];
//     int minColumns = 0;
//     int maxColumns = result.GetLength(1) - 1;
//     int minRows = 0;
//     int maxRows = result.GetLength(0) - 1;
//     int count = 1;

//     while (count <= rows * columns)
//     {
//         for (int i = minColumns; i < maxColumns + 1; i++){
//             result[minColumns, i] = count;
//             count++;
//         }
//         for (int i = minRows + 1; i < maxRows; i++){
//             result[i, maxColumns] = count;
//             count++;
//         }
//         for (int i = maxColumns; i > minColumns; i--){
//             result[maxRows, i] = count;
//             count++;
//         }
//         for (int i = maxRows; i > minRows; i--){
//             result[i, minColumns] = count;
//             count++;
//         }

//         minColumns++;
//         maxColumns--;
//         minRows++;
//         maxRows--;
//     }
//     return result;
// }
