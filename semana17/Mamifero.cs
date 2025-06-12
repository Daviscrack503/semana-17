using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana17
{
   public class Mamifero : Animal
    {
        public Mamifero(string nombre, int edad, string especie)
        : base(nombre, edad, especie) { }

        public override void EmitirSonido()
        {
            Console.WriteLine($"{Nombre} (mamífero) dice: ¡Gruñido!");
        }

        public void Amamantar()
        {
            Console.WriteLine($"{Nombre} está dormido XD");
        }




    }
}
