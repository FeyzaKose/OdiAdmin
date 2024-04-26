namespace OdiAdmin.Services.UygulamaAyarlari
{
    public class DilService:IDilService
    {
        private readonly HttpClient _client;

        public DilService(HttpClient client)
        {
            _client = client;
        }
    }
}
