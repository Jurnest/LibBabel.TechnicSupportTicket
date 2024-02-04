using MediatR;

namespace LibBabel.TechnicSupportTicket.Common.Models.Requests;

public class UpdateParameterCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Defination { get; set; }
    public string Description { get; set; }
    public string TableCode { get; set; }

    public UpdateParameterCommand()
    {
        
    }

    public UpdateParameterCommand(int id, string defination, string description, string tableCode)
    {
        Id = id;
        Defination = defination;
        Description = description;
        TableCode = tableCode;
    }
}
