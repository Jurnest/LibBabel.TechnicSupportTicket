using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Domain.Models;
using LibBabel.TechnicSupportTicket.Persistance;
using LibBabel.TechnicSupportTicket.Persistance.Repository;

namespace LibBabel.TechnicSupportFirm.Persistance.Repository;
public class FirmRepository : GenericRepository<Firm>, IFirmRepository
{
    public FirmRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }
}
