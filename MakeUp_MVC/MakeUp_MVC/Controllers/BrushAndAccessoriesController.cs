using MakeUp_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeUp_MVC.Controllers
{
    public class BrushAndAccessoriesController : Controller
    {
        private readonly List<brush> _brushes;
        public BrushAndAccessoriesController() {

            _brushes = [
                new(){Id=1,Name="Makyaj Fırçası",Description="Makyaj fırçaları, makyaj ürünlerini düzgün ve profesyonel bir şekilde uygulamak için tasarlanmış en önemli araçlardır. Farklı boyutlarda, şekillerde ve malzemelerden üretilen fırçalar, her makyaj ürününe ve tekniğine özel olarak kullanılır. Doğru fırça seçimi, makyajın daha pürüzsüz ve etkili görünmesini sağlar. Sentetik ve doğal kıllardan yapılabilen makyaj fırçaları, her bütçeye uygun seçeneklerle makyaj severlerin vazgeçilmez yardımcısıdır.\r\n\r\nMakyaj Fırçası Çeşitleri ve Kullanım Alanları:\r\n\r\nFondöten Fırçası: Likit veya krem fondöteni eşit bir şekilde cilde yaymak için kullanılır. Genellikle düz veya yuvarlak uçlu olur. Pürüzsüz ve doğal bir cilt görünümü sağlar.\r\n\r\nAllık Fırçası: Yumuşak ve yuvarlak yapılıdır. Yanaklara allık veya bronzer uygulamak için idealdir. Ürünü ciltte homojen şekilde dağıtarak doğal bir görünüm yaratır.\r\n\r\nFar Fırçası: Göz kapaklarına far uygulamak için kullanılır. Detaylı göz makyajı için farklı boyutlarda ve şekillerde çeşitleri bulunur. Dağıtma (blending) fırçası, far geçişlerini yumuşatmak için idealdir.\r\n\r\nPudra Fırçası: Büyük ve kabarık yapılıdır. Toz veya kompakt pudrayı cilde eşit bir şekilde uygulamak için kullanılır. Doğal bir mat görünüm elde etmenize yardımcı olur.\r\n\r\nDudak Fırçası: Ruj veya dudak parlatıcısını hassas bir şekilde uygulamak için kullanılır. Dudak hatlarını belirginleştirir ve ürünün taşmasını önler.\r\n\r\nEyeliner Fırçası: İnce ve keskin uçludur. Jel veya sıvı eyeliner uygulaması için idealdir. Keskin ve düzgün bir çizgi çekmenizi sağlar.\r\n\r\nKontür Fırçası: Yüz hatlarını belirginleştirmek için kullanılan kontür ürünlerini cilde uygulamak ve dağıtmak için kullanılır. Açılı yapısı sayesinde kolay bir uygulama sağlar.\r\n\r\nKaş Fırçası: Kaşları şekillendirmek ve kaş ürünlerini düzgün bir şekilde dağıtmak için kullanılır. Spoolie (spiral) şeklindeki fırçalar, kaşları taramak ve doğal bir görünüm elde etmek için idealdir.\r\n\r\nKullanım İpuçları:\r\n\r\nFırçaları düzenli olarak temizlemek, hem hijyen hem de ürün performansı açısından önemlidir.\r\nDoğru fırçayı kullanmak, makyajın daha doğal ve profesyonel görünmesini sağlar.\r\nBir fırçayı birden fazla ürün için kullanmaktan kaçının; aksi halde renkler karışabilir." , ImgUrl="img-1.png"},


                    new(){Id=2,Name="Makyaj Fırçası",Description="Makyaj fırçaları, makyaj ürünlerini düzgün ve profesyonel bir şekilde uygulamak için tasarlanmış en önemli araçlardır. Farklı boyutlarda, şekillerde ve malzemelerden üretilen fırçalar, her makyaj ürününe ve tekniğine özel olarak kullanılır. Doğru fırça seçimi, makyajın daha pürüzsüz ve etkili görünmesini sağlar. Sentetik ve doğal kıllardan yapılabilen makyaj fırçaları, her bütçeye uygun seçeneklerle makyaj severlerin vazgeçilmez yardımcısıdır.\r\n\r\nMakyaj Fırçası Çeşitleri ve Kullanım Alanları:\r\n\r\nFondöten Fırçası: Likit veya krem fondöteni eşit bir şekilde cilde yaymak için kullanılır. Genellikle düz veya yuvarlak uçlu olur. Pürüzsüz ve doğal bir cilt görünümü sağlar.\r\n\r\nAllık Fırçası: Yumuşak ve yuvarlak yapılıdır. Yanaklara allık veya bronzer uygulamak için idealdir. Ürünü ciltte homojen şekilde dağıtarak doğal bir görünüm yaratır.\r\n\r\nFar Fırçası: Göz kapaklarına far uygulamak için kullanılır. Detaylı göz makyajı için farklı boyutlarda ve şekillerde çeşitleri bulunur. Dağıtma (blending) fırçası, far geçişlerini yumuşatmak için idealdir.\r\n\r\nPudra Fırçası: Büyük ve kabarık yapılıdır. Toz veya kompakt pudrayı cilde eşit bir şekilde uygulamak için kullanılır. Doğal bir mat görünüm elde etmenize yardımcı olur.\r\n\r\nDudak Fırçası: Ruj veya dudak parlatıcısını hassas bir şekilde uygulamak için kullanılır. Dudak hatlarını belirginleştirir ve ürünün taşmasını önler.\r\n\r\nEyeliner Fırçası: İnce ve keskin uçludur. Jel veya sıvı eyeliner uygulaması için idealdir. Keskin ve düzgün bir çizgi çekmenizi sağlar.\r\n\r\nKontür Fırçası: Yüz hatlarını belirginleştirmek için kullanılan kontür ürünlerini cilde uygulamak ve dağıtmak için kullanılır. Açılı yapısı sayesinde kolay bir uygulama sağlar.\r\n\r\nKaş Fırçası: Kaşları şekillendirmek ve kaş ürünlerini düzgün bir şekilde dağıtmak için kullanılır. Spoolie (spiral) şeklindeki fırçalar, kaşları taramak ve doğal bir görünüm elde etmek için idealdir.\r\n\r\nKullanım İpuçları:\r\n\r\nFırçaları düzenli olarak temizlemek, hem hijyen hem de ürün performansı açısından önemlidir.\r\nDoğru fırçayı kullanmak, makyajın daha doğal ve profesyonel görünmesini sağlar.\r\nBir fırçayı birden fazla ürün için kullanmaktan kaçının; aksi halde renkler karışabilir." , ImgUrl="img-2.png"},


                    new(){Id=3,Name="Makyaj Fırçası",Description="Makyaj fırçaları, makyaj ürünlerini düzgün ve profesyonel bir şekilde uygulamak için tasarlanmış en önemli araçlardır. Farklı boyutlarda, şekillerde ve malzemelerden üretilen fırçalar, her makyaj ürününe ve tekniğine özel olarak kullanılır. Doğru fırça seçimi, makyajın daha pürüzsüz ve etkili görünmesini sağlar. Sentetik ve doğal kıllardan yapılabilen makyaj fırçaları, her bütçeye uygun seçeneklerle makyaj severlerin vazgeçilmez yardımcısıdır.\r\n\r\nMakyaj Fırçası Çeşitleri ve Kullanım Alanları:\r\n\r\nFondöten Fırçası: Likit veya krem fondöteni eşit bir şekilde cilde yaymak için kullanılır. Genellikle düz veya yuvarlak uçlu olur. Pürüzsüz ve doğal bir cilt görünümü sağlar.\r\n\r\nAllık Fırçası: Yumuşak ve yuvarlak yapılıdır. Yanaklara allık veya bronzer uygulamak için idealdir. Ürünü ciltte homojen şekilde dağıtarak doğal bir görünüm yaratır.\r\n\r\nFar Fırçası: Göz kapaklarına far uygulamak için kullanılır. Detaylı göz makyajı için farklı boyutlarda ve şekillerde çeşitleri bulunur. Dağıtma (blending) fırçası, far geçişlerini yumuşatmak için idealdir.\r\n\r\nPudra Fırçası: Büyük ve kabarık yapılıdır. Toz veya kompakt pudrayı cilde eşit bir şekilde uygulamak için kullanılır. Doğal bir mat görünüm elde etmenize yardımcı olur.\r\n\r\nDudak Fırçası: Ruj veya dudak parlatıcısını hassas bir şekilde uygulamak için kullanılır. Dudak hatlarını belirginleştirir ve ürünün taşmasını önler.\r\n\r\nEyeliner Fırçası: İnce ve keskin uçludur. Jel veya sıvı eyeliner uygulaması için idealdir. Keskin ve düzgün bir çizgi çekmenizi sağlar.\r\n\r\nKontür Fırçası: Yüz hatlarını belirginleştirmek için kullanılan kontür ürünlerini cilde uygulamak ve dağıtmak için kullanılır. Açılı yapısı sayesinde kolay bir uygulama sağlar.\r\n\r\nKaş Fırçası: Kaşları şekillendirmek ve kaş ürünlerini düzgün bir şekilde dağıtmak için kullanılır. Spoolie (spiral) şeklindeki fırçalar, kaşları taramak ve doğal bir görünüm elde etmek için idealdir.\r\n\r\nKullanım İpuçları:\r\n\r\nFırçaları düzenli olarak temizlemek, hem hijyen hem de ürün performansı açısından önemlidir.\r\nDoğru fırçayı kullanmak, makyajın daha doğal ve profesyonel görünmesini sağlar.\r\nBir fırçayı birden fazla ürün için kullanmaktan kaçının; aksi halde renkler karışabilir." , ImgUrl="img-7.png"},

                ];
        
        
        }



        public IActionResult Index()
        {
            ViewBag.Brush = _brushes;
            return View();
        }

        public IActionResult Details(int id) {
            brush bru = null;
            foreach (brush b in _brushes)
            {
                if (b.Id == id)
                {
                    bru= b;
                    break;
                }
                
            }
            ViewBag.Brush = bru;
            return View();
        }
    }
}
