namespace Server.API.Models
{
    public class Comment(Guid Id, Guid PosterUserId, string CommentMessage, DateTime CreationTime)
    {
        public Guid Id { get; set; } = Id;
        public Guid PosterUserId { get; set; } = PosterUserId;
        public string CommentMessage { get; set; } = CommentMessage;
        public DateTime CreationTime { get; set; } = CreationTime;
    }
}
