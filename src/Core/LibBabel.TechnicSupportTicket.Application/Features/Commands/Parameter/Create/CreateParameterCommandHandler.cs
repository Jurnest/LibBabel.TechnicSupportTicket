using AutoMapper;
using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Common.Models.Requests;
using LibBabel.TechnicSupportTicket.Domain.Models;
using MediatR;

namespace LibBabel.TechnicSupportTicket.Application.Features.Commands.Parameter.Create;

public class CreateParameterCommandHandler : IRequestHandler<CreateParameterCommand, int>
{
    private readonly IParameterRepository _repository;
    private readonly IMapper _mapper;

    public CreateParameterCommandHandler(IParameterRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateParameterCommand request, CancellationToken cancellationToken)
    {
        var dbParam = _mapper.Map<Domain.Models.Parameter>(request);

        await _repository.AddAsync(dbParam);

        return dbParam.Id;
    }
}
