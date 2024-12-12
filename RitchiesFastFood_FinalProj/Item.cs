using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitchiesFastFood_FinalProj
{
    // Base Item class
    public abstract class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        protected Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract override string ToString();
    }

    // Food class
    public class Food : Item
    {
        public int Calories { get; set; }

        public Food(string name, decimal price, int calories) : base(name, price)
        {
            Calories = calories;
        }

        public override string ToString()
        {
            return $"Food: {Name} - ${Price:F2}, {Calories} calories";
        }
    }

    // Drink class
    public class Drink : Item
    {
        public int Sugar { get; set; }

        public Drink(string name, decimal price, int sugar) : base(name, price)
        {
            Sugar = sugar;
        }

        public override string ToString()
        {
            return $"Drink: {Name} - ${Price:F2}, {Sugar}g sugar";
        }
    }


}
