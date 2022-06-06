/* IF ANIDADO 
 Etructura condicional "else"

NUNCA PUEDE HABER UN "else" SIN SU CORRESPONDIENTE "if". cada else debe tener si o si un if
SI PUEDE HABER UN "if" sin un "else"
 
 */



namespace CondicionalAnidado
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Vamos a evaluar si podes conducir");

            Console.WriteLine("Intrduce tu edad, por favor");

            int edad = int.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("No puedes conducir vehiculos");

            else
            {
                Console.WriteLine("tines carnet?");

                string carnet = Console.ReadLine();

                int compara = string.Compare(carnet, "si", true);

                if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");

                else Console.WriteLine("Lo siento no puedes conducir");
            }
            
            
        }
    }
}
