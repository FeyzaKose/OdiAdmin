namespace OdiAdmin.Models
{
    public class OdiUser
    {
        public string Id { get; set; }
        public string AdSoyad { get; set; }
        public string ProfilFotografi { get; set; }
        public string TelefonNumarasi { get; set; }
        public int UlkeTelefonKodu { get; set; }
        public string Email { get; set; }
        public DateTime SonGirisTarihi { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string KayitTuruKodu { get; set; }
        public string KayitGrubuKodu { get; set; }
        public string Sehir { get; set; }

        public IEnumerable<string> GetUserProps()
        {
            yield return AdSoyad;
            yield return ProfilFotografi;
            yield return Id;
        }
    }
}
