// LINQ es una extension de C# que permite realizar consultas a colecciones de datos 
var names = new List<string>()
{
    "John",
    "D",
    "Jane",
    "Carlos",
};
var users = new IUser[]{
   new IUser { Name= "John" , Age= 20},
   new IUser { Name= "D", Age= 21 },
   new IUser { Name= "Jane", Age= 22 },
   new IUser { Name= "Carlos", Age= 23 },

};


// namesResult se ejecuta en el momento que se recorre el foreach
// si quieres ejectarlo directamente solo encierra la consulta ('consulta').ToList()
var namesResult = from n in names
                  where n.Length > 3 && n.Length < 5 //filtra por longitud
                  orderby n   //ordena por nombre
                  select n; //selecciona el nombre de la lista 

// otra forma de hacer consulta es mediante funciones 
var namesResult2 = names.Where(n => n.Length > 3 && n.Length < 5)
                        .OrderBy(n => n)
                        .Select(n => n);



foreach (var name in namesResult)
{
    Console.WriteLine(name);
}
Console.WriteLine("-----------------");
foreach (var name in namesResult2)
{
    Console.WriteLine(name);
}

public class IUser
{
    public string Name { get; set; }
    public int Age { get; set; }
}
// why dont working  with interface? 
interface Isuer2
{
    string Name { get; set; }
    int Age { get; set; }
}
