using Microsoft.AspNetCore.Mvc;

namespace TP04.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Dictionary = OrtWorld.Paquetes;
        return View();
    }
    public IActionResult Paquetes()
    {
        ViewBag.hotel = OrtWorld.ListaHoteles;
        ViewBag.aereo = OrtWorld.ListaAereos;
        ViewBag.excursion = OrtWorld.ListaExcursiones;
        return View();
    }
    public IActionResult SelectPaquete(){
         ViewBag.hotel = new List<string> {"Hotel 1.jpg", "Hotel 2.jpg", "Hotel 3.jpg", "Hotel 4.jpg", "Hotel 5.jpg", "Hotel 6.jpg", "Hotel 7.jpg", "Hotel 8.jpg", "Hotel 9.jpg", "Hotel 10.jpg"};
        ViewBag.aereo = new List<string> {"Aereo_1.jpg", "Aereo_2_(chubut).jfif", "Aereo_3.jpg", "Aereo_4_(fast travel).jpg", "Aereo_5.jfif", "Aereo_6.jpg", "Aereo_7.jpg", "Aereo_8.jfif", "Aereo_9.jfif", "Aereo_10.jpg"};
        ViewBag.excursion = new List<string> {"Excursion 1.jfif", "Excursion 2.jfif", "Excursion 3.jpg", "Excursion 4.jpg", "Excursion 5.jfif", "Excursion 6.jpg", "Excursion 7.jpg", "Excursion 8.jfif", "Excursion 9.jfif", "Excursion 10.jpg"};
            return View();
    }
    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion)
    { 
         ViewBag.hotel = new List<string> {"Hotel 1.jpg", "Hotel 2.jpg", "Hotel 3.jpg", "Hotel 4.jpg", "Hotel 5.jpg", "Hotel 6.jpg", "Hotel 7.jpg", "Hotel 8.jpg", "Hotel 9.jpg", "Hotel 10.jpg"};
        ViewBag.aereo = new List<string> {"Aereo_1.jpg", "Aereo_2_(chubut).jfif", "Aereo_3.jpg", "Aereo_4_(fast travel).jpg", "Aereo_5.jfif", "Aereo_6.jpg", "Aereo_7.jpg", "Aereo_8.jfif", "Aereo_9.jfif", "Aereo_10.jpg"};
        ViewBag.excursion = new List<string> {"Excursion 1.jfif", "Excursion 2.jfif", "Excursion 3.jpg", "Excursion 4.jpg", "Excursion 5.jfif", "Excursion 6.jpg", "Excursion 7.jpg", "Excursion 8.jfif", "Excursion 9.jfif", "Excursion 10.jpg"};
            return View();
    }
}
