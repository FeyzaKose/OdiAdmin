namespace OdiAdmin.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellenmeTarihi { get; set; }
        public string EkleyenId { get; set; }
        public string Ekleyen { get; set; }
        public string GuncelleyenId { get; set; }
        public string Guncelleyen { get; set; }
    }
}
