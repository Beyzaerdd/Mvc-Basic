using FilmAndMovie.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmAndMovie.Controllers
{
    public class RomanticController : Controller
    {
        private readonly List<Film> _romantic;
        public RomanticController()
        {
            _romantic = [

                new(){Id=1,Name="Bir varmış bir yokmuş", Description="Anaokulu öğretmeni olan Nehir, bir gün tesadüfen bir şarkı dinler ve dinlediği şarkı genç kadını derinden etkiler. Nehir şarkıyı o kadar çok beğenir ki notaların ardından, şarkıyı yapan müzisyenin peşine düşmeye karar verir... Yolun sonundaysa şarkının sahibi olan Ozan'ı bulur. Ama Ozan hayatında yaşadığı derin bir travma yüzünden ve adeta çıkmaz bir sokak gibidir... Bir tarafın kararlılığı ile diğer tarafın bocalamaları arasında sıkışıp kalan bu ilginç aşk hikayesi, acaba mutlu sonlu bir masala bağlanabilecek midir...", genre=Genre.Romatic,VideoUrl="https://www.youtube.com/embed/UjCF7W7FZQE?si=v18-j2dqFP3YfctK"},
                new(){Id=2,Name="Ölümsüz Aşk", Description="Bir çağ değişirken doğmuş olan Adaline Bowman, geçirdiği bir kaza sonucu hiç yaşlanmamakla 'ödüllendirilir'. 29 yaşında yaşlanmamaya başlar ve yıllar boyunca insanlardan mümkün olduğunca uzak, izole bir hayat sürmek zorunda kalır. Bu süreçte dünyanın sıra dışı değişimine de tek başına tanık olur ve bunun zorluğunu tek başına atlatmayı başarır.", genre=Genre.Romatic,VideoUrl="https://www.youtube.com/embed/Z2ccVSkdknI?si=P3sxrxS3hwyfbZ4u"},
                new(){Id=3,Name="Benim için gör", Description="\r\nKör bir eski kayakçı olan Sophie kedi bakıcılığı yapmak için tenha bir malikanede bulunduğu sırada, üç hırsız evdeki gizli kasayı ele geçirmek için eve girerler. Sophie'nin tek savunması eski bir asker olan Kelly'dir. Kelly, Sophie'nin işgalcilere karşı kendini savunmasına ve hayatta kalmasına yardım eder.\r\n", genre=Genre.Romatic,VideoUrl="https://www.youtube.com/embed/IAjthQp6vNE?si=bWxzGdaIer-E4cZj"},
                new(){Id=4,Name="Aşk Tesadüfleri Sever", Description="Yıl 1977, Ankara’da bir Eylül sabahı… Hamile karısı Neriman’ı hastaneye yetiştirmeye çalışan Yılmaz Bey’in kullandığı araba, Ömer Bey’in arabasına çarpar. Bu çarpışma Ömer Bey’in arka koltukta oturan hamile karısı İnci’nin erken doğum yapmasına neden olur. İki bebek aynı gün dünyaya gelirler. İlk kez birbirlerini görür gözleri. Bu kaza Özgür ve Deniz’i bir araya getiren tesadüflerin başlangıcı olur. Bundan sonra yolları, çocukluk yılları ve ilk gençlik yılları boyunca Ankara’da bir kaç kez daha kesişir. Her kesişme onların hayatında büyük değişikliklere sebep olur. Birbirlerinin çocukluk aşkı olurlar, ya da ilk kalp kırıklığı… Ama onun da ötesinde, her temasları hayatlarının rotasını değiştirir. Sadece onların değil, ailelerinin de… Bazen felaketlere, bazen mucizelere neden olurlar birbirlerinin hayatlarında. Ancak hiçbir zaman bir arada olamazlar. Onları bir araya getiren şey her neyse, aralarına şeffaf bir duvar örmeyi de başarır her seferinde. Ta ki 25 sene sonra, İstanbul’da yolları kesişene kadar…", genre=Genre.Romatic,VideoUrl="https://www.youtube.com/embed/qJYljBrFNs0?si=E2MAEOuXmsa7FTHO"}



                ];




        }



        public IActionResult Index()
        {

            ViewBag.romantic= _romantic;
            return View();
        }

        public IActionResult Details(int Id)
        {
            Film film = null;
           foreach(Film f in _romantic)
            {
                if (f.Id == Id) { film = f; break; }

            }
           ViewBag.romantic= film;
            return View();
        }
    }
}
