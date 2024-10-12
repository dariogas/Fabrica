// See https://aka.ms/new-console-template for more information

using Fabrica;

Profesor profe1 = new("Rodrigo", "Palacios", 32502303, new DateOnly(1986, 2, 15), 4);
Profesor profe2 = new("Matias", "Casañas", 28789654, new DateOnly(1983, 11, 27), 8);

Curso curso1 = new("matematicas", profe1, 30);

int cantidadCursos=0;

while (cantidadCursos < 6){
    cantidadCursos =+ 1;
    Console.WriteLine("Ingrese el nombre del curso:");
    string nombre = Console.ReadLine();
    
    if(String.IsNullOrEmpty(nombre))
    {
        break;

    }else {
        for(int i = 0; i < 
        Console.WriteLine("");
    }

}

