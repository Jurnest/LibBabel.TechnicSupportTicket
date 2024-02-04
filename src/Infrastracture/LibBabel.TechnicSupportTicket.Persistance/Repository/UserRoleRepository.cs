using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Domain.Models;
using LibBabel.TechnicSupportTicket.Persistance;
using LibBabel.TechnicSupportTicket.Persistance.Repository;

namespace LibBabel.TechnicSupportUserRole.Persistance.Repository;

public class UserRoleRepository : GenericRepository<UserRole>, IUserRoleRepository
{
    public UserRoleRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }
}
