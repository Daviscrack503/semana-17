using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana17
{
    public class Zoologico
    {
        private List<Animal> animales = new List<Animal>();

        public void AgregarAnimal(Animal animal)
        {
            animales.Add(animal);
            Console.WriteLine($"{animal.Nombre} fue agregado al zoológico.");
        }

        public void MostrarAnimales()
        {
            Console.WriteLine("\n--- Lista de animales y sus sonidos ---");
            foreach (var animal in animales)
            {
                Console.WriteLine($"Nombre: {animal.Nombre}, Especie: {animal.Especie}, Edad: {animal.Edad}");
                animal.EmitirSonido();
            }
        }

        public void EjecutarComportamientos()
        {
            Console.WriteLine("\n--- Comportamientos específicos de los animales ---");
            foreach (var animal in animales)
            {
                if (animal is Mamifero mamifero)
                    mamifero.Amamantar();
                else if (animal is Ave ave)
                    ave.Volar();
                else if (animal is Reptil reptil)
                    reptil.TomarSol();
            }
        }
    }
}
