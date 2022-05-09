// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions 
// referencias de conversiones numericas implicicas entre tipos primitivas. 


Console.WriteLine("Hello, World!");


Console.WriteLine();




int edadPersona1;
int edadPersona2;
int edadPersona3;
int edadPersona4;

edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;


Console.WriteLine(edadPersona1);
Console.WriteLine();


var edadPersona5 = 100;   // utilizando la variable var no se puede reasiganar denuevo otro valor.

Console.WriteLine(edadPersona5);



// conversion explicita / cating, por ejemplo:

double temperatura = 34.5;

int temperaturaMadrid;

temperaturaMadrid = (int)temperatura;    //casting, lo que hace es descartar la parte decimal .5 

Console.WriteLine();  // espacio en la linea de codigo.

Console.WriteLine(temperaturaMadrid);



// conversion implicita

int habitantesCiudad = 10000000;

long habitantesCiudad2022 = habitantesCiudad;   //aqui es distinto porque ambos valores son el mimo tipo de dato

Console.WriteLine();

Console.WriteLine(habitantesCiudad2022);


// otro ejemplo de coversion implicita


float pesoMaterial = 5.78F;    // en los tipo de dato float, al final de l dato le agrego la F mayuscula

double pesoMaterialPrec = pesoMaterial;

Console.WriteLine(pesoMaterialPrec);








