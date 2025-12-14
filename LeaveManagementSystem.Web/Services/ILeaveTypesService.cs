using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Services
{
    public interface ILeaveTypesService
    {
        Task<bool> CheckIfLeaveTypeNameExistsAsync(string name);
        Task<bool> CheckIfLeaveTypeNameExistsForEditAsync(LeaveTypeEditVM leaveTypeEdit);
        Task Create(LeaveTypeCreateVM vm);
        Task Edit(LeaveTypeEditVM vm);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyVM>> GetAll();
        bool LeaveTypeExists(int id);
        Task Remove(int id);
    }
}