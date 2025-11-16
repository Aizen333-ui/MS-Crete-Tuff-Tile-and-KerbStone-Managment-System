using System.Collections.Generic;

namespace TFBlockManagementSystem
{
    // Worker structure
    public class WorkerItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public override string ToString() => $"ID: {ID}, Name: {Name}, Role: {Role}";
    }

    // Raw Material structure
    public class RawMaterialItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public override string ToString() => $"ID: {ID}, Name: {Name}, Quantity: {Quantity}";
    }

    // Payment structure
    public class PaymentItem
    {
        public int ID { get; set; }
        public string WorkerName { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }

        public override string ToString() => $"ID: {ID}, Worker: {WorkerName}, Amount: {Amount}, Reason: {Reason}";
    }

    // Central data storage
    public static class FactoryData
    {
        public static List<WorkerItem> Workers { get; set; } = new List<WorkerItem>();
        public static List<RawMaterialItem> RawMaterials { get; set; } = new List<RawMaterialItem>();
        public static List<PaymentItem> Payments { get; set; } = new List<PaymentItem>();
    }
}
