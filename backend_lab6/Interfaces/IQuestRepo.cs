using backend_lab6.Models;
namespace backend_lab6.Interfaces
{
    public interface IQuestRepo
    {
        List<Quest> GetAll();
        Quest? GetById(int id);
        Quest Add(Quest quest);
    }
}

