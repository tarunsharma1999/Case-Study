
using System;
using System.Collections.Generic;
using Com.Truyum.Model;
using Com.Truyum.Utility;

namespace Com.Truyum.Dao
{
    public class MenuItemDaoCollectionTest
    {
        /*public static void Main(String [] arg)
        {
            TestGetMenuItemListAdmin();
        }*/

        public  void TestGetMenuItemListAdmin()
        {
            MenuItemDaoCollection MenuItemDao = new MenuItemDaoCollection();
            List<MenuItem> menuItemDao = MenuItemDao.GetMenuItemListAdmin();

            Console.WriteLine("Name \t Price \tActive \tDate Of Launch \tCategory \tFree Delivery");
            for (int i = 0; i < menuItemDao.Count; i++)
            {
                Console.WriteLine(menuItemDao[i].Name + "\t" + menuItemDao[i].Price + "\t" + menuItemDao[i].Active + "\t" + menuItemDao[i].DateOfLaunch.ToShortDateString() + "\t" + menuItemDao[i].Category + "\t" + menuItemDao[i].FreeDelivery);
            }

            

            

        }

        public void TestGetMenuItemListCustomer()
        {
            MenuItemDaoCollection MenuItemDao = new MenuItemDaoCollection();
            List<MenuItem> menuItemDao = MenuItemDao.GetMenuItemListCustomer();

            Console.WriteLine("Name \t Price \tActive \tDate Of Launch \tCategory \tFree Delivery");
            for (int i = 0; i < menuItemDao.Count; i++)
            {
                Console.WriteLine(menuItemDao[i].Name + "\t" + menuItemDao[i].Price + "\t" + menuItemDao[i].Active + "\t" + menuItemDao[i].DateOfLaunch.ToShortDateString() + "\t" + menuItemDao[i].Category + "\t" + menuItemDao[i].FreeDelivery);
            }
        }

        public void TestModifyMenuItem()
        {
            DateUtility objForDate = new DateUtility();
            DateTime dt;
            dt = objForDate.ConvertToShortDateString("25-05-2021");

            MenuItem item = new MenuItem(2, "Burger", 121, "Yes", dt, "Fast Food", "Yes");


            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            menuItemDao.ModifyMenuItem(item);

            item = menuItemDao.GetMenuItem(item.Id);

            Console.WriteLine(item.Name + "\t" + item.Price + "\t" +  item.Active + "\t" +  item.Category + "\t" +  item.DateOfLaunch.ToShortDateString() + "\t" +  item.FreeDelivery);

        }
    }

}
