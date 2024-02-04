namespace LibBabel.TechnicSupportTicket.Domain.Models;

public class Firm : BaseModel
{
    public string FirmName { get; set; }

    public List<User> Users { get; set; }
}
