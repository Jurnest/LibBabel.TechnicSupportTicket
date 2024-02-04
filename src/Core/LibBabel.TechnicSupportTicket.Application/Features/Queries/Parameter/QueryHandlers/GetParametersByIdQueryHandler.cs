using AutoMapper;
using AutoMapper.QueryableExtensions;
using LibBabel.TechnicSupportTicket.Application.Features.Queries.Parameter.Queries;
using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Common.Models.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibBabel.TechnicSupportTicket.Application.Features.Queries.Parameter.QueryHandlers;

public class GetParametersByIdQueryHandler : IRequestHandler<GetParametersByIdQuery, GetParametersByIdViewModel>
{
    private readonly IParameterRepository _repository;
    private readonly IMapper _mapper;

    public GetParametersByIdQueryHandler(IParameterRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetParametersByIdViewModel> Handle(GetParametersByIdQuery request, CancellationToken cancellationToken)
    {
        var dbParam = await _repository.GetByIdAsync(request.Id);

        return new GetParametersByIdViewModel
        {
            Id = dbParam.Id,
            Defination = dbParam.Defination,
            Description = dbParam.Description,
            TableCode = dbParam.TableCode
        };
    }
}
