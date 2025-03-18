namespace CervezaClass
{

    class Cerveza
    {
        public string Name { get; set; }
        public int Cantidad { get; set; }
        public Cerveza(int cantidad, string name)
        {
            this.Cantidad = cantidad;
            this.Name = name;
        }
    }
}