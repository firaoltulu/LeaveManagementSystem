using AutoMapper;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Services
{
    public class LeaveTypesService : ILeaveTypesService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public LeaveTypesService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<LeaveTypeReadOnlyVM>> GetAll()
        {
            var data = await _context.LeaveTypes.ToListAsync();
            var viewData = _mapper.Map<List<LeaveTypeReadOnlyVM>>(data);
            return viewData;
        }

        public async Task<T?> Get<T>(int id) where T : class
        {

            var data = await _context.LeaveTypes.FirstOrDefaultAsync(m => m.Id == id);
            if (data == null)
            {
                return null;
            }
            var viewData = _mapper.Map<T>(data);
            return viewData;
        }

        public async Task Remove(int id)
        {
            var data = await _context.LeaveTypes.FirstOrDefaultAsync(m => m.Id == id);
            if (data == null) { return; }
            _context.LeaveTypes.Remove(data);
            _context.SaveChanges();

        }

        public async Task Edit(LeaveTypeEditVM vm)
        {
            var leaveType = _mapper.Map<LeaveType>(vm);
            _context.Update(leaveType);
            await _context.SaveChangesAsync();
        }

        public async Task Create(LeaveTypeCreateVM vm)
        {
            var leaveType = _mapper.Map<LeaveType>(vm);
            _context.Add(leaveType);
            await _context.SaveChangesAsync();
        }

        public bool LeaveTypeExists(int id)
        {
            return _context.LeaveTypes.Any(e => e.Id == id);
        }

        public async Task<bool> CheckIfLeaveTypeNameExistsAsync(string name)
        {
            var lowwercaseName = name.ToLower();
            return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowwercaseName));
        }
        public async Task<bool> CheckIfLeaveTypeNameExistsForEditAsync(LeaveTypeEditVM leaveTypeEdit)
        {
            var lowwercaseName = leaveTypeEdit.Name.ToLower();
            return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowwercaseName) && q.Id != leaveTypeEdit.Id);
        }

    }
}
