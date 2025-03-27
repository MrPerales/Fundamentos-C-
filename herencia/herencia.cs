// formas de crear una istancia de la clase 
// 1 forma 
// Sale sale = new SaleWithTax(15, 1.16m); //m para indicar que es decimal
// var message = sale.GetInfo();
// // var protected= sale.GetProtected(); //no se puede acceder desde fuera 
// Console.WriteLine(message);
// // sale.Total= 15 //tenemos que tener el set para poder asignar el valor 

// // 2 forma 
// // no confundir "var" con el "var" de JavaScript 
// // var sale= new Sale();

// // 3forma 
// // no es tan utilizada 
// // Sale sale = new();

// /////////////////////////////////////////////////////////
// ///////////////// Herencia de clases /////////////////////

class SaleWithTax : Sale
{
    public decimal Tax { get; set; }
    // constructor , ya que la clase Sale necesita un argumento 
    // se lo mandamos desde el contructor de la clase SaleWithTax
    // :base(total) con esto le mandamos el argumento a la clase padre 
    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        GetProtected();
        this.Tax = tax;
    }
    public string GetInfoWithTax()
    {
        return "El total es" + Total + " Impuesto : " + Tax;
    }
    // sobreescritura 
    // se le agrega "override" para que se puede sobreesctibir 
    // lo que significa que va a llamar a este metodo y no al metodo del padre
    public override string GetInfo()
    {
        return "El total es " + Total + " Impuesto : " + Tax;
    }

    // sobrecarga = se puede llamar igual pero con diferentes argumentos 
    public string GetInfo(string message)
    {
        return message;
    }
    public string GetInfo(int a)
    {
        return " " + a;
    }
}

class Sale
{
    public decimal Total { get; set; } // get and set para obtener y asignar valor
    // propiedad privada solo se accede de manera local (dentro de la clase)
    private decimal _some;

    // constructor tiene el mismo nombre de la clase 
    public Sale(decimal total)
    {
        this.Total = total;


    }
    // para que se pueda hacer sobreescritura se agreda "virtual"
    public virtual string GetInfo()
    {
        return "El total es " + Total;
    }

    // protected solo se puede acceder desde la clase padre o hijo 
    protected string GetProtected()
    {
        return "soy un protected";
    }


}