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
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı.";
    }
}
