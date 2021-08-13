using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjetoSoftware
{
    class Program
    {
        static void Marca(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 10;
            int d = 10;
            Calculadora calc = new Calculadora();
            int r = calc.Soma(a, b);
            int r2 = calc.Soma(c, d);
            Console.Writeline("A soma de a com b é igual a: " a, b, r);
            Console.Writeline("A soma de a com b é igual a: " c, d, r2);
            Console.ReadLine();
        }
        private static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}