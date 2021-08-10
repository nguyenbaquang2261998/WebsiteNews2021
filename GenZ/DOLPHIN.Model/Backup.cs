using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOLPHIN.Model
{
    public class Backup
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string BackupFile { get; set; }
    }
}
