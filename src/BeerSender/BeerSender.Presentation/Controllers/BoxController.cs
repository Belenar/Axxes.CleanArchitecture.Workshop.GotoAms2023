using System.Net;
using BeerSender.Application;
using BeerSender.Application.Boxes.Create;
using BeerSender.Application.Boxes.GetAll;
using BeerSender.Domain;
using BeerSender.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeerSender.Presentation.Controllers;

[Route("[controller]")]
[ApiController]
public class BoxController : ControllerBase
{
    private readonly IHandleCommand<CreateBox, CreateBoxResult> _createBoxHandler;
    private readonly IGetAllBoxes _boxQuery;

    public BoxController(
        IHandleCommand<CreateBox, CreateBoxResult> createBoxHandler,
        IGetAllBoxes boxQuery)
    {
        _createBoxHandler = createBoxHandler;
        _boxQuery = boxQuery;
    }

    [HttpPost("create")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
    public IActionResult Create([FromBody] CreateBoxModel command)
    {
        var createBox = new CreateBox
        {
            BoxId = command.BoxId,
            NumberOfSpots = command.NumberOfSpots
        };

        var result = _createBoxHandler.Handle(createBox);

        switch (result)
        {
            case CreateBoxResult.Success:
                return Ok();
            case CreateBoxResult.InvalidNumberOfSpots:
                return BadRequest("Invalid number of bottles");
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Box>), (int)HttpStatusCode.OK)]
    public IActionResult GetAll()
    {
        return Ok(_boxQuery.Query());
    }
}