// CONDICIONAL "O" --> ||  (operador logico "o")




namespace CondicionalO
{
    class Program
    {
        static void Main(string[] args)

            // en el siguiente programa exjimos aprobar los 3 parciales para no ir a Dic o Mar

        {
            //Console.WriteLine("Intruduce el primer parcial");

            //int parcial1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Intruduce el segundo parcial");

            //int parcial2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Intruduce el tercer parcial");

            //int parcial3 = int.Parse(Console.ReadLine());

            //if (parcial1>=5 && parcial2>=5 && parcial3>=5)
            //{
            //    Console.WriteLine("La nota media es " + (parcial1+parcial2+parcial3)/3);
            //}
            //else
            //{
            //    Console.WriteLine("Vuelve en diciembre o marzo");
            //}



            // Ahora vamos a usar || que significa "o" lo cual pasa a promedio sin por lo menos tiene 1 aprobado


            Console.WriteLine("Intruduce el primer parcial");

            float parcial1 = int.Parse(Console.ReadLine());        // OJO DE "int" PASAMOS A "float"

            Console.WriteLine("Intruduce el segundo parcial");

            float parcial2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Intruduce el tercer parcial");

            float parcial3 = int.Parse(Console.ReadLine());

            if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
            {
                Console.WriteLine("La nota media es " + (parcial1 + parcial2 + parcial3) / 3);
            }
            else
            {
                Console.WriteLine("Vuelve en diciembre o marzo");
            }



        }
    }
}