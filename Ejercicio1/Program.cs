// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

Libro primero = new Libro("la casa embrujada","David Cohan",4,2);
primero.Mostrar();
primero.Prestar("la casa embrujada");
primero.Mostrar();


public class Libro
{
    private string titulo;
    private string autor;
    private int copias;
    private int prestado;

    public Libro() { }

    public Libro(string titulo, string autor, int copias, int prestado)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.copias = copias;
        this.prestado = prestado;

    }

    public bool Prestar(string titulo)
    {
        if (copias > 0)
        {
            copias -= 1;
            prestado += 1;
            return true;
        }
        else { return false; }

    }

    public bool Devolver(string titulo)
    {
        if (prestado > 0)
        {
           prestado -= 1;
            return true ;
        } else { return false; }
    }
    public void Mostrar()
    {
        Console.WriteLine($"Los datos del libro son: {titulo} de {autor}");
        Console.WriteLine($"Numero de copias disponibles {copias}");
        Console.WriteLine($"Numero de copias prestadas {prestado}");

    }
}

