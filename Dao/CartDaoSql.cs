using Com.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Com.Truyum.Dao
{
    public class CartDaoSql
    {
        SqlConnection con = Helper.getConnection();
        public void AddMenuItem(long userId, long menuItemId)
        {
            try
            {
                con.Open();
                string q = "Insert into cart values(" + userId + "," + menuItemId + ")";

                SqlCommand cmd = new SqlCommand(q, con);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Data inserted");
                }
                else
                {
                    Console.WriteLine("Error while inserting data");
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
        public List<MenuItem> GetMenuItems(long userId)
        {
            List<MenuItem> menuItem = new List<MenuItem>();
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                
                
                string q = " Select m.* from menu_item m join cart c on m.id = c.itemId where c.userId="+userId;
                SqlCommand cmd = new SqlCommand(q, con);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            MenuItem menuitem = new MenuItem();
                            menuitem.Id = int.Parse(dr[0].ToString());
                            menuitem.Name = dr[1].ToString();
                            menuitem.Price = float.Parse(dr[2].ToString());
                            menuitem.Active = dr[3].ToString();
                            menuitem.DateOfLaunch = DateTime.Parse(dr[4].ToString());
                            menuitem.Category = dr[5].ToString();
                            menuitem.FreeDelivery = dr[6].ToString();

                            menuItem.Add(menuitem);
                        }
                    }

                }
                con.Close();
                 
                

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            return menuItem;

        }

        public void RemoveMenuItem(long userId, long menuItemId)
        {
            try
            {
                con.Open();
                var q = "Delete from cart where userId=" + userId + " AND itemId=" + menuItemId;
                SqlCommand cmd = new SqlCommand(q, con);

                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {
                    Console.WriteLine("Data Deleted");
                }
                else
                {
                    Console.WriteLine("Error while deleting data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
