using MediatR;

namespace LibBabel.TechnicSupportTicket.Application.Features.Commands.Parameter.Delete;

public class DeleteParameterCommand : IRequest<bool>
{
    public int Id { get; set; }

    public DeleteParameterCommand()
    {
        
    }

    public DeleteParameterCommand(int id)
    {
        Id = id;
    }
}
