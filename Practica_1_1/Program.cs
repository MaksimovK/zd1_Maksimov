using System;

namespace Practica_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите кличку кота: ");
                string catName = Console.ReadLine();
                Console.Write("Введите вес кота: ");
                double catWeight = double.Parse(Console.ReadLine());
                Cat murzik = new Cat(catName, catWeight);
                murzik.Meow();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}