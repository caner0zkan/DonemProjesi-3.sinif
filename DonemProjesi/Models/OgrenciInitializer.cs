using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DonemProjesi.Models
{
    public class OgrenciInitializer : DropCreateDatabaseIfModelChanges<OgrenciContext>  //Context'deki tablolarda bir değişiklik olursa silip en baştan yükler.
    {
        protected override void Seed(OgrenciContext context)   //seed metodu test verileri eklememizi sağlar
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>() {
                new Ogrenci(){OgrenciNumarasi=1, Ad="Buse", Soyad="Dokuzlar", Bolum="Bilgisayar Mühendisliği", Sinif=2,Yetenekler="c, java, python", Sifre="123"},
                new Ogrenci(){OgrenciNumarasi=2, Ad="Halil Taşkın", Soyad="Karadeniz", Bolum="Makine Mühendisliği", Sinif=1,Yetenekler="c++, js",  Sifre="123"},
                new Ogrenci(){OgrenciNumarasi=3, Ad="Süleyman Emre", Soyad="Akar", Bolum="Kimya Mühendisliği", Sinif=3,Yetenekler="python, sql",  Sifre="333"},
                new Ogrenci(){OgrenciNumarasi=4, Ad="Ali", Soyad="Yılmaz", Bolum="Bilgisayar Mühendisliği", Sinif=2,Yetenekler="excel, c",  Sifre="abc"}
            };

            foreach (var item in ogrenciler)
            {
                context.Ogrenciler.Add(item);
            }
            context.SaveChanges();




            List<Proje> projeler = new List<Proje>() {
                new Proje(){ ProjeAdi="Görüntü işleme", Aciklama="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et lobortis sapien. Mauris bibendum eleifend nunc, et malesuada tortor bibendum at. Sed vel risus nec mi varius porta efficitur ac neque. Sed volutpat sed magna ut fermentum. Maecenas in lectus hendrerit, semper arcu ut, condimentum leo. Vestibulum mi odio, consequat eget venenatis non, condimentum non nibh. Sed viverra justo urna. In quam nibh, luctus aliquam lorem ut, commodo hendrerit lacus. Ut nisl mauris, pulvinar vitae turpis eu, finibus blandit ipsum. Pellentesque euismod iaculis ex. Nulla eget lacus pellentesque ante auctor porttitor et quis leo. Mauris nec ante non enim eleifend.", EklenmeTarihi=DateTime.Now.AddDays(-10), OgrenciID=1},
                new Proje(){ ProjeAdi="Yapay Zeka", Aciklama="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et lobortis sapien. Mauris bibendum eleifend nunc, et malesuada tortor bibendum at. Sed vel risus nec mi varius porta efficitur ac neque. Sed volutpat sed magna ut fermentum. Maecenas in lectus hendrerit, semper arcu ut, condimentum leo. Vestibulum mi odio, consequat eget venenatis non, condimentum non nibh. Sed viverra justo urna. In quam nibh, luctus aliquam lorem ut, commodo hendrerit lacus. Ut nisl mauris, pulvinar vitae turpis eu, finibus blandit ipsum. Pellentesque euismod iaculis ex. Nulla eget lacus pellentesque ante auctor porttitor et quis leo. Mauris nec ante non enim eleifend.", EklenmeTarihi=DateTime.Now.AddDays(-6), OgrenciID=2},
                new Proje(){ ProjeAdi="Mobil Uygulama", Aciklama="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et lobortis sapien. Mauris bibendum eleifend nunc, et malesuada tortor bibendum at. Sed vel risus nec mi varius porta efficitur ac neque. Sed volutpat sed magna ut fermentum. Maecenas in lectus hendrerit, semper arcu ut, condimentum leo. Vestibulum mi odio, consequat eget venenatis non, condimentum non nibh. Sed viverra justo urna. In quam nibh, luctus aliquam lorem ut, commodo hendrerit lacus. Ut nisl mauris, pulvinar vitae turpis eu, finibus blandit ipsum. Pellentesque euismod iaculis ex. Nulla eget lacus pellentesque ante auctor porttitor et quis leo. Mauris nec ante non enim eleifend.", EklenmeTarihi=DateTime.Now.AddDays(-3), OgrenciID=3},
                new Proje(){ ProjeAdi="Makine Motoru", Aciklama="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque et lobortis sapien. Mauris bibendum eleifend nunc, et malesuada tortor bibendum at. Sed vel risus nec mi varius porta efficitur ac neque. Sed volutpat sed magna ut fermentum. Maecenas in lectus hendrerit, semper arcu ut, condimentum leo. Vestibulum mi odio, consequat eget venenatis non, condimentum non nibh. Sed viverra justo urna. In quam nibh, luctus aliquam lorem ut, commodo hendrerit lacus. Ut nisl mauris, pulvinar vitae turpis eu, finibus blandit ipsum. Pellentesque euismod iaculis ex. Nulla eget lacus pellentesque ante auctor porttitor et quis leo. Mauris nec ante non enim eleifend.", EklenmeTarihi=DateTime.Now.AddDays(-15), OgrenciID=4}
            };

            foreach (var item in projeler)
            {
                context.Projeler.Add(item);
            }
            context.SaveChanges();




            List<Basvuru> basvurular = new List<Basvuru>() {
                new Basvuru(){ProjeSahibimi=true, KabulEdildimi=true},
                new Basvuru(){ProjeSahibimi=true, KabulEdildimi=true},
                new Basvuru(){ProjeSahibimi=true, KabulEdildimi=true},
                new Basvuru(){ProjeSahibimi=true, KabulEdildimi=true},
            };

            foreach (var item in basvurular)
            {
                context.Basvurular.Add(item);
            }
            context.SaveChanges();


            base.Seed(context);
        }
    }
}
