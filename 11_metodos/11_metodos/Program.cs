/*  Este metodo ya sin el void lo remplazamos por return 
 lo que hace es devolver la suma por medio del return, no importa si por consola lo imprime
trabajamos por ahora con datos primitivos int, double, float, etc */




class program
{

    static void Main(string[] args)
    {

        Console.WriteLine(sumaNumeros(7, 9));

    }

    static int sumaNumeros(int num1, int num2)    // le dicmos al metodo que es un dato int
    {
        return num1 + num2;     // con el return se sale de la ejecucion de un metodo y devuelve
                                 // el flujo de ejecucion a la llamada
    }










}
