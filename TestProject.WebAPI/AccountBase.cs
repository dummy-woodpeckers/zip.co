using System.ComponentModel.DataAnnotations;

namespace TestProject.WebAPI
{
    public class AccountBase
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        // just for sample
        public string Role { get; set; }
    }
}
