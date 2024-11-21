using FilmAndMovie.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmAndMovie.Controllers
{
    public class ActionController : Controller
    {
        private readonly List<Film> _actions;

        public ActionController() {

            _actions = [
 new(){Id=1, Name="Taşıyıcı 3",Description=" Transporter 3 - Taşıyıcı 3 | 2008\r\n\r\n Frank Martini, Marsilya'da, Ukrayna Çevre Koruma Ajansı Başkanı Leonid Vasilev'in kaçırılan kızı Valentina'yı Ukrayna'ya götürme görevini almıştır.\r\n\r\n Valentina'yı alıp Stuttgart ve Budapeşte üzerinden Karadeniz kıyısındaki Odessa'ya götürmekle yükümlüdür. Yolculuk sırasında Müfettiş Tarconi'nin yardımını alan Franki sayısız zorluklar beklemektedir.\r\n\r\n Bir yandan bu işi alması için baskı yapan insanlarla uğraşırken bir yandan da Vasilev tarafından gönderilen ajanlarla başa çıkmak zorundadır. Sürekli alaycı tavır takınan Valentina'nın işbirliği yapmaktan uzak havası da işini zorlaştırır.\r\n\r\n Hayatlarını tehdit eden birçok saldırıdan kıl payı kurtula kurtula kaçmaya çalışan Frank ile Valentina kısa sürede birbirlerine aşık olacaklardır.\r\n\r\nOyuncular\r\n\r\nFrank Martin - Jason Statham\r\nValentina Vasilev - Natalya Rudakova\r\nInspector Tarconi - François Berléand\r\nJohnson -  Robert Knepper\r\nLeonid Vasilev - Jeroen Krabbé\r\n\r\nYönetmen: Olivier Megaton\r\nFilm Türü: Aksiyon\r\nIMDB Puanı: 6.1/10", VideoUrl="https://www.youtube.com/embed/rbkZQitHPaU?si=tpKRD6uMcuZFoAst",genre=Genre.Action},
  new(){Id=2, Name="İntikam",Description="Avengement, hapse girmesine neden olan insanlardan intikam almaya çalışan bir adamın hikayesini konu ediyor. Hapishane zor koşullar altında yaşayan ve burada hayatta kalabilmek için mücadele etmek zorunda kalan bir suçlu, sonunda beklediği fırsatı ele geçirerek hapishaneden kaçmayı başarır. Cezaevinin kapısından dışarı adım atar atmaz yapmak istediği tek şey, kendisini suçlu haline getiren insanlardan intkam almak olur. Katil olmasına neden olan insanların peşine düşen adam, kaybolan hayatını geri kazanmak için büyük bir savaşın içine girer.", VideoUrl="https://www.youtube.com/embed/JMWs6h_NawI?si=01yv9oZBVJUHf4L9",genre=Genre.Action},
   new(){Id=3, Name="Büyük Dövüş",Description="IMDB en iyi 250 film listesinde 163, sırada bulunan Büyük Dövüş (Warrior) Tom Hardy filmi Türkçe dublaj olarak sizlerle! \r\n\r\nTrajik bir geçmişin kovaladığı eski bir denizci olan Tommy Riordan doğduğu kasaba olan Pittisburgh'a geri döner. Eski antrenörü ve iyileşmiş bir alkolik olan babasını, kendisini tarihteki en yüksek ödülü veren Dövüş Sanatları Turnuvası’na hazırlaması için seçer. Tommy ünvana giden şiddetli yolda parlarken, eski bir dövüş sanatları dövüşçüsü olan kardeşi Brendan, öğretmen maaşı yetmediği için amatör olarak ringlere geri döner. Yıllar geçmiş olmasına rağmen, suçlamalar ve geçmiş ihanetler, Brendan’ı acı bir şekilde ayrıldığı babası ve Tommy’den uzak tutmaktadır. Kazanma ihtimali düşük bir yarışmacı olarak, Brendan’ın beklenmedik yükselişi, Tommy rakip olmasına yol açtığında, iki kardeşte en şiddetli ve kazananın her şeyi aldığı bir yarışta mücadele ederken kendilerini ayıran güçlerle yüzleşmek zorunda kalacaklar.\r\nOrijinal Adı: Warrior \r\nIMDB: 8.2/10 \r\nTür: Aksiyon, Dram,\r\nYapım: 2011\r\nYönetmen: Gavin O'Connor ,\r\nOyuncular: Tom Hardy , Jennifer Morrison, Joel Edgerton, Jennifer Morrison, Nick Nolte", VideoUrl="https://www.youtube.com/embed/rbkZQitHPaU?si=tpKRD6uMcuZFoAst",genre=Genre.Action},
    new(){Id=4, Name="Kaos",Description=" Kaos (Chaos) Filminin Konusu:\r\n\r\nQuentin Correns (Jason Statham) Born köprüsünde olan bir kazada yapmaması gerektiği halde rehineyi vurduğu için teşkilat tarafından açığa alınmıştır. Olaydan bayağı bir süre sonra bir banka soygunu gerçekleştirilir. Bir kişi vurularak hayatını kaybetmiştir. Ve soygunun başkanı Lorenz (Wesley Snipes) Correns'i istemektedir. İstek yerine getirilir ve Correns'e bir de zeki bir yardımcı genç dedektif verilir (Ryan Philippe). Banka soygunu ucuz atlatılır fakat hiçbir şeyin çalınmadığı fark edilir. Kameralar elektrik kesintisinden dolayı çalışmadığı için hiçbir şeyi kaydetmediği için herkesin aklında bir soru kalır.\r\n\r\nTür: Aksiyon, Suç\r\nYönetmen: Tony Giglio\r\nSenaryo: Tony Giglio\r\nOyuncular: Jason Statham, Ryan Phillipe, Wesley Snipes\r\nSüre: 106 Dakika\r\nYapım Yılı: 2005", VideoUrl="https://www.youtube.com/embed/cf53YkQcJn8?si=cSKWH7iamz0Ruzz9",genre=Genre.Action}



                ];



        }


        public IActionResult Index()
        {
           ViewBag.Action=_actions; return View();
        }

        public IActionResult Details(int Id)
        {
            Film ızle = null;
            foreach (Film a in _actions)
            {
                if (a.Id == Id)
                {
                    ızle = a;
                    break;

                }
            }
            ViewBag.Details = ızle;
            return View();

        }
    }
}
