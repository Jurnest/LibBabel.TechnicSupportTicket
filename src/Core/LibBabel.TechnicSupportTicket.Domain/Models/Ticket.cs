namespace LibBabel.TechnicSupportTicket.Domain.Models;

public class Ticket : BaseModel
{
    public string Subject { get; set; }
    public string Content { get; set; }
    public int StateId { get; set; }
    public DateTime UpdatedDate { get; set; }
    public int Priorty { get; set; }
    public int CreatedById { get; set; }
    public int UndertakeById { get; set; }

    public User User { get; set; }
    public List<TicketTime> TicketTimes { get; set; }
    public List<TicketComment> TicketComments { get; set; }
}
