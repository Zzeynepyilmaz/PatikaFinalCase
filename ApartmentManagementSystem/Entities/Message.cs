namespace ApartmentManagementSystem.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public bool isRead { get; set; }

    }
}
