using backend_lab6.DTO;
using backend_lab6.Interfaces;
using backend_lab6.Models;


namespace backend_lab6.Services;

public class QuestService : IQuestService
{
    private readonly IQuestRepo _repository;

    public QuestService(IQuestRepo repository)
    {
        _repository = repository;
    }

    public List<QuestDTO> GetAll()
    {
        return _repository.GetAll()
            .Select(q => ToDto(q))
            .ToList();
    }

    public QuestDTO? GetById(int id)
    {
        var quest = _repository.GetById(id);
        return quest is null ? null : ToDto(quest);
    }

    public QuestDTO Create(CreateQuestDTO dto)
    {
        var quest = new Quest
        {
            Name = dto.Name,
            Description = dto.Description,
            Reward = dto.Reward,
            CreatedAt = DateTime.UtcNow
        };

        var created = _repository.Add(quest);
        return ToDto(created);
    }

    private static QuestDTO ToDto(Quest quest) => new QuestDTO
    {
        Id = quest.Id,
        Name = quest.Name,
        CreatedAt = quest.CreatedAt,
        Description = quest.Description,
        Reward = quest.Reward
    };
}