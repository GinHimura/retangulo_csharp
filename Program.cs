// See https://aka.ms/new-console-template for more information
using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

double baSe, altura, area, perimetro, diagonal;

Console.Write("Base do retangulo: ");
baSe = double.Parse(Console.ReadLine(),CI);
Console.Write("Altura do retangulo: ");
altura = double.Parse(Console.ReadLine(),CI);

area = baSe * altura;
perimetro = 2 * (baSe + altura);
diagonal = Math.Sqrt(Math.Pow(baSe, 2.0) + Math.Pow(altura, 2.0));

Console.WriteLine("AREA = " + area.ToString("F4", CI));
Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));
Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));