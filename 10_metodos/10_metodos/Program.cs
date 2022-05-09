/* todo programa c# debe llevar un metodo Main. 
 que significa la palabra void? que este metodo nunca va a devolver nada.
dentro de los parentesis del Main vemos que tiene argumentos, son arrais, y en este caso en particular va a 
recibir un string.
Un metodo no se ejecuta hasta que es llamado
la palabra static no se debe utilizar ningun objeto en la llamada 
con cw + tap imprime console.WriteLine
Este programa se aplica de arriba a abajo por lo que al ejecutarlo primero ingresa al Main, va a buscar
el metodo  mensajeEnPantalla(); y lo va a ejecutar
se va a ejecutar primero mensaEnPantalla y luego la siguiente instruccion dentro del Main
en REFERENCIA se ve chiquito es la cantidad de metodos dentro del main*/


// apliacion con 2 metodos, el punto de entra siempre es primero el metodo Main, despues los otros metodos

class program
{
    static void Main(string[] args)    //metodo Mian
    {
        mensajeEnPantalla();     //llamada a metodo

        Console.WriteLine("Menseje desde el Main");   

        mensajeEnPantalla();

        mensajeEnPantalla();

    }

    static void mensajeEnPantalla()    //un metodo del tipo void
    {
        Console.WriteLine("Mensaje desde el metodo mensajeEnPantalla");  // una vez que encuetra el metodo ejecuta la linea que hay en su interior
    }
}




