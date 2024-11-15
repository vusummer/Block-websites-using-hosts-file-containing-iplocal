namespace BLOCK_APP.Data.Entities
{
    public class BlockedWebsite
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime BlockedTime { get; set; }
    }
}
