namespace MibiApp.Domain
{
    public class Message
    {
        public long Id { get; set; }

        public long ConversationId { get; set; }

        public MessageDirection Direction { get; set; }

        public required string Content { get; set; }

        public string? DetectedIntent { get; set; }

        public DateTimeOffset SentAt { get; set; }
    }
}
