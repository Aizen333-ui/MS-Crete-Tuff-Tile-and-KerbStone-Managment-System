using System;

namespace TFBlockManagementSystem
{
    public class WorkerItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public WorkerItem(int id, string name, string position)
        {
            ID = id;
            Name = name;
            Position = position;
        }

        public override string ToString() => $"ID: {ID}, Name: {Name}, Position: {Position}";
    }

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

        public override string ToString() => $"ID: {ID}, Name: {Name}, Quantity: {Quantity}";
    }

    public class PaymentItem
    {
        public int ID { get; set; }
        public string Reason { get; set; }
        public decimal Amount { get; set; }

        public PaymentItem(int id, string reason, decimal amount)
        {
            ID = id;
            Reason = reason;
            Amount = amount;
        }

        public override string ToString() => $"ID: {ID}, Reason: {Reason}, Amount: {Amount}";
    }
}
