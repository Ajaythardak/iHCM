using iHcm.Models;
using iHcm.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly PeopleService _peopleService;

    public PeopleController(PeopleService peopleService)
    {
        _peopleService = peopleService;
    }

    [HttpGet]
    public async Task<List<People>> GetPeople()
    {
        return await _peopleService.GetPeople();
    }

    [HttpGet("{id}")]
    public async Task<People> GetPeopleById(Guid id)
    {
        return await _peopleService.GetPeopleById(id);
    }

    [HttpPost]
    public async Task<IActionResult> AddPerson([FromBody] PeopleDto people)
    {
        var createdEmployee = await _peopleService.AddPeople(people);
        return CreatedAtAction(nameof(GetPeopleById), new { id = createdEmployee.Id }, createdEmployee);
    }
}
