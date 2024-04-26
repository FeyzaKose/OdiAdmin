namespace OdiAdmin.Models.UygulamaAyarlari
{
    public class Dil:BaseModel
    {
        public string Adi { get; set; }
        public bool Aktif { get; set; }
        public string Kisaltma { get; set; }
        public string BayrakLinki { get; set; }
    }
}
