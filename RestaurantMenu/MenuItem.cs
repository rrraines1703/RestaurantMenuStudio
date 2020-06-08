using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {

        public string Category { get; set; }
        public bool NewItem { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        
        public MenuItem(string name, string description, double price, string category, bool newItem)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            NewItem = newItem;
        }

        public MenuItem(string name, string description, double price, string category) : this(name, description, price, category, true) { }
    }
}
