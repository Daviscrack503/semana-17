namespace semana17
{
    public class Programs
    {


        static void Main(string[] args)
        {
            Zoologico zoologico = new Zoologico();

            
            Mamifero leon = new Mamifero("León", 5, "Panthera leo");
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
