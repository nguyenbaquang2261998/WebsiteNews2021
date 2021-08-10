using System.ComponentModel.DataAnnotations;

namespace DOLPHIN.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string FullName { get; set; }
        public string ProfilePicture { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Type { get; set; }
    }
}
