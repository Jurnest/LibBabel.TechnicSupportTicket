using LibBabel.TechnicSupportTicket.Common.Models.Queries;
using MediatR;

namespace LibBabel.TechnicSupportTicket.Application.Features.Queries.Parameter.Queries;

public class GetParametersByIdQuery : IRequest<GetParametersByIdViewModel>
{
    public int Id { get; set; }

    public GetParametersByIdQuery()
    {
        
    }

    public GetParametersByIdQuery(int id)
    {
        Id = id;
    }
}
