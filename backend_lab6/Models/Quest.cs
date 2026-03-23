namespace backend_lab6.Models
{
    public class Quest
    {
        public int Id {  get; set; }
        public string Name { get; set;  } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Reward { get; set; }
    }
}
