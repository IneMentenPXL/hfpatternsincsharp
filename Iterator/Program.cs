using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            Menu dinerMenu = new Menu("DINER MENU", "Lunch");
            Menu cafeMenu = new Menu("CAFE MENU", "Dinner");
            Menu dessertMenu = new Menu("DESSERT MENU", "Dessert of course! ");
            Menu allMenus = new Menu("ALL MENUS", "All menus combined");

            MenuItem item = new MenuItem("Pancake", "Plain", true, 1.99);
            MenuItem item1 = new MenuItem("Spaghetti", "With delicious sauce and meatballs", false, 10.50);
            MenuItem item2 = new MenuItem("Toast", "Toast with cheese and ham", false, 5.98);
            MenuItem item3 = new MenuItem("Ice cream", "With chocolate sauce", true, 3.25);
            pancakeHouseMenu.Add(item);
            dinerMenu.Add(item1);
            cafeMenu.Add(item2);
            dessertMenu.Add(item3);

            allMenus.Add(pancakeHouseMenu);
            dinerMenu.Add(dessertMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            Waitress shirley = new Waitress(allMenus);
            shirley.PrintMenu();
            Console.ReadLine();
        }
    }
}
