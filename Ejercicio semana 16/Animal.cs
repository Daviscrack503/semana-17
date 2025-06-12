using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_16
{
    public class Animal
    {

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Especie { get; set; }

        public Animal(string nombre, int edad, string especie)
        {
            Nombre = nombre;
            Edad = edad;
            Especie = especie;
        }

        public virtual void EmitirSonido()
        {
            Console.WriteLine($"{Nombre} emite un sonido.");
        }




    }
}
