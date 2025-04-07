using CervezaClass;
using VinoClass;
namespace Fundamentos.Interfaces
{

    interface IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        // podemos agregar metodos a la interfaz y tambien si queremos con codigo
        // public void MaxRecomendado(){ // codigo };

        public void MaxRecomendado();

    }

    class InterfaceV2
    {
        // static void Main()
        // {
        //     var bebidaAlcoholica = new Vino(100);
        //     MostrarRecomendacion(bebidaAlcoholica);
        //     Console.WriteLine(".-----------------------.");
        //     // ahora para Cerveza 
        //     var bebidaAlcoholicaCerveza = new Cerveza(10, "Cerveza1");
        //     MostrarRecomendacion(bebidaAlcoholicaCerveza);
        // }
        static public void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();
        }
    }
}