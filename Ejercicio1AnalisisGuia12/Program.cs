using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1AnalisisGuia12
{
class Program
{
struct ejemplo
{
public String Name;
public String Carrera;
public String Universidad;
public int Edad;
public void Registrar(string n, string c, int e, string ud)
{
Name = n;
Carrera = c;
Edad = e;
Universidad = ud;
}
}
static void Main(string[] args)
{
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Registro de estudiantes.";

int tan;

Console.WriteLine("Digite el número de estudiantes a registrar: ");
tan = int.Parse(Console.ReadLine());
ejemplo[] E = new ejemplo[tan];

Console.WriteLine();


for (int i = 0; i < tan; i++)
{
Console.Write("Ingrese nombre: ");
String n = Console.ReadLine();
Console.Write("Edad: ");
int e = int.Parse(Console.ReadLine());
Console.Write("Carrera: ");
String c = Console.ReadLine();
Console.Write("Universidad: ");
String ud = Console.ReadLine();
Console.WriteLine();

E[i].Registrar(n, c, e, ud);
}

Console.Clear();
Console.WriteLine("Información ingresada:");
Console.WriteLine("------------------------");

for (int i = 0; i < tan; i++)
{
Console.WriteLine("Nombre: " + E[i].Name);
Console.WriteLine("Edad: " + E[i].Edad);
Console.WriteLine("Carrera: " + E[i].Carrera);
Console.WriteLine("Universidad: " + E[i].Universidad);
Console.WriteLine("----------------------");
}

Console.ReadKey();
}
}
}

