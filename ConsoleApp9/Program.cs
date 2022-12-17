using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int hasil = 1;
            //int count = 0;

            //while (a != 0)
            //{
            //    sum = sum + a % 10;
            //    hasil = hasil * (a % 10);
            //    a /= 10;
            //    count++;
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(hasil);
            //Console.WriteLine(count);



            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{ arr[i] = int.Parse(Console.ReadLine()); }

            //int max = arr[0];
            //int min = arr[0];
            ////int maxIndex;
            ////int minIndex;
            //int temp;
            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        //maxIndex = i;
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //        //minIndex = i;
            //    }
            //}
            ////temp = arr[maxIndex];
            ////arr[maxIndex] = arr[minIndex];
            ////arr[minIndex] = temp;
            //Console.WriteLine("max" + max);
            //Console.WriteLine("min" + min);


            //temp = max;
            //max = min;
            //min = temp;

            //Console.WriteLine("max" + max);
            //Console.WriteLine("min" + min);


            //for (int i = 0; i < n; i++)
            //    Console.WriteLine(arr[i] + " ");



            int number = int.Parse(Console.ReadLine());
            int teklik = number % 10;
            
            int onluq = number / 10 % 10;
        

            Console.WriteLine(teklik);
            Console.WriteLine(onluq);

            if (teklik > onluq) Console.WriteLine("teklik onluqdan boyukdur");
            else Console.WriteLine("onluq teklikden boyukdur");


        }


    }
    }

