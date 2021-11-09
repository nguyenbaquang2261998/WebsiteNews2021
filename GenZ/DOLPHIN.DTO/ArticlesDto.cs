using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.DTO
{
    public class ArticlesDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CommentStatus { get; set; }
        public int AuthorId { get; set; }
        public int Status { get; set; }
        public string CoverImage { get; set; }
    }
}
