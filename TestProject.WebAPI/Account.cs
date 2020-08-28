using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.WebAPI
{
    public class Account : AccountBase
    {
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
