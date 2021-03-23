using System;

namespace ConsoleApp35
{
    class Program
    { 
            static void Main(int[] arr, int l, int r)
            {
                //i и j нужны для цикла
                int i = l;
                int j = r;
                int x = arr[(l + r) / 2]; //Опорная
                                          //Цикл сортировка
                while (i <= j)
                {
                    //Деление на меньше и больше опорного
                    while (arr[i] < x) i++;
                    while (arr[j] > x) j--;
                    //Если i<=j:
                    if (i <= j)
                    {
                        //меняем значение элементов
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        i++;
                        j--;
                    }
                }
                //Рекурсия
                if (l < j) Main(arr, l, j);
                if (i < r) Main(arr, i, r);
            }     
    }
}
