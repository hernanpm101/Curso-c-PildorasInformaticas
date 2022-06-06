/* Al pararnos en "return" con el mouse y hacemos click va a parecer un destornillador a la izquierda,
 al hacer click nos despliega "acciones rapidas" y podemmos cambiarlo mas eficiente*/

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine(Suma(7,5.3));
    }

    private static double Suma(int v1, double v2) => v1 + v2;
}

/* en el anterior ejemplo, el metodo "Suma" estaba de la siguiente manera:
 
   private static double Suma(int v1, double v2)
{
    return v1 + v2;
}

pero al hacer click sobre return, destornollador, acciones rapidas la cambiamos
y ahora al tener una sola linea de codigo lo sustituimos para mejor con el simbolo
"lambda" =>  

*/


