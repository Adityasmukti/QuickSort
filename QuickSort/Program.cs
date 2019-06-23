using System;

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
            Console.WriteLine("Data sebelum sorting : "+string.Join(",",Data));//Menampilkan data sebelum Sorting
            Console.WriteLine();
            Quick_Sort(Data, 0, Data.Length-1);//Memanggil prosedur Quick_Sort
            Console.WriteLine("Data sesudah sorting : "+string.Join(",", Data));//Menampilkan data sesudah sorting
            Console.ReadKey();
        }

        /*
            prosedure quick_sort(data:array[1..n] of integer,awal_data,akhir_data : interger)            deklarasi                atas    : integer                bawah   : integer                pivot   : integer                temp    : integer            deskripsi                bawah   <– awal_data                atas    <– akhir_data                pivot   <– data[(awal_data+akhir_data)/2)]                while bawah <= atas do                    while data[bawah] < pivot do                         inc(bawah)                     end while                    while data[atas] > pivot do                         dec(atas)                     end while                    if bawah <= atas then                        temp <– data[bawah]                        data[bawah] <– data[atas]                        data[atas] <– temp                        inc (bawah)                        dec (atas)                    end if                end while                if awal_data < atas then                     quick_sort (data:array[1..n] of integer,awal_data,atas)                 end if                if bawah < akhir_data then                     quick_sort (data:array[1..n] of integer,bawah, akhir_data)                 end if            end prosedure
         */

        private static void Quick_Sort(int[] data, int awal_data, int akhir_data)
        {
            int atas, bawah, pivot, temp;//Deklarasi variabel Interger
            bawah = awal_data;
            atas = akhir_data;
            pivot = data[(awal_data+akhir_data)/2];//masukan data index awal_data+akhir_data/2
            while(bawah<atas)
            {
                while(data[bawah]<pivot)//selama data index bawah lebih kecil dengan pivot/tengah
                    bawah++;//tambah nilai bawah
                while (data[atas] > pivot)//selama data index atas lebih besar dengan pivot/tengah
                    atas--;//tambah nilai atas
                if(bawah<=atas)//jika index array 'bawah' lebih kecil dari 'atas' makan tukar data
                {
                    temp = data[bawah];
                    data[bawah] = data[atas];
                    data[atas] = temp;
                    bawah++;
                    atas--;
                }
            }
            if (awal_data < atas)
                Quick_Sort(data, awal_data, atas);//memanggil kembali prosedur quick sort atau sering di sebut rekursif prosedur
            if(bawah<akhir_data)
                Quick_Sort(data, bawah, akhir_data);//memanggil prosedur quick sort
        }
    }
}
