using System.ComponentModel.DataAnnotations;

namespace DOLPHIN.Model
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AccountStatus { get; set; }
    }
}
