using MediatR;

namespace LibBabel.TechnicSupportTicket.Common.Models.Requests;

public class CreateParameterCommand : IRequest<int>
{
    public string Defination { get; set; }
    public string Description { get; set; }
    public string TableCode { get; set; }

    public CreateParameterCommand()
    {
        
    }

    public CreateParameterCommand(string defination, string description, string tableCode)
    {
        Defination = defination;
        Description = description;
        TableCode = tableCode;
    }
}
