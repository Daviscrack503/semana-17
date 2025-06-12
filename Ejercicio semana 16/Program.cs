using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoologico zoologico = new Zoologico();


            Mamifero leon = new Mamifero("León", 5, " Felino");
            Ave loro = new Ave("Loro", 2, "Psittacidae");
            Reptil iguana = new Reptil("Iguana", 3, "Iguana iguana");


            zoologico.AgregarAnimal(leon);
            zoologico.AgregarAnimal(loro);
            zoologico.AgregarAnimal(iguana);

            zoologico.MostrarAnimales();
            zoologico.EjecutarComportamientos();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();






        }
    }
}
