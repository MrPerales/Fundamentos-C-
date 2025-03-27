using Fundamentos.conectionDB;
using Fundamentos.lamdba;

namespace Fundamentos
{
    class Program
    {
        static void Main()
        {
            // lambda 
            // lambdaExamples suma = new lambdaExamples();
            // suma.Sumar(2, 1);

            // suma.SomeReturn((a, b) => a + b, 5);

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
            Console.WriteLine("-------------------------------");


        }
    }
}