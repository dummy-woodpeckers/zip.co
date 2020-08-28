using System.ComponentModel.DataAnnotations;

namespace TestProject.WebAPI
{
    public class User
    {
        private const int MaxExpenses = 1000;

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public decimal Expenses { get; set; }

        public bool IsSalaryValid() => Salary - Expenses < MaxExpenses;
    }
}
