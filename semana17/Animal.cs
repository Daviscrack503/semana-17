using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana17
{
    public class Animal(string nombre, int edad, string especie)
    {

        public string Nombre { get; set; } = nombre;
        public int Edad { get; set; } = edad;
        public string Especie { get; set; } = especie;

        
        public virtual void EmitirSonido()
        {
            Console.WriteLine($"{Nombre} emite un sonido.");
        }




    }
}
