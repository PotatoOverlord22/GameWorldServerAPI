namespace Server.API.Models
{
    public class Comment(Guid id, Guid posterUserId, string commentMessage, DateTime creationTime)
    {
        public Guid Id { get; set; } = id;
        public Guid PosterUserId { get; set; } = posterUserId;
        public string CommentMessage { get; set; } = commentMessage;
        public DateTime CreationTime { get; set; } = creationTime;
    }
}
