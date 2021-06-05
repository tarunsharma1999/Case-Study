using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Truyum.Model
{
    public class Cart
    {
        private List<MenuItem> menuItemList;
        private double total;

        public List<MenuItem> MenuItemList
        {
            get { return menuItemList; }
            set { menuItemList = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public Cart()
        {
            menuItemList = new List<MenuItem>();

        }
        public Cart(List<MenuItem> menuItemList, double total)
        {
            this.MenuItemList = menuItemList;
            this.Total = total;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public bool Equals(Cart obj)
        {
            return base.Equals(obj);
        }
    }
}
