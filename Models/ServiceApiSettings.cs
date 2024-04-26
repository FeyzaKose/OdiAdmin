namespace OdiAdmin.Models
{
    public class ServiceApiSettings
    {
        public string IdentityBaseUri { get; set; }
        public string GatewayBaseUri { get; set; }
        public string UygulamaBilgileriUri { get; set; }
    }
    public class ServiceApi
    {
        public string Path { get; set; }
    }
}
