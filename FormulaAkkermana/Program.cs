using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaAkkermana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int m = Convert.ToInt32(Console.ReadLine());
            A(m, n);// вызов метода
            Console.WriteLine($"{A(m,n)}");
            Console.ReadKey();
        }
        static int  A(int n, int m)//метод работы формулой 
        {
            if(m==0)// условия формулы
            {
                return n + 1;
            }
            if (m>0 && n==0)
            {
                return A(m - 1, 1);
            }
            if (m>0 && n>0)
            {
                return A(m - 1, A(m, n - 1));
            }
            else
            { 
                return A(m, n); 
            }
            
        }
    }
}
