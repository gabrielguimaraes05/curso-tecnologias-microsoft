using System;

namespace Aula2POO.Classes
{
    class Robot
    {
        private Position Position { get; set; }
        private Bag Bag { get; set; } //não deixar ser manor de 0

        public void Displacement(int x, int y)
        {
            Position.X = x;
            Position.Y = y;
        }

        public void AddJewelBag(JewelTypesEnum jewel) 
        {
            Bag.Value += (int)jewel;
            Bag.Qtt += 1;
        }

        public void Print ()
        {
            Console.WriteLine($"Bag total items: ${Bag.Qtt} | Bag total value: ${Bag.Value}");
        }
    }
}
