using Fundamentos.Interfaces;

namespace CervezaClass
{

    public class Cerveza : IBebidaAlcoholica
    {
        // implementamos atributo de la interfaz 
        public int Alcohol { get; set; }
        public string Marca { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo recomendado es 10");
        }

        public string Name { get; set; }
        public int Cantidad { get; set; }
        public Cerveza(int cantidad, string name)
        {
            this.Cantidad = cantidad;
            this.Name = name;
        }
    }
}