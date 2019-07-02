using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dbo
{
    public class Post
    {
        public Guid Id { get; set; }
        public DateTime PostedTime { get; set; }
        public string Topic { get; set; }
        public string Text { get; set; }
        public Guid UserId { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public virtual User Author { get; set; }

        public override string ToString() =>
            $"{Author.Name}\n" +
            $"{PostedTime:dd/MM/yyyy mm:hh}\n" +
            $"==={Topic}===\n" +
            $"{Text}\n";
    }
}