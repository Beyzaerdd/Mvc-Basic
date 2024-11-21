using FilmAndMovie.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmAndMovie.Controllers
{
    public class ComedyController : Controller
    {
        private readonly List<Film> _comedy;

        public ComedyController()
        {
            _comedy = [
                new() {Id=1, Name="Aptallar Çetesi", Description="Tarihteki en büyük banka soygunlarından birini, mizahi bir sosla servis eden Aptallar Çetesi; 1997 yılında gerçekleştirilen, Loomis Fargo & Company adlı şirketin sürücülüğünü yapan David Scott Ghannt'ın öyküsünü perdeye taşıyor. Ghannt ve ekibinin, çaldıkları 17.3 milyon dolar ile birlikte ortadan kayboluşunu anlatan filmin başrollerinde Zach Galifianakis ve Owen Wilson yer alıyor! Filmin yönetmen koltuğundaysa Jared Hess oturuyor.\r\n\r\nYapım Yılı: 2016\r\nFilm Türü: Komedi, Polisiye\r\nYönetmen: Jared Hess\r\nOyuncular: Zach Galifianakis, Kristen Wiig, Owen Wilson\r\nÜlke: Amerika",genre=Genre.Comedy,VideoUrl="https://www.youtube.com/embed/PnVBJgoKmVg?si=Px9725RYnpqC9YDx" },

             new() {Id=2, Name="Çatlak Kankalar", Description="Filmde, Beyaz ve Siyah başkişi, bir biçimde karşılaşırlar ve birbirlerine en baştan çocuksu bir nefretle yaklaşırlar. Kendi deyişleriyle, ırkçı değillerdir (zaten ırkçıların çok azı, ırkçı olduğunu söyler; öte yandan, haksız yere ırkçılıkla suçlananlar da bulunmakta). Kendi aralarındaki çatışma, turizm bakanının verdiği yemeği birbirine katacak kadar büyüyecektir. Ceza olarak hapse atılacak olan çiftin ‘yardım’ına ‘krizden fırsat çıkarmakta usta’ olan bir televizyoncu (Tanit Phoenix’in oynadığı Kelsey) yetişecektir. Kelsey, bakanı ikna eder. İkili, hapse girmek yerine, ceza olarak, birlikte ve başbaşa bir yolculuğa çıkartılırlar. Oraya birlikte gitmelidirler; sonunda oraya arkadaş olarak varırlarsa cezaları silinecektir. Böylelikle, ikilinin eğlenceli yolculukları başlayacaktır. Üstlerinde mikrofon ve kamera olduğunu bilmezler. Oysa, tüm ülke ve daha sonra kimi başka ülkeler de, onların ‘gerçeklik gösterisi’ne kilitlenecektir; üstlerine bahisler oynanacaktır. Onlarla gülünüp onlarla ağlanacak, sonlara doğru onlarla ülkenin çoğulcu birliğine ilişkin bir şarkı tüm ülkede hep bir ağızdan söylenecektir. Kendileri bilmese de, şarkıları ülkenin değişik kesimlerini yanyana getirecektir.(1)",genre=Genre.Comedy,VideoUrl="https://www.youtube.com/embed/-PPQ0MHYfg4?si=iKV8T71kzTKTTm2K" },

              new() {Id=3, Name="Mandıra Filozofu", Description="Felsefe  Bölümü Mezunu, “Mandıra Filozofu” Mustafa Ali, Çökertme köyüne yakın, ıssız bir koyda, taş bir klübede  adeta Robinson hayatı yaşamaktadır. Birgün çok zengin bir işadamı olan Cavit Bey, görkemli yachtı ile koya gelir ve Mandıra Filozofu’nun  içinde yaşadığı araziyi satın almak ister. \r\n\r\nAncak Zengin Cavit Bey’in bilmediği bir şey vardır: Köylü diye küçümsediği Mustafa Ali, paraya ve Mal mülk alım satımına  karşı, Mandıra Filozofu’dur.\r\n\r\nBu karşılaşma Cavit Bey’in hayatını umulmadık bir şekilde değiştirecektir.",genre=Genre.Comedy,VideoUrl="https://www.youtube.com/embed/4xFe-vesxhw?si=lrZutBDJAn9a66ge"},

               new() {Id=4, Name="Neşeli Günler", Description="Neşeli Günler, 1978 yapımı bir Türk filmidir. Senaryosunu Sadık Şendil'in yazdığı filmin yönetmeni Orhan Aksoy'dur. Başrollerini, Türk sinemasının iki büyük emektarı Münir Özkul ve Adile Naşit'in turşucu rolünde oynadığı film, geçimsiz bir çiftin ayrılmasını ve gelişen olayları komik bir dille anlatmaktadır. Filmin bir diğer önemli ismi ise Ziya rolüyle müthiş bir performans gösteren Şener Şen'dir. Oyuncu kadrosunun kalitesi ve sevilen senaryosu ile 1970'li yıllardaki başarılı Türk komedi filmleri arasında yerini almıştır.\r\n\r\nMutlu bir aile... Turşuculukla geçiniyorlar... Bir gün, anne ile baba turşunun nasıl yapıldığı konusunda anlaşamazlar ve bu mutlu aile tablosu bir anda parçalanır ve anne ve baba üçer çocuğu yanlarında götürürler. Yıllar yılı birbirlerini arayıp sormazlar. Birbirlerinin hakkında herhangi bir şey duydukları zaman çıldırmaktadırlar. Aradan yıllar geçer. Çocuklar büyür ve bir gün tesadüfen karşılaşmanın ardından aileyi birçok sürpriz beklemektedir...",genre=Genre.Comedy,VideoUrl="https://www.youtube.com/embed/FQ_7cabWOv0?si=Vg2kQwvstHXnUBNL" },




            ];
        }





        public IActionResult Index()
        {
            ViewBag.Comedy = _comedy;
            return View();
        }

        public IActionResult Details(int id)
        {
            Film film = null;
            foreach (Film f in _comedy)
            {
                if (f.Id == id) { film = f; break; }


            }
            ViewBag.Film = film;
            return View();

        }
    }
}

