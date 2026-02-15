using System.ComponentModel.DataAnnotations;

namespace PensionSystem.Database
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        public string ? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
