using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Data
{
    public class LeaveType
    {

        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public string NumberOfDays { get; set; }

    }
}
