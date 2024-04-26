﻿using Microsoft.AspNetCore.Identity;

namespace OdiAdmin.Models
{
    public class Kullanici :IdentityUser
    {
        public string AdSoyad { get; set; }
        public int UlkeTelefonKodu { get; set; }
        public string KayitTuruKodu { get; set; }
        public string KayitGrubuKodu { get; set; }
        public string ProfilFotografi { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime PreviusLogin { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool KVKK { get; set; }
        public bool KullaniciSozlesmesi { get; set; }
        public bool GizlilikSozlesmesi { get; set; }
        public int OdicikMiktari { get; set; }
        public string Sehir { get; set; }
        public bool CocukMu { get; set; } //18 yaşından küçükse çocuktur
        public string? VeliAdSoyad { get; set; }
        public string? VeliTelefon { get; set; }
    }
}