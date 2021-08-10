using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.DTO
{
    public class ArticleSearchDto
    {
        public int ArticleId { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
    }
}
