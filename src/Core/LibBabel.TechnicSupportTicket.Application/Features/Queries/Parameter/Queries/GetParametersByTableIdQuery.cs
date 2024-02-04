using LibBabel.TechnicSupportTicket.Common.Models.Queries;
using MediatR;

namespace LibBabel.TechnicSupportTicket.Application.Features.Queries.Parameter.Queries;

public class GetParametersByTableIdQuery : IRequest<List<GetParametersByTableIdViewModel>>
{
    public string TableCode { get; set; }

    public GetParametersByTableIdQuery()
    {
        
    }

    public GetParametersByTableIdQuery(string tableCode)
    {
        TableCode = tableCode;
    }
}
