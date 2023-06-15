using System;

namespace Practica_1
{
    public class Cat
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    throw new Exception($"{value} - неправильное имя!!!");
                }
            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Вес не может быть равен 0 или меньше 0");
                }
                else
                {
                    weight = value;
                }
            }
        }

        public Cat(string CatName, double CatWeight)
        {
            Name = CatName;
            Weight = CatWeight;
        }

        public void Meow()
        {
            Console.WriteLine($"Имя: {name} вес: {weight.ToString()}: МЯЯЯЯУ!!!!");
        }
    }
}