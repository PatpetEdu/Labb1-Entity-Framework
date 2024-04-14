using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Labb1_Entity_Framework.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Namnet får inte vara längre än 60 tecken")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Namnet får inte vara längre än 60 tecken")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Full name")]
        [NotMapped]  // Does not get mapped to the database
        public string FullName => $"{FirstName} {LastName}";

        public List<Leave>? Leaves { get; set; } 
    }

}
