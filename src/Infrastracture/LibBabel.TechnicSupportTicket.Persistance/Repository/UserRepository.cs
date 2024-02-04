using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Domain.Models;
using LibBabel.TechnicSupportTicket.Persistance;
using LibBabel.TechnicSupportTicket.Persistance.Repository;

namespace LibBabel.TechnicSupportUser.Persistance.Repository;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }
}
