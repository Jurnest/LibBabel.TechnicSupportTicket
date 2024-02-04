using LibBabel.TechnicSupportTicket.Application.Features.Commands.Parameter.Delete;
using LibBabel.TechnicSupportTicket.Application.Features.Queries.Parameter.Queries;
using LibBabel.TechnicSupportTicket.Common.Models.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibBabel.TechnicSupportTicket.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ParametersController : ControllerBase
{
    private readonly IMediator _mediator;

    public ParametersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("GetAll")]
    public async Task<IActionResult> GetParameters()
    {
        var param = await _mediator.Send(new GetParametersQuery());
        return Ok(param);
    }

    [HttpGet]
    [Route("GetByTableIdAll/{tableCode}")]
    public async Task<IActionResult> GetParametersByTableId(string tableCode)
    {
        var param = await _mediator.Send(new GetParametersByTableIdQuery(tableCode));
        return Ok(param);
    }

    [HttpGet]
    [Route("GetByIdAll/{id}")]
    public async Task<IActionResult> GetParametersById(int id)
    {
        var param = await _mediator.Send(new GetParametersByIdQuery(id));
        return Ok(param);
    }

    [HttpDelete]
    [Route("DeleteParam/{paramId}")]
    public async Task<IActionResult> DeleteParameter(int paramId)
    {
        return Ok(await _mediator.Send(new DeleteParameterCommand(paramId)));
    }

    [HttpPost]
    public async Task<IActionResult> CreateParameter([FromBody] CreateParameterCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpPut]
    public async Task<IActionResult> UpdateParameter([FromBody] UpdateParameterCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}
