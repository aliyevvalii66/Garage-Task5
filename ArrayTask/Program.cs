using System;
using System.Buffers;
using System.Diagnostics.Contracts;

namespace ArrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            //Console.Write("Arrayin uzunlugunu daxil edin : ");
            //int size = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------------------");
            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"{i + 1})Arrayin elementini daxil edin : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Arratin ilkin duzulushu----> ");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine($" {item} ");
            //}
            //CustomSort(arr);
            //Console.WriteLine("Arrayin sort methodundan sonraki duzulushu ----> ");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine($" {item} ");
            //}
            //Console.ReadKey();



            #endregion
            #region Task-2
            //string[] arr = { "salam" , "sagol" , "f" , "sd" };
            //Console.WriteLine($"Array {arr.Length} - elementlidir");
            //CustomFindLetter(arr,'s');


            #endregion
            #region Task-3
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //CustomReverse(arr);
            #endregion
        }
        static void CustomSort(int[] arr)
        {


            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0 + i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void CustomFindLetter(string[] arr, char letter)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == letter)
                    {
                        Console.WriteLine($"{i + 1}){arr[i]}");
                        break;
                    }
                }
            }
        }
        static void CustomReverse(int[] arr)
        {
            int[] tempArr = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                tempArr[j] = arr[i];
                j++;
            }
            foreach (int item in tempArr)
            {
                Console.Write($"{item} ");
            }
        }


    }
}
