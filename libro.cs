
namespace Ejemplo;

class Mascota
{
    public string Nombre { get; set; }
    public char Sexo { get; set; }
    public string Dueno { get; set; }

    public void MostrarDatos()
    {
        Console.WriteLine("\n--- DATOS DE LA MASCOTA ---");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Sexo: {Sexo}");
        Console.WriteLine($"Dueño: {Dueno}");
    }
}

class Gato : Mascota
{
    public string PatronPelo { get; set; }
    public int TendenciaPerderPelo { get; set; }

    public void DatosGato(string nombre, char sexo, string dueno)
    {
        this.Nombre = nombre;
        this.Sexo = sexo;
        this.Dueno = dueno;
    }

    public void MostrarGato()
    {
        MostrarDatos();
        Console.WriteLine($"Patrón de pelo: {PatronPelo}");
        Console.WriteLine($"Tendencia a perder pelo: {TendenciaPerderPelo}/10");
    }
}

class Perro : Mascota
{

    public double AlturaALaCruz { get; set; }

    public void DatosPerro(string nombre, char sexo, string dueno)
    {
        this.Nombre = nombre;
        this.Sexo = sexo;
        this.Dueno = dueno;
    }

    public void MostrarPerro()
    {
        MostrarDatos();

        Console.WriteLine($"Altura a la cruz: {AlturaALaCruz} cm");
    }
}

internal class Program
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("     VETERINARIA GATOS Y PERROS");
        Console.WriteLine("================================");

        Console.WriteLine("\n¿Qué animal deseas registrar?");
        Console.WriteLine("1. Gato");
        Console.WriteLine("2. Perro");

        Console.Write("\nSelecciona una opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion == 1)
        {
            Gato objGato = new Gato();

            Console.Write("\nNombre del gato: ");
            objGato.Nombre = Console.ReadLine();

            Console.Write("Sexo (M/H): ");
            objGato.Sexo = Convert.ToChar(Console.ReadLine());

            Console.Write("Nombre del dueño: ");
            objGato.Dueno = Console.ReadLine();

            Console.Write("Patrón de pelo: ");
            objGato.PatronPelo = Console.ReadLine();

            Console.Write("Tendencia a perder pelo (1-10): ");
            objGato.TendenciaPerderPelo =
                Convert.ToInt32(Console.ReadLine());

            objGato.MostrarGato();
        }
        else if (opcion == 2)
        {
            Perro objPerro = new Perro();

            Console.Write("\nNombre del perro: ");
            objPerro.Nombre = Console.ReadLine();

            Console.Write("Sexo (M/H): ");
            objPerro.Sexo = Convert.ToChar(Console.ReadLine());

            Console.Write("Nombre del dueño: ");
            objPerro.Dueno = Console.ReadLine();

            Console.Write("Altura (cm): ");
            objPerro.AlturaALaCruz =
                Convert.ToDouble(Console.ReadLine());

            objPerro.MostrarPerro();
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }

        Console.WriteLine("\nRegistro finalizado.");
        Console.ReadKey();
    }
}
