using Fundamentos.Interfaces;

namespace VinoClass
{

    class Vino : IBebidaAlcoholica
    {
        // implementamos atributo de la interfaz 
        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo recomendado es 5 copas ");
        }

        public string Name { get; set; }
        public int Cantidad { get; set; }
        public Vino(int cantidad, string name = "Vino")
        {
            this.Cantidad = cantidad;
            this.Name = name;
        }
    }
}