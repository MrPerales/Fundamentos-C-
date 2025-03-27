// LINQ es una extension de C# que permite realizar consultas a colecciones de datos 

namespace Fundamentos.Linq
{
    class Consulta
    {
        private List<string> _names = new List<string>(){
            "John",
            "D",
            "Jane",
            "Carlos",
        };

        private IUser[] _users = new IUser[]{
            new IUser { Name= "John" , Age= 20},
            new IUser { Name= "D", Age= 21 },
            new IUser { Name= "Jane", Age= 22 },
            new IUser { Name= "Carlos", Age= 23 },

        };

        public List<string> GetLikeSql()
        {
            // namesResult se ejecuta en el momento que se recorre el foreach
            // si quieres ejectarlo directamente solo encierra la consulta ('consulta').ToList()
            var namesResult = from n in _names
                              where n.Length > 3 && n.Length < 5 //filtra por longitud
                              orderby n   //ordena por nombre
                              select n; //selecciona el nombre de la lista 

            var list = new List<string>();
            foreach (var name in namesResult)
            {
                list.Add(name);
                Console.WriteLine(name);

            }
            return list;
        }

        public List<string> GetLikeCSharp()
        {
            // otra forma de hacer consulta es mediante funciones 
            var namesResult2 = _names.Where(n => n.Length > 3 && n.Length < 5)
                                    .OrderBy(n => n)
                                    .Select(n => n);
            var list = new List<string>();
            foreach (var item in namesResult2)
            {
                list.Add(item);
                Console.WriteLine(item);

            }
            return list;
        }
    }
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
