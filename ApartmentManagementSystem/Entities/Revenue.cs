namespace ApartmentManagementSystem.Entities
{
    public class Revenue
    {
        public int RevenueId { get; set; }
        public int ApartmentId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal Amount { get; set; }
    }
}
