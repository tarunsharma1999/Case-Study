using Com.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Com.Truyum.Utility;

namespace Com.Truyum.Dao
{
    public class MenuItemDaoCollection : IMenuItemDao
    {
        private List<MenuItem>  menuItemList = new List<MenuItem>(); 

        public MenuItemDaoCollection()
        {
            if(menuItemList.Count ==0)
            {
                DateUtility objForDate = new DateUtility();
                DateTime dt;

                dt = objForDate.ConvertToShortDateString("15-03-2017");
                MenuItem item1 = new MenuItem(1, "Sandwich", 99, "Yes",dt , "Main Course", "Yes");

                dt = objForDate.ConvertToShortDateString("25-05-2021");
                MenuItem item2 = new MenuItem(2, "Burger", 129, "Yes", dt, "Main Course", "No");

                dt = objForDate.ConvertToShortDateString("21-08-2018");
                MenuItem item3 = new MenuItem(3, "Pizza", 149, "Yes", dt, "Main Course", "No");

                dt = objForDate.ConvertToShortDateString("02-03-2017");
                MenuItem item4 = new MenuItem(4, "French Fries", 57, "No", dt , "Started", "Yes");

                dt = objForDate.ConvertToShortDateString("02-11-2022");
                MenuItem item5 = new MenuItem(5, "Chocolarte Browine", 32, "Yes", dt, "Dessert", "Yes");

                menuItemList.Add(item1);
                menuItemList.Add(item2);
                menuItemList.Add(item3);
                menuItemList.Add(item4);
                menuItemList.Add(item5);
            }
        }
        public MenuItem GetMenuItem(long MenuItemId)
        {
            MenuItem fl = null;
            for (int i = 0; i < menuItemList.Count; i++)
            {
                if (menuItemList[i].Id == MenuItemId)
                {
                    return menuItemList[i];
                }
            }

            return fl;
            
        }

        public List<MenuItem> GetMenuItemListAdmin()
        {
            return menuItemList;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            List<MenuItem> MenuItem = new List<MenuItem>();

            for(int i=0;i<menuItemList.Count;i++)
            {

                if (menuItemList[i].Active == "Yes")
                {
                    DateUtility checkDate = new DateUtility();
                    if (checkDate.checkDate(menuItemList[i].DateOfLaunch))
                    {
                        MenuItem.Add(menuItemList[i]);
                    }
                    
                }
            }

            return MenuItem;
        }

        public void ModifyMenuItem(MenuItem menuItem)
        {
            for( int i=0; i<menuItemList.Count; i++)
            {
                if(menuItemList[i].Id == menuItem.Id )
                {
                    menuItemList[i] = menuItem; 
                }
            }
        }
    }
}
