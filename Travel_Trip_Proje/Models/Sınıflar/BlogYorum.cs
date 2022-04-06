using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Travel_Trip_Proje.Models.Sınıflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; } //ıenumerable: belli sayıdaki değerleri koleksiyon formatında toplayan yapıdır.
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }


    }
}