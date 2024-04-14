using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Labb1_Entity_Framework.Models
{
    public class Leave
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeaveId { get; set; }

        [ForeignKey("Employee")]
        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Date created")]
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        [Required]
        [ForeignKey("LeaveType")]
        [Display(Name = "Reason")]
        public int LeaveTypeId { get; set; }

        public LeaveType? LeaveType { get; set; } // Navigation property för ledighetstyp
        public Employee? Employee { get; set; }  // Navigation property för anställd
    }


}
