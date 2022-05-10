// METODOS son un grupo de instrucciones de lineas de codigo de sentaencias que realizan una tarea comun y que se agrupan
// dando un nombre identificativo. Tiene un nombre identificativo como las variables y constantes. el METODO se aplica en un momento
// determinado en el momento de flujo de ejecucion del program, cuando este es LLAMADO. 
// cosas re-importante:
//                    - no se ejecutara hasta su llamada
//                    - todos los metodos iran dentro de una clase
//                    - se debe especificar el tipo de DATO devuelto y los parametros()
//                    - No hay distincion entre metodos y funciones. En C# ambos terminos son lo mismo.

// SINTAXIS DE UN METODO

//  Tipo de dato_nombreMetodo(parametros){    //los paremetros son opcionales, ya que en ocaciones no los hay.
//       cuerpo del metodo
//   }

// ejemplo sin parametros:

//          int sumaNumeros(){
//                  int num1=7;
//                  int num2=9;
//                  int resultado=num1+num2;
//                  return resultado;               //return significa "devuelveme", en este caso seria 7+9
//                  }

// ejemplo con parametros: (donde por lo general el usuario intruduce datos por consola )

//          int sumaNumeros(){
//                  int num1=7;
//                  int num2=9;
//                  int resultado=num1+num2;
//                  return resultado;           
//                  }

//           int sumaNumeros(int num1, int num2) {      //en los parametros el usuario introducira los valores
//                      int resultado=num1+num2;
//                      return resultado;
//                      }


//   Cuando el metodo no va a devolver ningun valor se utiliza la palabra reservada VOID. aqui el valor lo imprime,
//    pero no lo devuelve ya que no utlizamos return. VOID JAMAS LLEVARA LA PALABRA RETURN.

//    void sumaNumeros(){
//                  int num1=7;
//                  int num2=9;
//                  int resultado=num1+num2;
//                  Console.WriteLine(resultado);           
//                  }

Console.WriteLine("Hello, World!");







