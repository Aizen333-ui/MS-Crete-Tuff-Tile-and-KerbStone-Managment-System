using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFBlockManagementSystem
{
    public class PaymentItem
    {
        public int ID { get; set; }
        public string? WorkerName { get; set; }

        public decimal Amount { get; set; }

        public PaymentItem(int id, decimal amount)
        {
            ID = id;
            
            Amount = amount;
        }


        public override string ToString()
        {
            return $"{ID} : Rs. {Amount}";
        }
    }
}

