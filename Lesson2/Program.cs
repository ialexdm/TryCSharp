using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1. Задать целочисленный массив, состоящий из элементов 0 и 1. Например: [ 1, 1, 0, 0, 1, 0, 1, 1, 0, 0 ]. С помощью цикла и условия заменить 0 на 1, 1 на 0;
            const int ARRAY_SIZE = 8;

            int[] binaryArray = GenerateArray(ARRAY_SIZE, 2);
            ReverseOnesAndZeros(binaryArray);

            //  2. Задать пустой целочисленный массив размером 8. С помощью цикла заполнить его значениями 0 3 6 9 12 15 18 21;
            int[] eightNumbers = new int[ARRAY_SIZE];
            for (int i = 0; i < eightNumbers.Length; i++)
            {
                eightNumbers[i] = i * 3;
            }

            //  3. Задать массив[1, 5, 3, 2, 11, 4, 5, 2, 4, 8, 9, 1] пройти по нему циклом, и числа меньшие 6 умножить на 2;
            int[] numbers = { 1, 5, 3, 2, 11, 4, 5, 2, 4, 8, 9, 1 };
            MultyplyNumbersLessNumber(array: numbers, number: 6, multiplier: 2);

            //  4. Создать квадратный двумерный целочисленный массив(количество строк и столбцов одинаковое),
            //  и с помощью цикла(-ов) заполнить его диагональные элементы единицами;
            int[,] squareArray = new int[ARRAY_SIZE, ARRAY_SIZE];
            FillDiagonals(squareArray);

            //  5. ** Задать одномерный массив и найти в нем минимальный и максимальный элементы(без помощи интернета);
            int[] array = GenerateArray(size: ARRAY_SIZE, maxValue: ARRAY_SIZE);
            int min = Min(array);
            int max = Max(array);
            
            //  6. ** Написать метод, в который передается не пустой одномерный целочисленный массив, метод должен вернуть true,
            //  если в массиве есть место, в котором сумма левой и правой части массива равны.Примеры: checkBalance([2, 2, 2, 1, 2, 2, || 10, 1]) → true,
            //  checkBalance([1, 1, 1, || 2, 1]) → true, граница показана символами ||, эти символы в массив не входят.
            CheckBalance(array);

            //  7. **** Написать метод, которому на вход подается одномерный массив и число n (может быть положительным, или отрицательным),
            //  при этом метод должен сместить все элементы массива на n позиций.
            //  Элементы смещаются циклично.Для усложнения задачи нельзя пользоваться вспомогательными массивами.
            //  Примеры: [ 1, 2, 3 ] при n = 1(на один вправо)-> [3, 1, 2];[ 3, 5, 6, 1] при n = -2(на два влево)-> [6, 1, 3, 5].
            //  При каком n в какую сторону сдвиг можете выбирать сами.
            SwitchArray(array, -1);

        }

        static int[] GenerateArray(int size, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(maxValue);
            }
            return array;
        }
        static void ReverseOnesAndZeros(int[] binaryArray)
        {
            for (int i = 0; i < binaryArray.Length; i++)
            {
                if (binaryArray[i] == 0)
                {
                    binaryArray[i] = 1;
                }
                else if (binaryArray[i] == 1)
                {
                    binaryArray[i] = 0;
                }
            }
        }

        static void MultyplyNumbersLessNumber(int[] array, int number, int multiplier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < number)
                {
                    array[i] *= multiplier;
                }
            }
        }

        static void FillDiagonals(int[,] squareArray)
        {
            for (int i = 0; i < squareArray.GetLength(0); i++)
            {
                squareArray[i, i] = 1;
                squareArray[i, squareArray.GetLength(0) - i - 1] = 1;
            }
        }
        static int Min(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static bool CheckBalance(int[] array)
        {
            int leftSum, rightSum;
            bool hasBalance = false;
            for (int i = 1; i < array.Length; i++)
            {
                leftSum = rightSum = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i > j)
                    {
                        leftSum += array[j];
                    }
                    else
                    {
                        rightSum += array[j];
                    }
                }
                if (leftSum == rightSum)
                {
                    hasBalance = true;
                    break;
                }
            }
            return hasBalance;
        }

        static void SwitchArray(int[] array, int count)
        {
            if (count < 0)
            {
                for (int i = 0; i < count * (-1); i++)
                {
                    SwitchLeft(array);
                }
            }
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    SwitchRight(array);
                }
            }
        }
        static void SwitchLeft(int[] array)
        {
            int tmp;
            tmp = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }
            array[array.Length - 1] = tmp;
        }
        static void SwitchRight(int[] array)
        {
            int tmp;
            tmp = array[array.Length - 1];
            for (int i = array.Length - 2; i >= 0; i--)
            {
                array[i + 1] = array[i];
            }
            array[0] = tmp;
        }


    }
}
