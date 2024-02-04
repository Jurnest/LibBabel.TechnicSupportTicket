using AutoMapper;
using AutoMapper.QueryableExtensions;
using LibBabel.TechnicSupportTicket.Application.Features.Queries.Parameter.Queries;
using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Common.Models.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibBabel.TechnicSupportTicket.Application.Features.Queries.Parameter.QueryHandlers;

public class GetParametersQueryHandler : IRequestHandler<GetParametersQuery, List<GetParametersViewModel>>
{
    private readonly IParameterRepository _repository;
    private readonly IMapper _mapper;

    public GetParametersQueryHandler(IParameterRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetParametersViewModel>> Handle(GetParametersQuery request, CancellationToken cancellationToken)
    {
        var query = _repository.AsQuerayable();

        return await query.ProjectTo<GetParametersViewModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}
