using Com.Truyum.Model;
using Com.Truyum.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
namespace Com.Truyum.Dao
{
    public class MenuItemDaoSql: IMenuItemDao
    {
        SqlConnection con = Helper.getConnection();

       
        public List<MenuItem> GetMenuItemListAdmin()
        {
            List<MenuItem> menuItemList = new List<MenuItem>();
            try
            {
                con.Open();
                string qry = "Select * from menu_item";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    MenuItem menuItem = new MenuItem();
                    menuItem.Id     = long.Parse(dr[0].ToString());
                    menuItem.Name   = dr[1].ToString();
                    menuItem.Price  = float.Parse(dr[2].ToString());
                    menuItem.Active = dr[3].ToString();
                    menuItem.DateOfLaunch = DateTime.Parse(dr[4].ToString());
                    menuItem.Category = dr[5].ToString();
                    menuItem.FreeDelivery = dr[5].ToString();

                    menuItemList.Add(menuItem);
                }

                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return menuItemList;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            List<MenuItem> menuItemList = new List<MenuItem>();

            try
            {

                con.Open();
                var q = " Select * from menu_item where active='Yes'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    DateUtility checkDate = new DateUtility();
                    if (checkDate.checkDate(DateTime.Parse(da[4].ToString())))
                    {
                        MenuItem menuitem = new MenuItem();
                        menuitem.Id = int.Parse(da[0].ToString());
                        menuitem.Name = da[1].ToString();
                        menuitem.Price = float.Parse(da[2].ToString());
                        menuitem.Active = da[3].ToString();
                        menuitem.DateOfLaunch = DateTime.Parse(da[4].ToString());
                        menuitem.Category = da[5].ToString();
                        menuitem.FreeDelivery = da[6].ToString();

                        menuItemList.Add(menuitem);
                    }
                }
                con.Close();
                return menuItemList;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return menuItemList;

        }

        public void ModifyMenuItem(MenuItem menuItem)
        {

        }

        public MenuItem GetMenuItem(long MenuItemId)
        {
            //throw new NotImplementedException();

            MenuItem menuItem = new MenuItem();
            try
            {
                con.Open();
                string q = "Select * from menu_item where id=" + MenuItemId;
                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader da = cmd.ExecuteReader();
                
                while(da.Read())
                {
                   
                    menuItem.Id = int.Parse(da[0].ToString());
                    menuItem.Name = da[1].ToString();
                    menuItem.Price = float.Parse(da[2].ToString());
                    menuItem.Active = da[3].ToString();
                    menuItem.DateOfLaunch = DateTime.Parse(da[4].ToString());
                    menuItem.Category = da[5].ToString();
                    menuItem.FreeDelivery = da[6].ToString();
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return menuItem;
        }

    }
}
