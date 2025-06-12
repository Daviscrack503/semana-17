using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace semana17
{
    public class Ave : Animal
    {
        public Ave(string nombre, int edad, string especie)
        : base(nombre, edad, especie) { }

        public override void EmitirSonido()
        {
            Console.WriteLine($"{Nombre} (ave) dice: ¡Pío pío!");
        }

        public void Volar()
        {
            Console.WriteLine($"{Nombre} está volando alto.");
        }




    }
}
