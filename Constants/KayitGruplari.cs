namespace OdiAdmin.Constants
{
    public static class KayitGruplari
    {
        public static readonly string OdiYoneticisi = "ODIY";
        public static readonly string Yetenek = "YTNK";
        public static readonly string Yapim = "YAPM";
        public static readonly string YetenekTemsilcisi = "YTTM";
        public static readonly string HizmetSaglayici = "HZMS";

        private static readonly Dictionary<string, string> KodToDescription = new Dictionary<string, string>
        {
            { OdiYoneticisi, "Odi Yöneticisi" },
            { Yetenek, "Yetenek" },
            { Yapim, "Yapım" },
            { YetenekTemsilcisi, "Yetenek Temsilcisi" },
            { HizmetSaglayici, "Hizmet Sağlayıcı" }
        };
        public static Dictionary<string, string> GetAllDescriptions()
        {
            return KodToDescription;
        }
        public static string GetDescription(string kod)
        {
            if (KodToDescription.TryGetValue(kod, out var description))
            {
                return description;
            }
            return "Bilinmeyen Kod";
        }
    }
}
