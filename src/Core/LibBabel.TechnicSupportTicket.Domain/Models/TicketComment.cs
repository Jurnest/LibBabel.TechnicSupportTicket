namespace LibBabel.TechnicSupportTicket.Domain.Models;

public class TicketComment : BaseModel
{
    public string Content { get; set; }
    public int CreatedById { get; set; }
    public int TicketId { get; set; }

    public Ticket Ticket { get; set; }
    public User User { get; set; }
}
