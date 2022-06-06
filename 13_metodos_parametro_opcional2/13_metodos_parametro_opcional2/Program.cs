class Program
{

    static void Main(string[] args)
    {

        int valor1 = 7;

        double valor2 = 5.2;

        double valor3 = 8.3;

        Console.WriteLine(Suma(valor1,valor2,valor3));
    
    }
                                                        
    static double Suma(int num1, double num2, double num3=0)  // --> double num3=0 parametro opcional
    {
        return num1 + num2 + num3;
    }

    static double Suma(int num1, double num2) // ---> sobre carga de metado Suma (porque ya hay un suma anterior)
    {
        return num1 + num2;
    }
}

// el parametro opcional siempre va al ultimo. 

