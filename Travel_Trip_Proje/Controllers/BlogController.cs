using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Proje.Models.Sınıflar; //ekliyoruz

namespace Travel_Trip_Proje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(2).ToList();
            return View(by);
        }
        
        public ActionResult BlogDetay(int id) //blogda detay kısmına gidebilmek için blogdetaya tıklayıo view ekliyoruz.
        {
            //var blogBul = c.Blogs.Where(x => x.ID == id).ToList();  //x eşit büyüktür blog id si benim göndermiş olduğum id ye eşit olan blogun listesini getir
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();


            return View(by); //bulmuş olan blogu döndür

        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}