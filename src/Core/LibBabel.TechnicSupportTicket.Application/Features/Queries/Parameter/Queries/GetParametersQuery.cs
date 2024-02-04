using LibBabel.TechnicSupportTicket.Common.Models.Queries;
using MediatR;

namespace LibBabel.TechnicSupportTicket.Application.Features.Queries.Parameter.Queries;

public class GetParametersQuery : IRequest<List<GetParametersViewModel>>
{
}
