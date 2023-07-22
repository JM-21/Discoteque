namespace Discoteque.Data.Models;

public class Album : BaseEntity<int>
{
    public string Name { get; set; } = "";
    public int Year { get; set; } 
    public Generos Genero { get; set; } = Generos.Unknown;
}

public enum Generos 
{
    Rock,
    Metal,
    Salsa,
    Merengue,
    Urban,
    Folk,
    Indie,
    Techno,
    Vallenato,
    Unknown
} 