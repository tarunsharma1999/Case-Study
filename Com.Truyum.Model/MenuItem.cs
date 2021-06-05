using System;
using System.Collections.Generic;
namespace Com.Truyum.Model
{
    public class MenuItem
    {
        private long id;
        private string name;
        private float price;
        private string active;
        private DateTime dateOfLaunch;
        private string category;
        private string freeDelivery;

        public long     Id      
        { 
            get { return id; } 
            set { id = value; } 
        }
        public string   Name    
        {  
            get { return name; } 
            set { name = value; } 
        } 
        public float    Price 
        { 
            get { return price; } 
            set { price = value; } 
        }
        public string     Active 
        { 
            get { return active; } 
            set { active = value; } 
        }
        public DateTime DateOfLaunch 
        { 
            get { return dateOfLaunch;  } 
            set { dateOfLaunch = value; } 
        }
        public string Category 
        { 
            get { return category; } 
            set { category = value; } 
        }
        public string FreeDelivery 
        {  
            get { return freeDelivery; } 
            set { freeDelivery = value; } 
        }

        public MenuItem()
        {

        }
        public MenuItem( long id, string name, float price, string active, DateTime dateOfLaunch, string category, string freeDelivery)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Active = active;
            this.DateOfLaunch = dateOfLaunch;
            this.Category = category;
            this.FreeDelivery = freeDelivery;

        }
        public override string ToString()
        {
            return base.ToString();
        }
        public bool Equals(MenuItem obj)
        {
            return base.Equals(obj.Id);
        }
    }
   

}
