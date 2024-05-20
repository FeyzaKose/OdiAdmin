namespace OdiAdmin.Models.UygulamaAyarlari
{
    public class FizikselOzellikTipi:BaseModel
    {
        public string FizikselOzellikTipAdi { get; set; }
        public string FizikselOzellikTipKodu { get; set; }//3 karakter
        public int DilId { get; set; }
        public bool Durum { get; set; }
    } 
}
  