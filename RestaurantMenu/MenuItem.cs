using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private double price;
        private List<string> category = new List<string> { "appetizer", "main course", "dessert" };
        
        public bool NewItem { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        
    }
}
