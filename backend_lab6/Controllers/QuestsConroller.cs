using backend_lab6.DTO;
using backend_lab6.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace backend_lab6.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuestsController : ControllerBase
{
    private readonly IQuestService _service;

    public QuestsController(IQuestService service)
    {
        _service = service;
    }

    // GET api/quests
    [HttpGet]
    public ActionResult<List<QuestDTO>> GetAll()
    {
        return Ok(_service.GetAll());
    }

    // GET api/quests/{id}
    [HttpGet("{id}")]
    public ActionResult<QuestDTO> GetById(int id)
    {
        var quest = _service.GetById(id);
        if (quest is null)
            return NotFound();

        return Ok(quest);
    }

    // POST api/quests
    [HttpPost]
    public ActionResult<QuestDTO> Create([FromBody] CreateQuestDTO dto)
    {
        var created = _service.Create(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }
}