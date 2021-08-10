using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DOLPHIN.Model
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CommentStatus { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        public int AuthorId { get; set; }
        public int Status { get; set; }
    }
}
