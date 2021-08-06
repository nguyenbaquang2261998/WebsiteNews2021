using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class Account
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public int Role { get; set; }

        public int Status { get; set; }
    }
}
