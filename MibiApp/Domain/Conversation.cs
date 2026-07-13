namespace MibiApp.Domain
{
    public class Conversation
    {
        public long Id { get; set; }

        public required string PhoneNumber { get; set; }

        public string? PatientName { get; set; }

        public ConversationStatus Status { get; set; }

        public bool RequiresHumanAttention { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public ICollection<Message> Messages { get; set; } = [];
    }
}
