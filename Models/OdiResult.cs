namespace OdiAdmin.Models
{
	public class OdiResult
	{
		public bool Sonuc { get; set; }
		public string Mesaj { get; set; } // ekranda gösterilebilecek bilgilendirme , hata, ve uyarı mesajları
        public object? Data { get; set; }=new object();
    }
}
