using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Room
    {
        public Room(string name,double price,int personCapacity)
        {
            this.Name = name;
            this.PersonCapacity = personCapacity;
            this.Price = price;
            TotalCount++;
            _id = TotalCount;
        }
        public static int TotalCount { get; set; }
        private int _id;
        public int ID { get => _id; }
        public string  Name { get; set; }
        public double  Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable = true;
        public string ShowInfo()
        {
         return ($"{this.Name},{this.ID},{this.Price},{this.PersonCapacity},{this.IsAvailable}");
        }
        public override string ToString()
        {
            return ShowInfo();
        }


    }
}
