using AutoMapper;
using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Common.Exceptions;
using LibBabel.TechnicSupportTicket.Common.Models.Requests;
using MediatR;

namespace LibBabel.TechnicSupportTicket.Application.Features.Commands.Parameter.Update;

public class UpdateParameterCommandHandler : IRequestHandler<UpdateParameterCommand, bool>
{
    private readonly IParameterRepository _repository;
    private readonly IMapper _mapper;

    public UpdateParameterCommandHandler(IParameterRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<bool> Handle(UpdateParameterCommand request, CancellationToken cancellationToken)
    {
        var dbParam = await _repository.GetByIdAsync(request.Id);

        if (dbParam is null)
            throw new DatabaseValidationException("Parameter is not found.");

        var mapParam = _mapper.Map<Domain.Models.Parameter>(request);

        await _repository.UpdateAsync(mapParam);

        return true;
    }
}
