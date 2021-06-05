using System;
using System.Collections.Generic;
using Com.Truyum.Model;

namespace Com.Truyum.Dao
{
    interface IMenuItemDao
    {
        List<MenuItem> GetMenuItemListAdmin();
        List<MenuItem> GetMenuItemListCustomer();

        void ModifyMenuItem(MenuItem menuItem);

        MenuItem GetMenuItem(long MenuItemId);
    }

    interface ICartDao
    {
        void AddCartItem(long userId, long menuItemId);
        Cart GetAllCartItems(long userId);
        void RemoveCartItem(long userId, long productId);
    }

    public class Class1
    {
    }
}
