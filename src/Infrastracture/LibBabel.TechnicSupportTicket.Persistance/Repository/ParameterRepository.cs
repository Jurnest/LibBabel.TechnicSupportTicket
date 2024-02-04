using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Domain.Models;

namespace LibBabel.TechnicSupportTicket.Persistance.Repository;

public class ParameterRepository : GenericRepository<Parameter>, IParameterRepository
{
    public ParameterRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }
}
