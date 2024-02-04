using System.Net.Sockets;

namespace LibBabel.TechnicSupportTicket.Domain.Models;

public class User : BaseModel
{
    public string FullName { get; set; }
    public string FirmId { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public bool EmailConfirmed { get; set; }
    public bool PhoneConfirmed { get; set; }
    public bool IsEmployee { get; set; }

    public Firm Firm { get; set; }
    public List<TicketTime> TicketTimes { get; set; }
    public List<Ticket> Tickets { get; set; }
    public List<UserRole> UserRoles { get; set; }
}
