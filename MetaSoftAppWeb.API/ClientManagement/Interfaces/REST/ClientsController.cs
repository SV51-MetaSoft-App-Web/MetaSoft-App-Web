using System.Net.Mime;
using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Queries;
using MetaSoftAppWeb.API.ClientManagement.Domain.Services;
using MetaSoftAppWeb.API.ClientManagement.Interfaces.REST.Resources;
using MetaSoftAppWeb.API.ClientManagement.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MetaSoftAppWeb.API.ClientManagement.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Tags("Clients")]
public class ClientsController(
    IClientCommandService clientCommandService,
    IClientQueryService clientQueryService
    ) : ControllerBase

{
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a new client",
        Description = "Creates a new client",
        OperationId = "CreateClient")]
    [SwaggerResponse(StatusCodes.Status201Created, "The client was created", typeof(ClientResource))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "The client could not be created")]
    public async Task<ActionResult> CreateClient([FromBody] CreateClientResource resource)
    {
        var createClientCommand = 
            CreateClientCommandFromResourceAssembler.ToCommandFromResource(resource);
        var result = await clientCommandService.Handle(createClientCommand);
        if (result is null) return BadRequest();
        return CreatedAtAction(nameof(GetClientById), new {id = result.Id},
            ClientResourceFromEntityAssembler.ToResourceFromEntity(result));
        

    }

    [HttpGet("{id}")]
    [SwaggerOperation(
        Summary = "Get a client by id",
        Description = "Gets a client by id",
        OperationId = "GetClient")]
    [SwaggerResponse(StatusCodes.Status200OK, "The client was found", typeof(ClientResource))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "The client was not found")]
    public async Task<ActionResult> GetClientById(int id)
    {
        var getClientByIdQuery = new GetClientByIdQuery(id);
        var result = await clientQueryService.Handle(getClientByIdQuery);
        if (result is null) return NotFound();
        var resource = ClientResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }
}