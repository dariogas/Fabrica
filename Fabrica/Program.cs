// See https://aka.ms/new-console-template for more information
Console.WriteLine("Primer saludo");
Console.WriteLine("Hoy realizando un par de pruebas");

//Ejemplo de calculadora

double num1 = 4;
double num2 = 5;
string operacion = "multiplicacion";
double resultado;



switch (operacion.ToLower())
{
	case "suma":
		resultado = num1 + num2;
        break;
	case "resta":
		resultado = num1 - num2;

        break;
	case "multiplicacion":
		resultado = num1 * num2;

        break;
	case "division":
		resultado = num1 / num2;
        Console.WriteLine($"El resultado de la operacion es: {resultado}");

        break;
	default:
		resultado=0;
		Console.WriteLine("Elija una opcion correcta");
		break;
}
Console.WriteLine($"El resultado de la operacion es: {resultado}");

