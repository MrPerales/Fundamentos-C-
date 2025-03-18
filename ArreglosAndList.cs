using CervezaClass;
class ArraysAndList
{
    static void Main()
    {
        // creamos un arreglo 
        // int[10]=> numero de elementos del arreglo
        // {1,2,3,...} => si queremos que tenga valores se los agregamos de esta forma
        int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        var numero = numbers[0]; //obtenemos el primer elemento
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(".----------------------------------.");
        // Listas 
        // List< Tipo > => tipo de dato que va a ser la lista 
        //{1,2,3,...} => tambien se pueden agregar valores como en el array 
        List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        // paraa agregar elemetos a la lista usamos sus metodos 
        lista.Add(1);
        lista.Add(2);
        lista.Remove(2); //removemos el elemento 

        foreach (var item in lista)
        {
            Console.WriteLine("elemento : " + item);

        }

        Console.WriteLine(".----------------------------------.");

        // Lista de Class

        List<Cerveza> cervezas = new List<Cerveza>();
        cervezas.Add(new Cerveza(2, "Cerveza1"));

        Cerveza cerveza2 = new Cerveza(10, "cerveza2");
        cervezas.Add(cerveza2);

        foreach (var item in cervezas)
        {
            Console.WriteLine("nombre :" + item.Name);
        }

    }
}