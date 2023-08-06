namespace ApartmentManagementSystem.Entities
{
    public class Bill
    {
        public int BillId { get; set; }
        public int ApartmentId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal ElectricityBillAmount { get; set; }
        public decimal WaterBillAmount { get; set; }
        public decimal GasBillAmount { get; set; }
        public decimal Amount { get; set; }
        public bool isPaid { get; set; }
    }
}
