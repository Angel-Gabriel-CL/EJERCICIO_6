//--------------------------------------------------------------------      Encabezado del programa
using System.ComponentModel.Design;

Console.WriteLine("EJERCICIO_6");                                           //Numero de la practica
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");           //Nombre del ejercicio
Console.WriteLine();                  //Instruccion para dejar un espacio en blanco en la consola
//Entradas, en esta parte pide los datosy el ReadLine es para mostrar y guardar el texto
string continuar = "si";
while (continuar == "si")
{
    Console.WriteLine("ingrese el nombre del estudiante: ");
    string nombre = Console.ReadLine() ?? "sin mobre";
double suma = 0;
for (int numero = 1; numero <= 5; numero++)
{ 
    Console.Write($"ingrese la calificación{numero}:");
    double calificación = Convert.ToDouble(Console.ReadLine());
    suma = suma + calificación;
}
//--------------------------------------------------------------------      Operaciones
double promedio = suma / 3.0;
Console.WriteLine("nombre del estudiante: ");
//--------------------------------------------------------------------      Salidas, el sigo de $" es para unir los caracteres, conactenar(texto+variale double), el F2 es para indicar las cantidad de decimales a indicar o dar en el programa
Console.WriteLine();
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}");
Console.WriteLine();

if (promedio >= 70)
{
    Console.WriteLine("Felicidades Alumno aprobado");
}
else
{
    Console.WriteLine("Alumno reprobado, sigue intentando");
}
Console.WriteLine();

if (promedio >= 90 && promedio < 100)
{
    Console.WriteLine("Excelente");
}
else if (promedio >= 80 && promedio < 90)
{
    Console.WriteLine("Alumno bueno");
}
else if (promedio >= 70 && promedio < 80)
{
    Console.WriteLine("Alumno regular");
}
else if (promedio >= 60 && promedio < 70)
{
    Console.WriteLine("Requiere apoyo");
}
if (promedio >= 10 && promedio < 60)
{
    Console.WriteLine("Alumno eficiente");
}
if (promedio >= 0 && promedio < 10)
{
    Console.WriteLine("Baja definitiva");
}
Console.WriteLine("¿Desea registrar otro estudiante?(si/no): ");
continuar = (Console.ReadLine() ?? "no").Trim().ToLower();
}