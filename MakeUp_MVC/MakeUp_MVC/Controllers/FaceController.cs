using MakeUp_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeUp_MVC.Controllers
{
    public class FaceController : Controller
    {
        private readonly List<Face> _faces;

        public FaceController()
        {
            _faces = [
                new(){Id=1,Name="Golden Rose",Description="\"Fondöten, cilt tonunu eşitlemek ve kusurları gizlemek için kullanılan makyaj ürünüdür. Cilt tipinize uygun fondöten seçimi ile doğal bir görünüm elde edebilir, cildinize mat veya ışıltılı bir hava katabilirsiniz. Kapatıcı ve uzun süre kalıcı formülleriyle fondöten, gün boyu taze bir makyaj sağlar.\"",ImageUrl="f.jpg"},
                 new(){Id=2,Name="Maybelıne Newyork",Description="\"Fondöten, cilt tonunu eşitlemek ve kusurları gizlemek için kullanılan makyaj ürünüdür. Cilt tipinize uygun fondöten seçimi ile doğal bir görünüm elde edebilir, cildinize mat veya ışıltılı bir hava katabilirsiniz. Kapatıcı ve uzun süre kalıcı formülleriyle fondöten, gün boyu taze bir makyaj sağlar.\"",ImageUrl="f-2.jpg"},
                  new(){Id=3,Name="FLormar",Description="\"Fondöten, cilt tonunu eşitlemek ve kusurları gizlemek için kullanılan makyaj ürünüdür. Cilt tipinize uygun fondöten seçimi ile doğal bir görünüm elde edebilir, cildinize mat veya ışıltılı bir hava katabilirsiniz. Kapatıcı ve uzun süre kalıcı formülleriyle fondöten, gün boyu taze bir makyaj sağlar.\"",ImageUrl="f-3.jpg"},
                   new(){Id=4,Name="Loreal Paris",Description="\"Fondöten, cilt tonunu eşitlemek ve kusurları gizlemek için kullanılan makyaj ürünüdür. Cilt tipinize uygun fondöten seçimi ile doğal bir görünüm elde edebilir, cildinize mat veya ışıltılı bir hava katabilirsiniz. Kapatıcı ve uzun süre kalıcı formülleriyle fondöten, gün boyu taze bir makyaj sağlar.\"",ImageUrl="f-4.jpeg"},
                    new(){Id=5,Name="Golden Rose",Description="\"Fondöten, cilt tonunu eşitlemek ve kusurları gizlemek için kullanılan makyaj ürünüdür. Cilt tipinize uygun fondöten seçimi ile doğal bir görünüm elde edebilir, cildinize mat veya ışıltılı bir hava katabilirsiniz. Kapatıcı ve uzun süre kalıcı formülleriyle fondöten, gün boyu taze bir makyaj sağlar.\"",ImageUrl="f-4.jpg"},
                     new(){Id=6,Name="Avon",Description="\"Allık, yanaklara renk ve canlılık katmak için kullanılan bir makyaj ürünüdür. Cildinize taze ve genç bir görünüm kazandırırken, kontür yaparak yüz hatlarınızı belirginleştirir. Farklı tonlarıyla doğal, şeftali veya pembe tonlarında ışıltılı bir görünüm elde edebilirsiniz.\"",ImageUrl="a-1.jpg"},
                       new(){Id=7,Name="Note",Description="\"Allık, yanaklara renk ve canlılık katmak için kullanılan bir makyaj ürünüdür. Cildinize taze ve genç bir görünüm kazandırırken, kontür yaparak yüz hatlarınızı belirginleştirir. Farklı tonlarıyla doğal, şeftali veya pembe tonlarında ışıltılı bir görünüm elde edebilirsiniz.\"",ImageUrl="a-2.jpeg"},
                    new(){Id=8,Name="Rare Beauty",Description="\"Allık, yanaklara renk ve canlılık katmak için kullanılan bir makyaj ürünüdür. Cildinize taze ve genç bir görünüm kazandırırken, kontür yaparak yüz hatlarınızı belirginleştirir. Farklı tonlarıyla doğal, şeftali veya pembe tonlarında ışıltılı bir görünüm elde edebilirsiniz.\"",ImageUrl="a-3.jpg"},
                     new(){Id=9,Name="Farmasi",Description="\"Allık, yanaklara renk ve canlılık katmak için kullanılan bir makyaj ürünüdür. Cildinize taze ve genç bir görünüm kazandırırken, kontür yaparak yüz hatlarınızı belirginleştirir. Farklı tonlarıyla doğal, şeftali veya pembe tonlarında ışıltılı bir görünüm elde edebilirsiniz.\"",ImageUrl="a-4.jpeg"},
                       new(){Id=10,Name="Farmasi",Description="Kapatıcı, ciltteki kusurları ve renk eşitsizliklerini gizlemek için kullanılan makyaj ürünüdür. Göz altı morlukları, sivilceler veya lekeler gibi sorunları kolayca örtmek için ideal bir üründür. Cildinize doğal bir görünüm verirken, makyajın kalıcılığını artırır.\"\r\n\r\nBu açıklamalar, her bir ürünün kullanım amacını ve faydalarını vurgulayan kısa ve etkili tanımlar sağlar.",ImageUrl="c-2.jpeg"},
                     new(){Id=11,Name="Maybeline Newyork",Description="Kapatıcı, ciltteki kusurları ve renk eşitsizliklerini gizlemek için kullanılan makyaj ürünüdür. Göz altı morlukları, sivilceler veya lekeler gibi sorunları kolayca örtmek için ideal bir üründür. Cildinize doğal bir görünüm verirken, makyajın kalıcılığını artırır.\"\r\n\r\nBu açıklamalar, her bir ürünün kullanım amacını ve faydalarını vurgulayan kısa ve etkili tanımlar sağlar.",ImageUrl="c-6.jpg"},
                      new(){Id=12,Name="Pastel",Description="Kapatıcı, ciltteki kusurları ve renk eşitsizliklerini gizlemek için kullanılan makyaj ürünüdür. Göz altı morlukları, sivilceler veya lekeler gibi sorunları kolayca örtmek için ideal bir üründür. Cildinize doğal bir görünüm verirken, makyajın kalıcılığını artırır.\"\r\n\r\nBu açıklamalar, her bir ürünün kullanım amacını ve faydalarını vurgulayan kısa ve etkili tanımlar sağlar.",ImageUrl="c-5.png"},

                ];
        }
        public IActionResult Index()
        {
            ViewBag.Face = _faces;
            return View();
        }
        public IActionResult Details(int id)
        {
            Face face = null;
            foreach (Face f in _faces)
            { if(f.Id == id)
                {  face = f; break; }
               
            }

            ViewBag.faceProduct= face;
            return View();
        }


    }
}
