// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//comenzando la practica de arrays

int[] edades = new int[4] { 4, 3, 8, 7};
string[] personas = new string[3] { "Santino", "Fabio", "maximiliano" };

for (int i = 0; i < personas.Length; i++)
{
    Console.WriteLine(personas[i]);
}
int[] pares = new int[4];
int[] impares = new int[4];

for (int i = 0;i < edades.Length; i++)
{
   
    if (edades[i] % 2 == 0)
    {
        pares[i] = edades[i];
    }
    else
    {
        impares[i] = edades[i];
    }
}
Console.WriteLine("Las edades impares son: ");

foreach (int i in impares) {  Console.WriteLine(i); }

Console.WriteLine("las edades pares son: ");

foreach (int j in pares) { Console.WriteLine(j); }
