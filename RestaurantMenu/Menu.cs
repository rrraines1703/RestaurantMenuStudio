using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private DateTime lastUpdated { get; }
    }
}
