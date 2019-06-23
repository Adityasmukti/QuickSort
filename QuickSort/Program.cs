﻿using System;

namespace QuickSort
{
    class Program
    {
        private static int[] Data = new int[] { 9, 1, 5, 10, 2, 7, 4, 3, 6, 8 };
        static void Main(string[] args)
        {
            Console.WriteLine("********************** Sorting Menggunakan Metode Quick Sort **************************");
            Console.WriteLine("**************************** Program By Adityasmukti **********************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Data sebelum sorting : "+string.Join(",",Data));
            Console.WriteLine();
            Quick_Sort(Data, 0, Data.Length-1);
            Console.WriteLine("Data sesudah sorting : "+string.Join(",", Data));
            Console.ReadKey();
        }

        /*
            prosedure quick_sort(data:array[1..n] of integer,awal_data,akhir_data : interger)
         */

        private static void Quick_Sort(int[] data, int awal_data, int akhir_data)
        {
            int atas, bawah, pivot, temp;
            bawah = awal_data;
            atas = akhir_data;
            pivot = data[(awal_data+akhir_data)/2];
            while(bawah<atas)
            {
                while(data[bawah]<pivot)
                    bawah++;
                while (data[atas] > pivot)
                    atas--;
                if(bawah<=atas)
                {
                    temp = data[bawah];
                    data[bawah] = data[atas];
                    data[atas] = temp;
                    bawah++;
                    atas--;
                }
            }
            if (awal_data < atas)
                Quick_Sort(data, awal_data, atas);
            if(bawah<akhir_data)
                Quick_Sort(data, bawah, akhir_data);
        }
    }
}