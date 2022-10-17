using System.ComponentModel.DataAnnotations;

namespace IdentityManagement_dotnet5.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(30, ErrorMessage = "Do not enter more than 30 characters")]
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email")]
        [StringLength(50, ErrorMessage = "Do not enter more than 50 characters")]
        public string Email { get; set; } = string.Empty;
    }
}
