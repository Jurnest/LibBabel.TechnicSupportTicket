using System.Security.Principal;

namespace LibBabel.TechnicSupportTicket.Domain.Models;

public class UserRole : BaseModel
{
    public int RoleId { get; set; }
    public int UserId { get; set; }

    public User User { get; set; }
    public Role Role { get; set; }
}
