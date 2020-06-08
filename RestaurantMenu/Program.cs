using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> menuList = new List<MenuItem>();
            menuList.Add(new MenuItem("Cheese Pizza", "Plain Cheese Pizza", 5.95, "Entree", false));
            menuList.Add(new MenuItem("Pepperoni Pizza", "Pepperoni topped cheese pizza", 6.95, "Entree"));
            menuList.Add(new MenuItem("Coke", "Refreshing glass of Coke", 1.15, "Drink", false));
            menuList.Add(new MenuItem("Sprite", "Refreshing glass of Sprite", 1.15, "Drink"));

            Menu startingMenu = new Menu("Main Menu", menuList);

            startingMenu.DisplayMenu();
        }
    }
}
