using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Domain.Models;
using LibBabel.TechnicSupportTicket.Persistance;
using LibBabel.TechnicSupportTicket.Persistance.Repository;

namespace LibBabel.TechnicSupportTicketComment.Persistance.Repository;

public class TicketCommentRepository : GenericRepository<TicketComment>, ITicketCommentRepository
{
    public TicketCommentRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }
}
