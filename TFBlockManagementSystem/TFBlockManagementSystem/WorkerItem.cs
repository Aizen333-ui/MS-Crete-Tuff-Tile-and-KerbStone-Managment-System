using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFBlockManagementSystem
{
    public class WorkerItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public WorkerItem(int id, string name) // removed 'position'
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{ID} - {Name}";
        }
    }

}

