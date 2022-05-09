/* Para concatenar le agragamos fuera de las comillas el signo dolar $ y entre llaves dentro 
 de las comillas los parametros. En este caso la suma de num1 + num2 */


class program
{
    static void Main(string[] args)    
    {

        sumaNumeros(7, 9);
        sumaNumeros(10, 12);
        multiplicaNumeros(11, 13);

    }

    static void sumaNumeros(int num1, int num2)    
    {
        Console.WriteLine($"La suma de los numeros {num1+num2}");  
    
    }

    static void multiplicaNumeros(int num1, int num2)
    {
        Console.WriteLine($"La multiplucacion de los numeros {num1 * num2}");

    }
}
