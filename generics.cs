// // generics 
// // pueden recibir cualquier tipo de dato 
// var numbers = new MyList<int>(5);
// var names = new MyList<string>(5);
// var beers = new MyList<Beer>(2);

// numbers.Add(1);
// numbers.Add(2);
// numbers.Add(3);
// // Console.WriteLine(numbers.GetContent());

// names.Add("carlos");
// names.Add("carlos1");
// names.Add("carlos2");
// names.Add("carlos3");
// // Console.WriteLine(names.GetContent());
// // usamos el new Beer para crear un objeto de tipo beer ya que no lo hemos creado
// beers.Add(new Beer() { Name = "Modelo", Price = 15 });
// beers.Add(new Beer() { Name = "corona", Price = 15 });

// Console.WriteLine(beers.GetContent());

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    public string GetContent()
    {
        string content = "";
        foreach (var element in _list)
        {
            content += element + ",";
        }
        return content;
    }
}

public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    // las clases por derecto tiene un tipado ":object " el cual lo vamos a
    //  sobreescribir para poder mostrar la informacion 
    public override string ToString()
    {
        return "Name: " + Name + ", Price: " + Price;
    }
}