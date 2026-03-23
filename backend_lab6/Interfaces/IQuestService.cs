using backend_lab6.DTO;
namespace backend_lab6.Interfaces
{
    public interface IQuestService
    {
        List<QuestDTO> GetAll();
        QuestDTO? GetById(int id);
        QuestDTO Create(CreateQuestDTO dto);
    }
}
