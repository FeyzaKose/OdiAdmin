namespace OdiAdmin.Tools
{
    public static class Endpoints
    {
        public static class Kullanici
        {
            public const string YetenekTemsilcisiListe = "/api/admin/yetenektemsilcisilistesigetir";
            public const string GetirByToken = "/servis/global/get-user-by-token";
        }
        public static class UygulamaBilgileri
        {
            public const string DilListesi = "/servis/uygulama-bilgileri/admin/dil-listesi";
            public const string KullaniciListesi = "/user/kullanici-listesi";
        }

        public static class Projeler
        {
            public const string ProjeGetir = "/projeler/proje-getir";
            public const string ProjeListesi = "/projeler/proje-listesi";
        }
    }
    
}
