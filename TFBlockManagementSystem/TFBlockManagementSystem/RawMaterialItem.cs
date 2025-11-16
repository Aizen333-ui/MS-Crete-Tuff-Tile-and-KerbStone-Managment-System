using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFBlockManagementSystem
{
    public class RawMaterialItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public RawMaterialItem(int id, string name, int quantity)
        {
            ID = id;
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Quantity: {Quantity}";
        }
    }
}

