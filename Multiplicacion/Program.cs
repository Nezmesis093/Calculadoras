//Calculadora de Multiplicacion de dos valores.

// Declaracion (inicializacion) de Variables:

// Ejemplo practico [ tipo de dato(numerico, cadena, boolean) ] + [nombre de la variable]

double ValorA = 0.0;
double ValorB = 0.0;
double Total = 0.0;

// Obtenermos los datos a Sumar del ValorA y ValorB desde la consola:

Console.WriteLine("Escribe número o el valor a Multiplicar: "); //Mostrar a Usuario instruccion a realizar
ValorA = Convert.ToDouble(Console.ReadLine()); //Realiza la asignacion o nuevo valor a la Variable ValorA con la instruccion ReadLine para despues convertir el valor obtenido a un Valor Double con el comando Convert.To

Console.WriteLine("Escribe número o el valor por el cual Multiplicar: ");
ValorB = Convert.ToDouble(Console.ReadLine());

// Realizamos el proceso o la intruccion a realizar con los datos obtenidos:

Total = ValorA * ValorB;

// Mostrar el Resultado en consola:

Console.WriteLine("El Resultado Total de la MULTIPLICACION es de: " + Total); // Mostramos a Usuario el texto de resultado e incluimos en Valor Total a lo mostrado en consola
Console.ReadKey();