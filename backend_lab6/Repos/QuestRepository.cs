using backend_lab6.Interfaces;
using backend_lab6.Models;

namespace backend_lab6.Repos
{
    public class QuestRepository : IQuestRepo
    {
        private readonly List<Quest> _quests = new();
        private int _nextId = 1;

        public List<Quest> GetAll() => _quests;
        public Quest? GetById(int id) => _quests.FirstOrDefault(i => i.Id == id);
        public Quest Add(Quest quest)
        {
            quest.Id = _nextId++;
            _quests.Add(quest);
            return quest;
        }

    }
}
