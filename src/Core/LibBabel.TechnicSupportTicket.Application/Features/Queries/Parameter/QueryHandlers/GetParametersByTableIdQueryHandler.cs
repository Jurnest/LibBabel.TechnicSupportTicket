using AutoMapper;
using AutoMapper.QueryableExtensions;
using LibBabel.TechnicSupportTicket.Application.Features.Queries.Parameter.Queries;
using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Common.Exceptions;
using LibBabel.TechnicSupportTicket.Common.Models.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibBabel.TechnicSupportTicket.Application.Features.Queries.Parameter.QueryHandlers;

public class GetParametersByTableIdQueryHandler : IRequestHandler<GetParametersByTableIdQuery, List<GetParametersByTableIdViewModel>>
{
    private readonly IParameterRepository _repository;
    private readonly IMapper _mapper;

    public GetParametersByTableIdQueryHandler(IParameterRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetParametersByTableIdViewModel>> Handle(GetParametersByTableIdQuery request, CancellationToken cancellationToken)
    {
        var query = _repository.AsQuerayable().Where(x => x.TableCode == request.TableCode);

        if (query is null)
            throw new DatabaseValidationException("There is no data");
        
        return await query.ProjectTo<GetParametersByTableIdViewModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}
