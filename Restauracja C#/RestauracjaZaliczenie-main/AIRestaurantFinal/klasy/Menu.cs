using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Menu
    {
        public List<Category> Categories { get; set; }

        public Menu()
        {
            Categories = new List<Category>();
        }

        //dodaje kategorie do menu
        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }

        // usuwa kategorie z menu
        public void RemoveCategory(Category category)
        {
            Categories.Remove(category);
        }
    }
}
