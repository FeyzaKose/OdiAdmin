namespace OdiAdmin.Tools
{
    public static class Endpoints
    {
        public static class GlobalKullanici
        {
            public const string YetenekTemsilcisiListe = "/servis/global/admin-yetenek-temsilcisi-listesi-getir";
            public const string GetirByToken = "/servis/global/get-user-by-token";
        }
        public static class UygulamaBilgileri
        {
            public static class Dil
            {
                public const string DilListesi = "/servis/admin-uygulama-bilgileri/dil-listesi";
            }
            public static class FizikselOzellikler
            {
                public const string TipListesi = "/servis/performer/admin-fiziksel-ozellik-tipi-liste";
                public const string YeniTip = "/servis/performer/admin-yeni-fiziksel-ozellik-tipi";
                public const string TipGuncelle = "/servis/performer/admin-fiziksel-ozellik-tipi-guncelle";
            }

            public const string KullaniciListesi = "/user/kullanici-listesi";
        }

        public static class Projeler
        {
            public const string ProjeGetir = "/projeler/proje-getir";
            public const string ProjeListesi = "/projeler/proje-listesi";
        }
    }
    
}
