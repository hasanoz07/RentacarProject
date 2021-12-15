using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static class CarManagerSuccessful
        {
            public static string CarAddedSuccessful = "Araç başarıyla eklendi";
            public static string CarDeletedSuccessful = "Araç başarıyla silindi";
            public static string CarUpdatedSuccessful = "Araç başarıyla güncellendi";
            public static string CarListedSuccessful = "Bütün araçlar listelendi";
            public static string CarGetByBrandSuccessful = "Araçlar markalarına göre listelendi";
            public static string CarGetByColorSuccessful = "Araçlar renklerine göre listelendi";
            public static string CarCarDetailSuccessful = "Araçların detayları listelendi";
        }
        public static class CarManagerError
        {
            public static string CarAddedError = "Araç eklenemedi";
            public static string CarDeletedError = "Araç silinemedi";
            public static string CarUpdatedError = "Araç güncellenemedi";
            public static string CarListedError = "Bütün araçlar listelenemedi";
            public static string CarGetByBrandError = "Araçlar markalarına göre listelenemedi";
            public static string CarGetByColorError = "Araçlar renklerine göre listelenemedi";
            public static string CarCarDetailError = "Araçların detayları listelenemedi";
        }
        public static class BrandManagerSuccessful
        {
            public static string BrandAddedSuccessful = "Marka başarıyla eklendi";
            public static string BrandDeletedSuccessful = "Marka başarıyla silindi";
            public static string BrandUpdatedSuccessful = "Marka başarıyla güncellendi";
            public static string BrandListedSuccessful = "Bütün markalar listelendi";
            public static string BrandGetByBrandSuccessful = "Marka ID'ye göre getirildi";
        }
        public static class BrandManagerError
        {
            public static string BrandAddedError = "Marka eklenemedi";
            public static string BrandDeletedError = "Marka silinemedi";
            public static string BrandUpdatedError = "Marka güncellenemedi";
            public static string BrandListedError = "Bütün markalar listelenemedi";
            public static string BrandGetByBrandError = "Markalar ID'ye göre listelenemedi";
        }
        public static class ColorManagerSuccessful
        {
            public static string ColorAddedSuccessful = "Renk başarıyla eklendi";
            public static string ColorDeletedSuccessful = "Renk başarıyla silindi";
            public static string ColorUpdatedSuccessful = "Renk başarıyla güncellendi";
            public static string ColorListedSuccessful = "Bütün renkler listelendi";
            public static string ColorGetByColorSuccessful = "Renkler ID'ye göre getirildi";
        }
        public static class ColorManagerError
        {
            public static string ColorAddedError = "Renk eklenemedi";
            public static string ColorDeletedError = "Renk silinemedi";
            public static string ColorUpdatedError = "Renk güncellenemedi";
            public static string ColorListedError = "Bütün renkler listelenemedi";
            public static string ColorGetByColorError = "Renkler ID'ye göre listelenemedi";
        }
        public static class UserManagerSuccessful
        {
            public static string UserAddedSuccessful = "Kullanıcı başarıyla eklendi";
            public static string UserDeletedSuccessful = "Kullanıcı başarıyla silindi";
            public static string UserUpdatedSuccessful = "Kullanıcı başarıyla güncellendi";
            public static string UserListedSuccessful = "Kullanıcılar listelendi";
            public static string GetByUserSuccessful = "Kullanıcılar ID'ye göre getirildi";
        }
        public static class UserManagerError
        {
            public static string UserAddedError = "Kullanıcı eklenemedi";
            public static string UserDeletedError = "Kullanıcı silinemedi";
            public static string UserUpdatedError = "Kullanıcı güncellenemedi";
            public static string UserListedError = "Kullanıcılarlistelenemedi";
            public static string GetByUserError = "Kullanıcılar ID'ye göre listelenemedi";
        }
        public static class CustomerManagerSuccessful
        {
            public static string CustomerAddedSuccessful = "Müşteri başarıyla eklendi";
            public static string CustomerDeletedSuccessful = "Müşteri başarıyla silindi";
            public static string CustomerUpdatedSuccessful = "Müşteri başarıyla güncellendi";
            public static string CustomerListedSuccessful = "Müşteriler listelendi";
            public static string GetByCustomerSuccessful = "Müşteriler ID'ye göre getirildi";
        }
        public static class CustomerManagerError
        {
            public static string CustomerAddedError = "Müşteri eklenemedi";
            public static string CustomerDeletedError = "Müşteri silinemedi";
            public static string CustomerUpdatedError = "Müşteri güncellenemedi";
            public static string CustomerListedError = "Müşteriler listelenemedi";
            public static string GetByCustomerError = "Müşteriler ID'ye göre listelenemedi";
        }
        public static class RentalManagerSuccessful
        {
            public static string RentalAddedSuccessful = "Araç kiralama işlemi başarıyla eklendi";
            public static string RentalDeletedSuccessful = "Araç kiralama işlemi başarıyla silindi";
            public static string RentalUpdatedSuccessful = "Araç kiralama işlemi başarıyla güncellendi";
            public static string RentalListedSuccessful = "Araç kiralama işlemleri listelendi";
            public static string GetByRentalSuccessful = "Araç kiralama işlemi ID'ye göre getirildi";
        }
        public static class RentalManagerError
        {
            public static string RentalAddedError = "Araç kiralama işlemi eklenemedi";
            public static string RentalDeletedError = "Araç kiralama işlemi silinemedi";
            public static string RentalUpdatedError = "Araç kiralama işlemi güncellenemedi";
            public static string RentalListedError = "Araç kiralama işlemleri listelenemedi";
            public static string GetByRentalError = "Araç kiralama işlemi ID'ye göre listelenemedi";
        }
        public static class CarImageSuccessful
        {
            public static string CarImageAddedSuccessful = "Araç resmi ekleme işlemi başarıyla gerçekleşti";
            public static string CarImageDeletedSuccessful = "Araç resmi silme işlemi başarıyla gerçekleşti";
            public static string CarImageUpdatedSuccessful = "Araç resmi güncelleme işlemi başarıyla gerçekleşti";
            public static string CarImageListedSuccessful = "Araç resimleri listelendi";
            public static string GetByCarImageSuccessful = "Araç resmi getirme işlemi ID'ye göre getirildi";
        }
        public static class CarImageError
        {
            public static string CarImageAddedError = "Araç resmi ekleme işlemi hata verdi";
            public static string CarImageDeletedError = "Araç resmi silme işlemi hata verdi";
            public static string CarImageUpdatedError = "Araç resmi güncelleme işlemi hata verdi";
            public static string CarImageListedError = "Araç resimleri listelenemedi";
            public static string GetByCarImageError = "Araç resmi getirme işlemi ID'ye göre getirilmedi";
        }
        public static class AuthManagerError
        {
            public static string UserRegistered = "Kullanıcı kayıt oldu";
            public static string CarImageDeletedError = "Araç resmi silme işlemi hata verdi";
            public static string CarImageUpdatedError = "Araç resmi güncelleme işlemi hata verdi";
            public static string CarImageListedError = "Araç resimleri listelenemedi";
            public static string GetByCarImageError = "Araç resmi getirme işlemi ID'ye göre getirilmedi";
        }
        
        public static string AuthorizationDenied = "Yetki yok";



    }
}
