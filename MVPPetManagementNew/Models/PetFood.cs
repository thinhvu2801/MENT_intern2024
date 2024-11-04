using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPetManagement.Models
{
    public class PetFood
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public PetFood(int id, string name, string description, double price)
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
