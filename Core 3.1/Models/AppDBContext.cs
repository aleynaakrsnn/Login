using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3._1.Models
{
    public class AppDBContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public AppDBContext(DbContextOptions options): base(options)
        {
            _options = options; 
        }

        //VERİTABANI İLK DEFA OLUŞTURULURKEN CALISAN BİR VİRTUAL METOTDUR. bU METOT SAYESİNDE VERİTABANI TABLOLARO OLUSTURMADAN ARAYA GİRECEK TABLO İSİMLERİNE MÜDAHELE EDEBİLCEK  VEYA KOLONLARA  İSTEDİGİMİZ  AYARLARI GERÇEKLEŞTİRMEK İÇİN KULLANILIR.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
