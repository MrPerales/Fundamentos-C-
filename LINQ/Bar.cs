using CervezaClass;

namespace Fundamentos.Linq
{
    public class Bar
    {
        public string Nombre { get; set; }
        public List<Cerveza> cervezas = new List<Cerveza>();

        public Bar(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}