// transformando obj a Json y viceversa 
// para eso llamamos a la librerua 
using System.Text.Json;
var carlos = new People() { Name = "carlos", Age = 25 };

// convertimos a Json
string json = JsonSerializer.Serialize(carlos);
Console.WriteLine(json);

// agregamos el @ para poder escrinbir strings en varias lineas 
// las doble "" son para que C# sepa que viene un string 
string myJson = @"{
    ""Name"":""carlos"",
    ""Age"":25
}";

// convetimos de Json a obj 
var carlosJson = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine(carlosJson?.Name);
Console.WriteLine(carlosJson?.Age);

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}