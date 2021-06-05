using Com.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Truyum.Dao
{
    public class CartDaoCollection : ICartDao
    {
        private Dictionary<long, Cart>  userCarts;

        public CartDaoCollection()
        {
            if (userCarts == null)
            {
                userCarts = new Dictionary<long, Cart>();
            }
        }
        public void AddCartItem(long userId, long menuItemId)
        {
            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            MenuItem menuItem = menuItemDao.GetMenuItem(menuItemId);
            Cart objCart;

            if (userCarts.ContainsKey(userId))
            {

                objCart = userCarts[userId];
                objCart.MenuItemList.Add(menuItem);
            }
            else
            {
                objCart = new Cart();
                objCart.MenuItemList.Add(menuItem);
                userCarts.Add(userId, objCart);
            }
        }
        
        public Cart GetAllCartItems(long userId)
        {
            Cart obj = new Cart();
            try
            {
                obj = userCarts[userId];
                if (obj.MenuItemList.Count == 0)
                {
                    throw new CartEmptyException();
                }
                else
                {
                    float total = 0;
                    foreach (var y in obj.MenuItemList)
                    {
                        total += y.Price;
                    }
                    obj.Total = total;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("user not found");
            }
            return obj;
        }

        public void RemoveCartItem(long userId, long productId)
        {
            try
            {
                Cart cartList = userCarts[userId];
                int flag = 0;
                if (cartList.MenuItemList.Count != 0)
                {
                    foreach (var y in cartList.MenuItemList)
                    {
                        
                        if (productId == y.Id)

                        {
                            cartList.MenuItemList.Remove(y);
                            flag = 1;
                        }
                        if( flag==1)
                        {
                            break;
                        }
                    }
                }
                /*if (userCarts.ContainsKey(userId))
                {
                    var menuItem = userCarts[userId].MenuItemList;
                    menuItem.RemoveAll(x => x.Id == productId);
                }
                else
                {
                    Console.WriteLine("not found");
                }*/
               
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
