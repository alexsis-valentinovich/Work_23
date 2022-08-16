using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.    Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n=Convert.ToInt32(Console.ReadLine());
            FactorilAsync(n);
            int f1 = 1;
            for (int i = 1; i <= n; i++)
            {
                f1 *= i;
                Console.WriteLine("Промежуточный факториал числа = {0}", f1);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine("Факториал числа = {0}", f);
        }
        static async void FactorilAsync (int n)
        {
            await Task.Run(()=> Factorial (n));
        }
    }
}
