
var Animal = new Animales();



Animal.Id = 1;
Animal.Nombre = "Zeus";
Animal.Activo = true;
Animal.Peso = 34.8m;
Animal.Tipo = new Tipos() { Id = 1, Nombre = "Carnivoro" };
Animal.Razas = new Razas() { Nombre = "Labrador" };
Animal.Habilidades = new List<Habilidades>();
Animal.Habilidades.Add(new Habilidades() { Id = 1, Nombre = "Veloz" });
Animal.Habilidades.Add(new Habilidades() { Id = 2, Nombre = "Salto" });
Console.WriteLine(Animal.Nombre);
Console.WriteLine(Animal.Tipo.Nombre);

foreach (var elemento in Animal.Habilidades)
{
    Console.WriteLine(elemento.Nombre);
}

public class Tipos
{
    public int Id = 0;
    public string? Nombre = "";

    public List<Animales> Animales = new List<Animales>();
}
public class Razas
{
    public string Nombre = "";
}

public class Habilidades
{
    public int Id = 0;
    public String? Nombre = "";
}
public class Animales
{
    public int Id = 0;
    public String? Nombre = "";
    public DateTime Fecha = DateTime.Now;

    public bool Activo = false;
    public decimal Peso = 0.0m;
    public Tipos Tipo = new Tipos();
    public Raza Razas = new Razas();
    public List<Habilidades> Habilidades = new List<Habilidades>();

    }



