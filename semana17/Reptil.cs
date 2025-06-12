using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace semana17
{
    public class Reptil : Animal
    {

        public Reptil(string nombre, int edad, string especie)
       : base(nombre, edad, especie) { }

        public override void EmitirSonido()
        {
            Console.WriteLine($"{Nombre} (reptil) dice: ¡Ssshhh!");
        }

        public void TomarSol()
        {
            Console.WriteLine($"{Nombre} está tomando el sol.");
        }


    }
}
