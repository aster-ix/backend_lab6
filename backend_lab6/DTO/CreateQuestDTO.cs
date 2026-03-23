namespace backend_lab6.DTO
{
    public class CreateQuestDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Reward { get; set; }
    }
}
