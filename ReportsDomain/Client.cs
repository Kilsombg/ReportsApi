namespace ReportsDomain
{
    public class Client : BaseEntity
    {
        public int ConfigId { get; set; }
        public string? Name { get; set; }
        public string? DDS { get; set; }
    }
}