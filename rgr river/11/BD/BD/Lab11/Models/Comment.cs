using System;

namespace Lab11.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
