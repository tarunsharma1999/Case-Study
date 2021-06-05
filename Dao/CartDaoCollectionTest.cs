using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Truyum.Dao
{
    public class CartDaoCollectionTest
    {
        public void TestAddCartItem()
        {
            CartDaoCollection cartDao = new CartDaoCollection();
            cartDao.AddCartItem(1, 3);
            cartDao.AddCartItem(1, 4);
            var x = cartDao.GetAllCartItems(1);
            foreach(var y in x.MenuItemList)
            {
                Console.WriteLine(y.Name);
            }
        }/*
        public void TestGetAllCartItem();*/

        public void TestRemoveCartItem()
        {
            try
            {
                CartDaoCollection cartDao = new CartDaoCollection();
                cartDao.AddCartItem(1, 3);
                cartDao.AddCartItem(1, 4);
                cartDao.RemoveCartItem(1, 3);
                var x = cartDao.GetAllCartItems(1);
                foreach (var y in x.MenuItemList)
                {
                    Console.WriteLine(y.Name);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
