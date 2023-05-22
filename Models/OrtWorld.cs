using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


 class OrtWorld{
    public static List<string> ListaDestinos {get; private set;} = new List<string> {"Misiones", "Tucumán", "Mar del Plata", "Bariloche", "Jujuy", "Chubut", "La Pampa", "Tierra del Fuego", "Corrientes", "Salta"};
    public static List<string> ListaHoteles {get; private set;} = new List<string> {"Hotel 1.jpg", "Hotel 2.jpg", "Hotel 3.jpg", "Hotel 4.jpg", "Hotel 5.jpg", "Hotel 6.jpg", "Hotel 7.jpg", "Hotel 8.jpg", "Hotel 9.jpg", "Hotel 10.jpg"};
    public static List<string> ListaAereos {get; private set;} = new List<string> {"Aereo_1.jpg", "Aereo_2_(chubut).jfif", "Aereo_3.jpg", "Aereo_4_(fast travel).jpg", "Aereo_5.jfif", "Aereo_6.jpg", "Aereo_7.jpg", "Aereo_8.jfif", "Aereo_9.jfif", "Aereo_10.jpg"};
    public static List<string> ListaExcursiones {get; private set;} = new List<string> {"Excursion 1.jfif", "Excursion 2.jfif", "Excursion 3.jpg", "Excursion 4.jpg", "Excursion 5.jfif", "Excursion 6.jpg", "Excursion 7.jpg", "Excursion 8.jfif", "Excursion 9.jfif", "Excursion 10.jpg"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;} = new Dictionary<string, Paquete>();
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
        bool devolver = false;
        foreach (string destino in ListaDestinos){

            ListaDestinos.Add(destinoSeleccionado);
            Paquetes.Add(destinoSeleccionado, paquete);
            devolver = true;
            
          


    }
    return devolver;
    }
    }
