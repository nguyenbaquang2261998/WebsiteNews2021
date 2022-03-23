using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.DTO
{
    public class FillterDto
    {
        // Start to: Eg = 1
        public int Start { get; set; } = 1;

        // Limit item: Eg = 100
        public int Limit { get; set; } = 10;

        // Sort By / 0 : rank 
        public int SortBy { get; set; }

        // SortType / 0 : desc  1 : asc
        public int SortType { get; set; }
    }
}
