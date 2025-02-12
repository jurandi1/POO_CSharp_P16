using POO_CSharp_P16.Model.Entities;
using POO_CSharp_P16.Model.Enums;

namespace POO_CSharp_P16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Herdar vs. cumprir contrato");
            Console.WriteLine();
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();
        }
    }
}