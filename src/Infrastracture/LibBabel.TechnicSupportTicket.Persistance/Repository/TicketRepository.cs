using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Domain.Models;

namespace LibBabel.TechnicSupportTicket.Persistance.Repository;

public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
{
    public TicketRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }
}
