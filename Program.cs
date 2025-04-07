using System.Threading.Tasks;
using CervezaClass;
using ClassPost;
using Fundamentos.conectionDB;
using Fundamentos.lamdba;
using Fundamentos.Linq;
using Fundamentos.solicitudes;
using System.Text.Json;
using VinoClass;
using Fundamentos.Interfaces;
namespace Fundamentos
{
    class Program
    {
        static void Main()
        {
            bool salir = true;
            while (salir)
            {
                Console.WriteLine("-------MENU PRINCIPAL-----");
                Console.WriteLine("1.- Lambda");
                Console.WriteLine("2.- Coneccion a base de datos");
                Console.WriteLine("3.- Genericos");
                Console.WriteLine("4.- LINQ");
                Console.WriteLine("5.- Serializacion y deserializacion");
                Console.WriteLine("6.- Interfaces ");
                Console.WriteLine("7.-  salir");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        //lambda
                        lambdaExamples suma = new lambdaExamples();
                        suma.Sumar(2, 1);

                        suma.SomeReturn((a, b) => a + b, 5);
                        break;
                    case "2":
                        bool subMenu = true;
                        // Conection a Base de datos 
                        CervezaBD cervezaBD = new CervezaBD();
                        while (subMenu)
                        {
                            Console.WriteLine("1.- Agregar una cerveza");
                            Console.WriteLine("2.- Editar una cerveza");
                            Console.WriteLine("3.- Eliminar una cerveza ");
                            Console.WriteLine("4.-  Obtener todas las cervezas ");
                            Console.WriteLine("5.-  salir");


                            string subOption = Console.ReadLine();
                            switch (subOption)
                            {
                                case "1":
                                    // agregamos una Cerveza
                                    // { } hack para crear un scope distinto
                                    {
                                        var cerveza = new Cerveza(2, "Pale ale");
                                        cerveza.Marca = "minerva";
                                        cerveza.Alcohol = 6;
                                        cervezaBD.Add(cerveza);
                                    }
                                    break;
                                case "2":
                                    ///editamos una cerveza 
                                    {
                                        var cerveza = new Cerveza(5, "Pale ale");
                                        cerveza.Marca = "minerva";
                                        cerveza.Alcohol = 5;
                                        cervezaBD.Edit(cerveza, 40);
                                    }
                                    break;
                                case "3":
                                    ///eliminamos una cervez 
                                    {
                                        cervezaBD.Delete(40);
                                    }
                                    break;
                                case "4":
                                    // Obtenemos todas las cervezas 
                                    var cervezas = cervezaBD.Get();
                                    foreach (var item in cervezas)
                                    {
                                        Console.WriteLine(item.Name);

                                    }
                                    break;
                                case "5":
                                    subMenu = false;
                                    break;
                                default:
                                    Console.WriteLine("Opcion no valida ");

                                    break;
                            }
                        }

                        break;
                    case "3":
                        // generics 
                        // pueden recibir cualquier tipo de dato 
                        Console.WriteLine("-------Genericos-------");
                        Console.WriteLine("Con Enteros");

                        var numbers = new MyList<int>(5);

                        numbers.Add(1);
                        numbers.Add(2);
                        numbers.Add(3);
                        Console.WriteLine(numbers.GetContent());

                        Console.WriteLine("Con Strings");

                        var names = new MyList<string>(5);
                        names.Add("carlos");
                        names.Add("carlos1");
                        names.Add("carlos2");
                        names.Add("carlos3");
                        Console.WriteLine(names.GetContent());


                        Console.WriteLine("Con Clases Personalizadas");

                        var beers = new MyList<Beer>(2);
                        // usamos el new Beer para crear un objeto de tipo beer ya que no lo hemos creado
                        beers.Add(new Beer() { Name = "Modelo", Price = 15 });
                        beers.Add(new Beer() { Name = "corona", Price = 15 });
                        break;
                    case "4":
                        // LINQ COMPLEJO
                        var bar = new LINQComplejo();
                        var bares = bar.GetBarsWithEspecificBeer();
                        foreach (var item in bares)
                        {
                            Console.WriteLine(item.cervezas[0].Name);
                        }
                        break;
                    case "5":
                        // // transformando obj a Json y viceversa 
                        // // para eso llamamos a la librerua 
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


                        break;
                    case "6":
                        var bebidaAlcoholica = new Vino(100);

                        InterfaceV2.MostrarRecomendacion(bebidaAlcoholica);
                        Console.WriteLine(".-----------------------.");
                        // ahora para Cerveza 
                        var bebidaAlcoholicaCerveza = new Cerveza(10, "Cerveza1");
                        InterfaceV2.MostrarRecomendacion(bebidaAlcoholicaCerveza);
                        break;
                    case "7":
                        salir = false;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida ");
                        break;
                }


            }
        }


    }
}
// lambda 
// 
// Conection a Base de datos 
// CervezaBD cervezaBD = new CervezaBD();

// agregamos una Cerveza 
// {} hack para crear un scope distinto 
// {
//     var cerveza = new Cerveza(2, "Pale ale");
//     cerveza.Marca = "minerva";
//     cerveza.Alcohol = 6;
//     cervezaBD.Add(cerveza);
// }
/////////////////////
///editamos una cerveza 
// {
//     var cerveza = new Cerveza(5, "Pale ale");
//     cerveza.Marca = "minerva";
//     cerveza.Alcohol = 5;
//     cervezaBD.Edit(cerveza, 40);
// }

////////////////////////////
///eliminamos una cervez 
// {
//     cervezaBD.Delete(40);
// }

// Obtenemos todas las cervezas 
// var cervezas = cervezaBD.Get();
// foreach (var item in cervezas)
// {
//     Console.WriteLine(item.Name);

// }
// Console.WriteLine("-------------------------------");
/////////////////////////////////////////////////////////////////// 

// Ejemplos para generics

// ??????????????
// var cerveza = new Cerveza(2, "---")
// {
//     Alcohol = 5,
//     Marca = "---",
//     Name = "-----",
//     Cantidad = 1
// };
// ?????????????????????? 
// var serviceCerveza= new SendRequest<Cerveza>(); // ya no es posible usar el tipo de clase Cerveza porque no implementa la interfaz IRequest

// var post = new Post() { };
// var service = new SendRequest<Post>();
// var resp = await service.Post(post);
// Console.WriteLine(resp.Title);

// Console.WriteLine("-------------------------------");
/////////////////////////////////////////////////////////////////// 


////////////
// LINQ 
////
// Consulta consulta = new Consulta();

// List<string> sql = consulta.GetLikeSql();
// var cSharp = consulta.GetLikeCSharp();
// Console.WriteLine(sql);

// LINQ COMPLEJO
// var bar = new LINQComplejo();
// var bares = bar.GetBarsWithEspecificBeer();
// foreach (var item in bares)
// {
//     Console.WriteLine(item.cervezas[0].Name);
// }