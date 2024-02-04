using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Domain.Models;
using LibBabel.TechnicSupportTicket.Persistance;
using LibBabel.TechnicSupportTicket.Persistance.Repository;

namespace LibBabel.TechnicSupportTicketTime.Persistance.Repository;

public class TicketTimeRepository : GenericRepository<TicketTime>, ITicketTimeRepository
{
    public TicketTimeRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }
}
