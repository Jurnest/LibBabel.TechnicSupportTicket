using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using MediatR;

namespace LibBabel.TechnicSupportTicket.Application.Features.Commands.Parameter.Delete;

public class DeleteParameterCommandHandler : IRequestHandler<DeleteParameterCommand, bool>
{
    private readonly IParameterRepository _repository;

    public DeleteParameterCommandHandler(IParameterRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteParameterCommand request, CancellationToken cancellationToken)
    {
        var dbParam = await _repository.GetByIdAsync(request.Id);

        if (dbParam is null)
            return false;

        await _repository.DeleteAsync(dbParam);
        return true;
    }
}
