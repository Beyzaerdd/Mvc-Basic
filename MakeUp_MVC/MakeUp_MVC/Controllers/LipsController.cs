using MakeUp_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeUp_MVC.Controllers
{
    public class LipsController : Controller
    {
        private readonly List<Lips> _lips;

        public LipsController() {

            _lips = [
                new(){Id=1, Name="Ruj",Description="Ruj, dudaklara renk ve hacim kazandırarak yüz makyajını tamamlayan önemli bir üründür. Farklı tonlarda ve dokularda sunulabilen rujlar, her makyaj stiline uyacak şekilde çeşitlenir. Mat, parlak, saten veya likit formda rujlar, dudaklara yumuşak bir dokunuşla renk verir. Özellikle dudakları vurgulamak isteyenler için, ruj doğru seçildiğinde hem doğal hem de cesur bir görünüm yaratabilir. Ruj, makyajın merkezine yerleşebilir ve tüm yüz hatlarını daha belirgin hale getirebilir.\r\n\r\n<br>Kullanım İpuçları:<br>\r\n\r\nMat rujlar, dudaklarda uzun süre kalıcıdır ve daha şık bir görünüm sağlar.\r\nParlak rujlar ise dudaklara dolgunluk katarken daha ışıltılı bir görünüm sunar.\r\nDudaklarınızın şekline uygun olarak, dudak kalemi kullanarak daha keskin hatlar oluşturabilirsiniz.\r\nGündelik kullanım için doğal tonlar tercih edilebilirken, özel günlerde cesur kırmızı veya bordo tonları kullanılabilir.",ImageUrl="img-6.png"},
                  new(){Id=2, Name="Ruj",Description="Ruj, dudaklara renk ve hacim kazandırarak yüz makyajını tamamlayan önemli bir üründür. Farklı tonlarda ve dokularda sunulabilen rujlar, her makyaj stiline uyacak şekilde çeşitlenir. Mat, parlak, saten veya likit formda rujlar, dudaklara yumuşak bir dokunuşla renk verir. Özellikle dudakları vurgulamak isteyenler için, ruj doğru seçildiğinde hem doğal hem de cesur bir görünüm yaratabilir. Ruj, makyajın merkezine yerleşebilir ve tüm yüz hatlarını daha belirgin hale getirebilir.\r\n\r\n<br>Kullanım İpuçları:<br>\r\n\r\nMat rujlar, dudaklarda uzun süre kalıcıdır ve daha şık bir görünüm sağlar.\r\nParlak rujlar ise dudaklara dolgunluk katarken daha ışıltılı bir görünüm sunar.\r\nDudaklarınızın şekline uygun olarak, dudak kalemi kullanarak daha keskin hatlar oluşturabilirsiniz.\r\nGündelik kullanım için doğal tonlar tercih edilebilirken, özel günlerde cesur kırmızı veya bordo tonları kullanılabilir.",ImageUrl="img-11.png"},
                                new(){Id=3, Name="Ruj",Description="Ruj, dudaklara renk ve hacim kazandırarak yüz makyajını tamamlayan önemli bir üründür. Farklı tonlarda ve dokularda sunulabilen rujlar, her makyaj stiline uyacak şekilde çeşitlenir. Mat, parlak, saten veya likit formda rujlar, dudaklara yumuşak bir dokunuşla renk verir. Özellikle dudakları vurgulamak isteyenler için, ruj doğru seçildiğinde hem doğal hem de cesur bir görünüm yaratabilir. Ruj, makyajın merkezine yerleşebilir ve tüm yüz hatlarını daha belirgin hale getirebilir.\r\n\r\n<br>Kullanım İpuçları:<br>\r\n\r\nMat rujlar, dudaklarda uzun süre kalıcıdır ve daha şık bir görünüm sağlar.\r\nParlak rujlar ise dudaklara dolgunluk katarken daha ışıltılı bir görünüm sunar.\r\nDudaklarınızın şekline uygun olarak, dudak kalemi kullanarak daha keskin hatlar oluşturabilirsiniz.\r\nGündelik kullanım için doğal tonlar tercih edilebilirken, özel günlerde cesur kırmızı veya bordo tonları kullanılabilir.",ImageUrl="r-1.png"},
                                    new(){Id=4, Name="Ruj",Description="Ruj, dudaklara renk ve hacim kazandırarak yüz makyajını tamamlayan önemli bir üründür. Farklı tonlarda ve dokularda sunulabilen rujlar, her makyaj stiline uyacak şekilde çeşitlenir. Mat, parlak, saten veya likit formda rujlar, dudaklara yumuşak bir dokunuşla renk verir. Özellikle dudakları vurgulamak isteyenler için, ruj doğru seçildiğinde hem doğal hem de cesur bir görünüm yaratabilir. Ruj, makyajın merkezine yerleşebilir ve tüm yüz hatlarını daha belirgin hale getirebilir.\r\n\r\n<br>Kullanım İpuçları:<br>\r\n\r\nMat rujlar, dudaklarda uzun süre kalıcıdır ve daha şık bir görünüm sağlar.\r\nParlak rujlar ise dudaklara dolgunluk katarken daha ışıltılı bir görünüm sunar.\r\nDudaklarınızın şekline uygun olarak, dudak kalemi kullanarak daha keskin hatlar oluşturabilirsiniz.\r\nGündelik kullanım için doğal tonlar tercih edilebilirken, özel günlerde cesur kırmızı veya bordo tonları kullanılabilir.",ImageUrl="r-3.jpg"},
                                      new(){Id=5, Name="Ruj",Description="Ruj, dudaklara renk ve hacim kazandırarak yüz makyajını tamamlayan önemli bir üründür. Farklı tonlarda ve dokularda sunulabilen rujlar, her makyaj stiline uyacak şekilde çeşitlenir. Mat, parlak, saten veya likit formda rujlar, dudaklara yumuşak bir dokunuşla renk verir. Özellikle dudakları vurgulamak isteyenler için, ruj doğru seçildiğinde hem doğal hem de cesur bir görünüm yaratabilir. Ruj, makyajın merkezine yerleşebilir ve tüm yüz hatlarını daha belirgin hale getirebilir.\r\n\r\n<br>Kullanım İpuçları:<br>\r\n\r\nMat rujlar, dudaklarda uzun süre kalıcıdır ve daha şık bir görünüm sağlar.\r\nParlak rujlar ise dudaklara dolgunluk katarken daha ışıltılı bir görünüm sunar.\r\nDudaklarınızın şekline uygun olarak, dudak kalemi kullanarak daha keskin hatlar oluşturabilirsiniz.\r\nGündelik kullanım için doğal tonlar tercih edilebilirken, özel günlerde cesur kırmızı veya bordo tonları kullanılabilir.",ImageUrl="r-4.png"},

                ];
        }









        public IActionResult Index()
        {
         ViewBag.Lips = _lips;
            return View();
        }

        public IActionResult Details(int id)
        {
            Lips lip = null;
            foreach (Lips l in _lips)
            {

                if (l.Id == id)
                {
                    lip = l;
                    break;


                }
            }
                ViewBag.Lips = lip;
                return View();

            }
            
        




    }
}
