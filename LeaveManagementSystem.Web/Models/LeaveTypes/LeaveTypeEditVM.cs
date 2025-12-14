using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {

        [Required]
        [Length(4, 150, ErrorMessage = "Yoy Have Violeted the length requirments")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Maximum Allocation of Days")]
        public string NumberOfDays { get; set; } = string.Empty;
    }
}
