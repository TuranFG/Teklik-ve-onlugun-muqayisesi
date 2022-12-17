using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int teklik = number % 10;
            int onluq = (number - teklik) % 100 /10;

            Console.WriteLine(teklik);
            Console.WriteLine(onluq);

            if (teklik > onluq) Console.WriteLine("teklik onluqdan boyukdur");
            else Console.WriteLine("onluq teklikden boyukdur");
        }
    }
}
