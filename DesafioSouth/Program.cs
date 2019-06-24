using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DesafioSouth
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "South System";
            Console.WriteLine($"{Deformador.Deformar(text)}");
        }
    }
}
