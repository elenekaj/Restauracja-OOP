using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Category
    {
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; }

        public Category(string name)
        {
            Name = name;
            Dishes = new List<Dish>();
        }

        // dodaje danie do kategorii
        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }

        // usuwa danie z kategorii
        public void RemoveDish(Dish dish)
        {
            Dishes.Remove(dish);
        }
    }
}
