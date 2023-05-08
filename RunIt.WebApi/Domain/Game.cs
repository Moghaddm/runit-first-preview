namespace RunIt.WebApi.Domain
{
    public class Game
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public int Release { get; set; }
        public int Rate { get; set; }
    }
}
