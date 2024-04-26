namespace OdiAdmin.Models
{
    public class ClientSettings
    {
        public Client OdiAdminClient { get; set; }
        public Client OdiAdminClientForUser { get; set; }
    }
    public class Client
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
