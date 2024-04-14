using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Labb1_Entity_Framework.Models
{
    public class LeaveType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeaveTypeId { get; set; }

        [Required]
        [Display(Name = "Leave type")]
        public string? Name { get; set; } // Exempel: Semester, Vård av barn, etc.
    }


}
