namespace LibBabel.TechnicSupportTicket.Domain.Models;

public class TicketTime : BaseModel
{
    public decimal Time { get; set; }
    public int CreatedById { get; set; }
    public int TicketId { get; set; }

    public Ticket Ticket { get; set; }
    public User User { get; set; }
}
