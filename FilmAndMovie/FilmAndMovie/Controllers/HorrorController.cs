using FilmAndMovie.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmAndMovie.Controllers
{
    public class HorrorController : Controller
    {
        private readonly List<Film> _horror;

        public HorrorController()
        {

            _horror = [
                new(){Id=1,Name="Lanetli Ev",Description=" 7 aylık hamile olan Jennifer Branagan yıllar sonra Kansas'a geri döner. Doğduğu yere dönmesinin sebebi ise yaşadığı beklenmeyen bir psikolojik çöküştür. Anne olmanın getirdiği korku, annesi Meredith'in baskıcı tavrı, kocası Luke'la yaşadığı gergin ilişki ve taşınma stresi Jennifer'ı bir hayli zorlayip gerilim dolu anlara sebep olacaktır.",genre=Genre.Horror,VideoUrl="https://www.youtube.com/embed/kojWYNfujfc?si=DHAb86_dXzGah7zC"},
                new(){Id=2,Name="Tesis",Description="Çocuklarını kaybetmenin acısı ile baş etmeye çalışan bir çiftin hayatına odaklanıyor.\r\n\r\nMutlu bir yaşam süren Igor ve Polina'nın hayatları, çocukları Vanya'nın kaybolmasıyla altüst olur. Küçük çocuğu bulmak için ne kadar uğraşılsa da bir sonuca ulaşılamaz. Aradan geçen dört yılın ardından çift, hayatlarına yeniden yön verebilmek için bir erkek çocuk evlat edinmeye karar verir. Vanya yerine koydukları çocuk, gün geçtikçe oğullarına benzeye başlar. Başlarda bu durum sorun yaratmasa da yaşanan olaylar tuhaf bir hal alır. Çift, bir süre sonra evlat edindikleri çocuğun insan dışı, yabani bir varlık olduğunu keşfeder.",genre=Genre.Horror,VideoUrl="https://www.youtube.com/embed/CBjdxEGeJyI?si=aCh8HraC8XgN6IYl"},
                new(){Id=3,Name="Yabani",Description="Çocuklarını kaybetmenin acısı ile baş etmeye çalışan bir çiftin hayatına odaklanıyor.\r\n\r\nMutlu bir yaşam süren Igor ve Polina'nın hayatları, çocukları Vanya'nın kaybolmasıyla altüst olur. Küçük çocuğu bulmak için ne kadar uğraşılsa da bir sonuca ulaşılamaz. Aradan geçen dört yılın ardından çift, hayatlarına yeniden yön verebilmek için bir erkek çocuk evlat edinmeye karar verir. Vanya yerine koydukları çocuk, gün geçtikçe oğullarına benzeye başlar. Başlarda bu durum sorun yaratmasa da yaşanan olaylar tuhaf bir hal alır. Çift, bir süre sonra evlat edindikleri çocuğun insan dışı, yabani bir varlık olduğunu keşfeder.",genre=Genre.Horror,VideoUrl="https://www.youtube.com/embed/wRxV8-gEltI?si=alhjcQGBArBMsCko"},
                new(){Id=4,Name="İntikam",Description=" Eski bir polis memuru, iki kızı ile birlikte New York’taki büyük bir apartmana taşınır. Adam apartmanın bakımından sorumludur. Fakat bilmediği büyük bir şey vardır. Apartmanda yaşayan insanlar gizemli bir şekilde ortadan kaybolmaktadır.",genre=Genre.Horror,VideoUrl="https://www.youtube.com/embed/mWBCGAzHEiM?si=LtoVKyzoZOyNPe30"}

                ];
        }




        public IActionResult Index()
        {
            ViewBag.horror = _horror;
            return View();
        }

        public IActionResult Details(int Id)
        {
            Film film = null;
            foreach (Film f in _horror)
            {
                if (f.Id == Id) 
                { film = f; break; }
            }
            ViewBag.Details = film;
            return View();
        }
        

    }
}