using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DOLPHIN.Model
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("NewId")]
        public virtual News News { get; set; }
        public int NewsId { get; set; }

        [ForeignKey("SubscriberId")]
        public virtual Subscriber Subscriber { get; set; }
        public int SubscriberId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
