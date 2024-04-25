using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_Ver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести число A - 0 \nВвести число B - 1\nВыполнить сложение - 3\nВыполнить вычитание - 4\n" +
                "Выполнить умножение - 5\nВыполнить деление - 6");
            int A = 0;
            int B = 0;
            int del = 0;

            while (true)
            {
                int sv = int.Parse(Console.ReadLine());
                if (sv == 6)
                {
                    del = A / B;
                }
                else if (sv == 1)
                {
                    B = int.Parse(Console.ReadLine());
                }
            }
        }
  }
}
