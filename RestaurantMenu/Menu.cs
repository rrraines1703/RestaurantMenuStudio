using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        private string item;
        public string Item { get; set; }
        private List<MenuItem> menuList;
        private DateTime LastUpdated { get; set; }
        public List<MenuItem> MenuList { get; set; }

        public Menu(string item, List<MenuItem> menuList, DateTime lastUpdated)
        {
            Item = item;
            MenuList = menuList;
            LastUpdated = lastUpdated;
        }

        public Menu(string item, List<MenuItem> menuList)
            : this(item, menuList, DateTime.Now) { }

        public void UpdateMenu(string addRemove, Menu menu, MenuItem menuItem)
        {
            if(addRemove == "add")
            {
                if(!MenuList.Contains(menuItem))
                {
                    MenuList.Add(menuItem);
                    LastUpdated = DateTime.Now;
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.Write($"{Item} already contains {menuItem.Name}");
                }
            } else if(addRemove == "remove")
            {
                if (MenuList.Contains(menuItem))
                {
                    MenuList.Remove(menuItem);
                    LastUpdated = DateTime.Now;
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.Write($"{Item} does not contain {menuItem.Name}");
                }
                LastUpdated = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Error");
                Console.WriteLine($"{addRemove} Error");
            }
        }
        public void DisplayMenu()
        {
            Console.WriteLine(Item);
            Console.WriteLine("*************");
            foreach(MenuItem item in MenuList)
            {
                if (item.NewItem)
                {
                    Console.Write("New! ");
                }
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Category);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Price);
                Console.WriteLine("*************");
            }
            Console.WriteLine(LastUpdated);
        }
    }
}
