﻿using MakeUp_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeUp_MVC.Controllers
{
    public class EyesController : Controller
    {
        private readonly List<Eyes> _eyes;
        public EyesController()
        {

            _eyes = [
                new() {Id=1,Name="Maybeline", Description="Göz Kalemi (eyeliner), gözleri belirginleştiren ve daha çekici hale getiren önemli bir makyaj ürünüdür. Gözlerin üst veya alt kısmına uygulanan bu ürün, göz şekline göre farklı stillerde kullanılabilir. İnce ve net çizgilerle gözleri daha büyük ve parlak gösterebilirken, kalın çizgilerle de dramatik bir etki yaratılabilir. Göz kalemleri, sıvı, jel, kalem formunda ve farklı renklerde mevcut olup, her türlü makyaj tarzına uyum sağlar. Sıvı göz kalemleri genellikle uzun süre kalıcıdır ve daha net çizgiler sağlar, kalem formundaki göz kalemleri ise yumuşak bir görünüm sunar.\r\n\r\nKullanım İpuçları:\r\n\r\nÜst kirpik çizgisinin üst kısmına uygulanan ince çizgiler, gözleri daha büyük gösterir.\r\nAlt kirpik çizgisinin altına yapılan kalın çizgiler, gözleri daha belirgin hale getirebilir.\r\nDüzgün bir görünüm için, göz kalemi uygulandıktan sonra bir göz farı bazıyla harmanlanabilir.\r\n",ImageUrl="kalem.jpg"},
                 new() {Id=2,Name="Maybeline", Description="Göz Kalemi (eyeliner), gözleri belirginleştiren ve daha çekici hale getiren önemli bir makyaj ürünüdür. Gözlerin üst veya alt kısmına uygulanan bu ürün, göz şekline göre farklı stillerde kullanılabilir. İnce ve net çizgilerle gözleri daha büyük ve parlak gösterebilirken, kalın çizgilerle de dramatik bir etki yaratılabilir. Göz kalemleri, sıvı, jel, kalem formunda ve farklı renklerde mevcut olup, her türlü makyaj tarzına uyum sağlar. Sıvı göz kalemleri genellikle uzun süre kalıcıdır ve daha net çizgiler sağlar, kalem formundaki göz kalemleri ise yumuşak bir görünüm sunar.\r\n\r\nKullanım İpuçları:\r\n\r\nÜst kirpik çizgisinin üst kısmına uygulanan ince çizgiler, gözleri daha büyük gösterir.\r\nAlt kirpik çizgisinin altına yapılan kalın çizgiler, gözleri daha belirgin hale getirebilir.\r\nDüzgün bir görünüm için, göz kalemi uygulandıktan sonra bir göz farı bazıyla harmanlanabilir.\r\n",ImageUrl="kalem-1.jpg"},
                   new() {Id=3,Name="Maybeline", Description="Göz Kalemi (eyeliner), gözleri belirginleştiren ve daha çekici hale getiren önemli bir makyaj ürünüdür. Gözlerin üst veya alt kısmına uygulanan bu ürün, göz şekline göre farklı stillerde kullanılabilir. İnce ve net çizgilerle gözleri daha büyük ve parlak gösterebilirken, kalın çizgilerle de dramatik bir etki yaratılabilir. Göz kalemleri, sıvı, jel, kalem formunda ve farklı renklerde mevcut olup, her türlü makyaj tarzına uyum sağlar. Sıvı göz kalemleri genellikle uzun süre kalıcıdır ve daha net çizgiler sağlar, kalem formundaki göz kalemleri ise yumuşak bir görünüm sunar.\r\n\r\nKullanım İpuçları:\r\n\r\nÜst kirpik çizgisinin üst kısmına uygulanan ince çizgiler, gözleri daha büyük gösterir.\r\nAlt kirpik çizgisinin altına yapılan kalın çizgiler, gözleri daha belirgin hale getirebilir.\r\nDüzgün bir görünüm için, göz kalemi uygulandıktan sonra bir göz farı bazıyla harmanlanabilir.\r\n",ImageUrl="kalem-2.png"},
                     new() {Id=4,Name="Maybeline", Description="Göz Kalemi (eyeliner), gözleri belirginleştiren ve daha çekici hale getiren önemli bir makyaj ürünüdür. Gözlerin üst veya alt kısmına uygulanan bu ürün, göz şekline göre farklı stillerde kullanılabilir. İnce ve net çizgilerle gözleri daha büyük ve parlak gösterebilirken, kalın çizgilerle de dramatik bir etki yaratılabilir. Göz kalemleri, sıvı, jel, kalem formunda ve farklı renklerde mevcut olup, her türlü makyaj tarzına uyum sağlar. Sıvı göz kalemleri genellikle uzun süre kalıcıdır ve daha net çizgiler sağlar, kalem formundaki göz kalemleri ise yumuşak bir görünüm sunar.\r\n\r\nKullanım İpuçları:\r\n\r\nÜst kirpik çizgisinin üst kısmına uygulanan ince çizgiler, gözleri daha büyük gösterir.\r\nAlt kirpik çizgisinin altına yapılan kalın çizgiler, gözleri daha belirgin hale getirebilir.\r\nDüzgün bir görünüm için, göz kalemi uygulandıktan sonra bir göz farı bazıyla harmanlanabilir.\r\n",ImageUrl="kalem-3.jpg"},
                       new() {Id=5,Name="Maybeline", Description="Göz Kalemi (eyeliner), gözleri belirginleştiren ve daha çekici hale getiren önemli bir makyaj ürünüdür. Gözlerin üst veya alt kısmına uygulanan bu ürün, göz şekline göre farklı stillerde kullanılabilir. İnce ve net çizgilerle gözleri daha büyük ve parlak gösterebilirken, kalın çizgilerle de dramatik bir etki yaratılabilir. Göz kalemleri, sıvı, jel, kalem formunda ve farklı renklerde mevcut olup, her türlü makyaj tarzına uyum sağlar. Sıvı göz kalemleri genellikle uzun süre kalıcıdır ve daha net çizgiler sağlar, kalem formundaki göz kalemleri ise yumuşak bir görünüm sunar.\r\n\r\nKullanım İpuçları:\r\n\r\nÜst kirpik çizgisinin üst kısmına uygulanan ince çizgiler, gözleri daha büyük gösterir.\r\nAlt kirpik çizgisinin altına yapılan kalın çizgiler, gözleri daha belirgin hale getirebilir.\r\nDüzgün bir görünüm için, göz kalemi uygulandıktan sonra bir göz farı bazıyla harmanlanabilir.\r\n",ImageUrl="kalem-4.jpg"},
                       new(){Id=6, Name="Maybeline", Description="Maskara, kirpikleri uzatmak, yoğunlaştırmak ve belirginleştirmek için kullanılan bir makyaj ürünüdür. Maskara, genellikle siyah, kahverengi ve mavi tonlarında gelir ve göz makyajının tamamlayıcı bir unsuru olarak önemli bir rol oynar. Maskara, kirpiklerin hacmini artırarak daha dolgun ve uzun görünmesini sağlar. Özellikle hacim artırıcı ve uzun süre kalıcı formüller, kirpikleri daha etkileyici ve göz alıcı yapar.\r\n\r\nKullanım İpuçları:\r\n\r\nKirpiklere hacim katmak için, maskarayı alt kirpiklerden yukarıya doğru uygulayın.\r\nKirpik uçlarına maskara uygulamak, kirpikleri daha uzun ve belirgin gösterir.\r\nÜst kirpiklerde ise, maskarayı birkaç kat uygulayarak daha yoğun ve etkileyici bir görünüm elde edebilirsiniz.\r\nMaskara fırçasının şekli, sağladığı etkiyi değiştirir. Farklı fırça tiplerini deneyerek kirpiklerinize en uygun olanı bulabilirsiniz.",ImageUrl="mascara.jpg"},
                       new(){Id=7,Name="Note",Description="Eyeliner (Göz Kalemi), gözleri belirginleştiren ve daha çekici hale getiren vazgeçilmez bir makyaj ürünüdür. Gözlerin üzerine veya altına uygulandığında, gözleri daha büyük ve belirgin hale getirir. Eyeliner, sıvı, jel, kalem veya pudra formunda olabilir ve farklı renk seçenekleri ile farklı stiller yaratmanıza olanak tanır. İnce çizgilerle doğal bir görünüm elde edebileceğiniz gibi, kalın ve dramatik çizgilerle daha cesur bir görünüm de yaratabilirsiniz. Göz şeklinize uygun eyeliner stili, gözlerinizi ön plana çıkarır.\r\n\r\nKullanım İpuçları:\r\n\r\nİnce bir çizgiyle daha doğal bir görünüm için, sıvı eyeliner tercih edebilirsiniz.\r\nKalın çizgilerle gözleri vurgulamak istiyorsanız, jel eyeliner ya da kalem eyeliner kullanabilirsiniz.\r\nSıvı eyeliner kullanırken, hassas eller için fırçalı uçlar daha kolay bir kullanım sağlar.\r\nÜst kirpik çizgisinin üst kısmına yapılan eyeliner, gözleri daha büyük ve çekici gösterir.",ImageUrl="eyeliner.png"},

                         new(){Id=8,Name="Note",Description="Far, göz kapaklarına uygulanan renkli bir makyaj ürünüdür ve gözleri vurgulamak, derinlik katmak veya belirginleştirmek için kullanılır. Farklı dokularda (mat, saten, simli, metalik) ve geniş renk yelpazesinde bulunan farlar, göz makyajının temel öğesidir. Far, tek başına kullanılabileceği gibi, farklı tonlarla karıştırılarak göze daha dramatik bir etki de yaratılabilir. Göz farı, bazen gözlerin büyüklüğünü, şeklini veya rengini vurgulamak için de kullanılabilir. Far paletleri, genellikle birden fazla ton içerir ve bu da kullanıcılara farklı göz makyajı stilleri yaratma imkanı tanır.\r\n\r\nKullanım İpuçları:\r\n\r\nMat Farlar: Günlük kullanım için uygundur ve doğal bir görünüm elde etmenizi sağlar. Özellikle göz kapağına uygulanan mat tonlar, gözleri daha derin ve doğal gösterir.\r\nSimli ve Metalik Farlar: Özel günlerde veya gece makyajında tercih edilir. Gözleri ışıltılı ve dikkat çekici yapar.\r\nSmokey Eye (Dumanlı Göz Makyajı): Farın koyu tonlarını göz kapağının dış kısmına uygulayarak, gözleri belirgin ve derin gösterebilirsiniz.\r\nGöz Farı Bazı (Primer): Farın daha uzun süre kalıcı olmasını sağlamak için göz kapağınızın üzerine uygulayabilirsiniz.\r\nGöz Şekline Göre Uygulama: Yuvarlak gözlere sahip olanlar, farı dış köşelere doğru uygulayarak daha geniş gözler yaratabilirler.\r\nFar ve Eyeliner Uyumu: Far ile eyeliner’ı uyumlu şekilde kullanarak göz makyajını tamamlayabilirsiniz. Metalik farlar ve kalın eyeliner, dikkat çekici bir görünüm sağlar.",ImageUrl="far.jpg"},
                             new(){Id=9,Name="Note",Description="Far, göz kapaklarına uygulanan renkli bir makyaj ürünüdür ve gözleri vurgulamak, derinlik katmak veya belirginleştirmek için kullanılır. Farklı dokularda (mat, saten, simli, metalik) ve geniş renk yelpazesinde bulunan farlar, göz makyajının temel öğesidir. Far, tek başına kullanılabileceği gibi, farklı tonlarla karıştırılarak göze daha dramatik bir etki de yaratılabilir. Göz farı, bazen gözlerin büyüklüğünü, şeklini veya rengini vurgulamak için de kullanılabilir. Far paletleri, genellikle birden fazla ton içerir ve bu da kullanıcılara farklı göz makyajı stilleri yaratma imkanı tanır.\r\n\r\nKullanım İpuçları:\r\n\r\nMat Farlar: Günlük kullanım için uygundur ve doğal bir görünüm elde etmenizi sağlar. Özellikle göz kapağına uygulanan mat tonlar, gözleri daha derin ve doğal gösterir.\r\nSimli ve Metalik Farlar: Özel günlerde veya gece makyajında tercih edilir. Gözleri ışıltılı ve dikkat çekici yapar.\r\nSmokey Eye (Dumanlı Göz Makyajı): Farın koyu tonlarını göz kapağının dış kısmına uygulayarak, gözleri belirgin ve derin gösterebilirsiniz.\r\nGöz Farı Bazı (Primer): Farın daha uzun süre kalıcı olmasını sağlamak için göz kapağınızın üzerine uygulayabilirsiniz.\r\nGöz Şekline Göre Uygulama: Yuvarlak gözlere sahip olanlar, farı dış köşelere doğru uygulayarak daha geniş gözler yaratabilirler.\r\nFar ve Eyeliner Uyumu: Far ile eyeliner’ı uyumlu şekilde kullanarak göz makyajını tamamlayabilirsiniz. Metalik farlar ve kalın eyeliner, dikkat çekici bir görünüm sağlar.",ImageUrl="far-1.jpeg"},
                                     new(){Id=10,Name="Note",Description="Far, göz kapaklarına uygulanan renkli bir makyaj ürünüdür ve gözleri vurgulamak, derinlik katmak veya belirginleştirmek için kullanılır. Farklı dokularda (mat, saten, simli, metalik) ve geniş renk yelpazesinde bulunan farlar, göz makyajının temel öğesidir. Far, tek başına kullanılabileceği gibi, farklı tonlarla karıştırılarak göze daha dramatik bir etki de yaratılabilir. Göz farı, bazen gözlerin büyüklüğünü, şeklini veya rengini vurgulamak için de kullanılabilir. Far paletleri, genellikle birden fazla ton içerir ve bu da kullanıcılara farklı göz makyajı stilleri yaratma imkanı tanır.\r\n\r\nKullanım İpuçları:\r\n\r\nMat Farlar: Günlük kullanım için uygundur ve doğal bir görünüm elde etmenizi sağlar. Özellikle göz kapağına uygulanan mat tonlar, gözleri daha derin ve doğal gösterir.\r\nSimli ve Metalik Farlar: Özel günlerde veya gece makyajında tercih edilir. Gözleri ışıltılı ve dikkat çekici yapar.\r\nSmokey Eye (Dumanlı Göz Makyajı): Farın koyu tonlarını göz kapağının dış kısmına uygulayarak, gözleri belirgin ve derin gösterebilirsiniz.\r\nGöz Farı Bazı (Primer): Farın daha uzun süre kalıcı olmasını sağlamak için göz kapağınızın üzerine uygulayabilirsiniz.\r\nGöz Şekline Göre Uygulama: Yuvarlak gözlere sahip olanlar, farı dış köşelere doğru uygulayarak daha geniş gözler yaratabilirler.\r\nFar ve Eyeliner Uyumu: Far ile eyeliner’ı uyumlu şekilde kullanarak göz makyajını tamamlayabilirsiniz. Metalik farlar ve kalın eyeliner, dikkat çekici bir görünüm sağlar.",ImageUrl="far-2.jpeg"},
                                                 new(){Id=11,Name="Note",Description="Far, göz kapaklarına uygulanan renkli bir makyaj ürünüdür ve gözleri vurgulamak, derinlik katmak veya belirginleştirmek için kullanılır. Farklı dokularda (mat, saten, simli, metalik) ve geniş renk yelpazesinde bulunan farlar, göz makyajının temel öğesidir. Far, tek başına kullanılabileceği gibi, farklı tonlarla karıştırılarak göze daha dramatik bir etki de yaratılabilir. Göz farı, bazen gözlerin büyüklüğünü, şeklini veya rengini vurgulamak için de kullanılabilir. Far paletleri, genellikle birden fazla ton içerir ve bu da kullanıcılara farklı göz makyajı stilleri yaratma imkanı tanır.\r\n\r\nKullanım İpuçları:\r\n\r\nMat Farlar: Günlük kullanım için uygundur ve doğal bir görünüm elde etmenizi sağlar. Özellikle göz kapağına uygulanan mat tonlar, gözleri daha derin ve doğal gösterir.\r\nSimli ve Metalik Farlar: Özel günlerde veya gece makyajında tercih edilir. Gözleri ışıltılı ve dikkat çekici yapar.\r\nSmokey Eye (Dumanlı Göz Makyajı): Farın koyu tonlarını göz kapağının dış kısmına uygulayarak, gözleri belirgin ve derin gösterebilirsiniz.\r\nGöz Farı Bazı (Primer): Farın daha uzun süre kalıcı olmasını sağlamak için göz kapağınızın üzerine uygulayabilirsiniz.\r\nGöz Şekline Göre Uygulama: Yuvarlak gözlere sahip olanlar, farı dış köşelere doğru uygulayarak daha geniş gözler yaratabilirler.\r\nFar ve Eyeliner Uyumu: Far ile eyeliner’ı uyumlu şekilde kullanarak göz makyajını tamamlayabilirsiniz. Metalik farlar ve kalın eyeliner, dikkat çekici bir görünüm sağlar.",ImageUrl="far-70-TL.jpg"},




                ];




        }
        public IActionResult Index()
        {
            ViewBag.Eyes = _eyes;
            return View();
        }

        public IActionResult Details(int id)
        {
            Eyes eyes = null;
            foreach (Eyes e in _eyes)
            {
                if (e.Id == id)
                {
                    eyes = e;
                    break;

                }
               
            }
            ViewBag.details = eyes;
            return View();

        }
    }
}

