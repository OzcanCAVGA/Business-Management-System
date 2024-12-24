using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun eklendi";
        public static string NotProductAdd = "Urun eklenemedi.";
        public static string ProductCountOfCategoryError = "10 adet urunden fazla urun var";
        public static string ProductNameAlreadyExists = "Bu isimde bir urun var";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductsListed = "Urunler listelendi";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kayit oldu";
        public static string UserNotFound = "Kullanici bulunamadi";
        public static string PasswordError = "Parola hatasi";
        public static string SuccessfulLogin = "Basarili giris";
        public static string UserAlreadyExists = "Kullanici Mevcut";
        public static string AccessTokenCreated = "Token olusturuldu";

        public static string ProductUpdated = "Urun guncellendi";
    }
}
