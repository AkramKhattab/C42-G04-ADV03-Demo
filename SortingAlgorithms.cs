using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G04_ADV03_Demo
{

    // Declare Delegate
    //public delegate bool ConditionFuncDelegate(int A, int B);
    //public delegate bool ConditionFuncDelegateV02(string A, string B);

    public delegate bool ConditionFuncDelegate<T>(T A, T B);


    internal class SortingAlgorithms
    {

        // Generic Version
    //    public static void BubbleSort<T>(T[] Arr, ConditionFuncDelegate<T> reference)
    //    {
    //        if (Arr is not null)
    //        {
    //            // 0
    //            for (int i = 0; i < Arr.Length; i++)
    //            {
    //                // 0 --> 9
    //                for (int j = 0; j < Arr.Length - i - 1; j++)
    //                {
    //                    if (reference.Invoke(Arr[j], Arr[j + 1]))
    //                    {
    //                        //SWAP
    //                        SWAP(ref Arr[j], ref Arr[j + 1]);
    //                    }
    //                }
    //            }

    //        }
    //    }


    //    //public static void BubbleSort(int[] Arr, ConditionFuncDelegate reference)
    //    //{
    //    //    if (Arr is not null)
    //    //    {
    //    //        // 0
    //    //        for (int i = 0; i < Arr.Length; i++)
    //    //        {
    //    //            // 0 --> 9
    //    //            for (int j = 0; j < Arr.Length - i - 1; j++)
    //    //            {
    //    //                if (reference.Invoke(Arr[j], Arr[j +1]))
    //    //                {
    //    //                    //SWAP
    //    //                    SWAP(ref Arr[j], ref Arr[j + 1]);
    //    //                }
    //    //            }
    //    //        }

    //    //    }
    //    //}

    //    //public static void BubbleSort(string[] Arr, ConditionFuncDelegateV02 reference)
    //    //{
    //    //    if (Arr is not null)
    //    //    {
    //    //        // 0
    //    //        for (int i = 0; i < Arr.Length; i++)
    //    //        {
    //    //            // 0 --> 9
    //    //            for (int j = 0; j < Arr.Length - i - 1; j++)
    //    //            {
    //    //                if (reference.Invoke(Arr[j], Arr[j + 1]))
    //    //                {
    //    //                    //SWAP
    //    //                    SWAP(ref Arr[j], ref Arr[j + 1]);
    //    //                }
    //    //            }
    //    //        }

    //    //    }
    //    //}


    //    //public static void BubbleSortAscending(int[] Arr)
    //    //{
    //    //    if (Arr is not null)
    //    //    {
    //    //        // 0
    //    //        for (int i = 0; i < Arr.Length; i++)
    //    //        {
    //    //            // 0 --> 9
    //    //            for (int j = 0; j < Arr.Length - i - 1; j++)
    //    //            {
    //    //                if (SortingFunctions.CompareGtr(Arr[j], Arr[j + 1]))
    //    //                {
    //    //                    //SWAP
    //    //                    SWAP(ref Arr[j], ref Arr[j + 1]);
    //    //                }
    //    //            }
    //    //        }

    //    //    }
    //    //}

    //    //public static void BubbleSortDescnding(int[] Arr)
    //    //{
    //    //    if (Arr is not null)
    //    //    {
    //    //        // 0
    //    //        for (int i = 0; i < Arr.Length; i++)
    //    //        {
    //    //            // 0 --> 9
    //    //            for (int j = 0; j < Arr.Length - i - 1; j++)
    //    //            {
    //    //                if (SortingFunctions.CompareLess(Arr[j], Arr[j + 1]))
    //    //                {
    //    //                    //SWAP
    //    //                    SWAP(ref Arr[j], ref Arr[j + 1]);
    //    //                }
    //    //            }
    //    //        }

    //    //    }
    //    //}



    //    //public static void BubbleSortAscending(int[] Arr) 
    //    // {
    //    //     if (Arr is not null)
    //    //     {
    //    //         // 0
    //    //         for (int i = 0; i < Arr.Length; i++)
    //    //         {
    //    //             // 0 --> 9
    //    //             for(int j = 0; j < Arr.Length - i  -1 ; j++)
    //    //             {
    //    //                 if (Arr[j] > Arr[j + 1])
    //    //                 {
    //    //                     //SWAP
    //    //                     SWAP(ref Arr[j], ref Arr[j + 1]);
    //    //                 }
    //    //             }
    //    //         }

    //    //     }
    //    // }

    //    // public static void BubbleSortDescnding(int[] Arr)
    //    // {
    //    //     if (Arr is not null)
    //    //     {
    //    //         // 0
    //    //         for (int i = 0; i < Arr.Length; i++)
    //    //         {
    //    //             // 0 --> 9
    //    //             for (int j = 0; j < Arr.Length - i - 1; j++)
    //    //             {
    //    //                 if (Arr[j] < Arr[j + 1])
    //    //                 {
    //    //                     //SWAP
    //    //                     SWAP(ref Arr[j], ref Arr[j + 1]);
    //    //                 }
    //    //             }
    //    //         }

    //    //     }
    //    // }


    //    private static void SWAP<T>(ref T X, ref T Y)
    //    {
    //        T Temp = X;
    //        X = Y;
    //        Y = Temp;
    //    }

    //    private static void SWAP(ref int X, ref int Y)
    //    {
    //        int Temp = X;
    //        X = Y;
    //        Y = Temp;
    //    }

    //    private static void SWAP(ref string X, ref string Y)
    //    {
    //        string Temp = X;
    //        X = Y;
    //        Y = Temp;
    //    }

    //}



    // class SortingFunctions
    //{
    //    public static bool SortAscending(int L, int R) { return L > R; }
    //    public static bool SortDescending(int L, int R) { return L < R; }


    //    public static bool SortAscending(string L, string R) { return L.Length > R.Length; }
    //    public static bool SortDescending(string L, string R) { return L.Length < R.Length; }
    //}




    }
