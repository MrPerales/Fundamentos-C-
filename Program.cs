// formas de crear una istancia de la clase 
// 1 forma 
Sale sale= new Sale(15);
var message = sale.GetInfo();
Console.WriteLine(message);
// sale.Total= 15 //tenemos que tener el set para poder asignar el valor 

// 2 forma 
// no confundir "var" con el "var" de JavaScript 
// var sale= new Sale();

// 3forma 
// no es tan utilizada 
// Sale sale = new();
class Sale{ 
    public decimal Total{get;set;} // get and set para obtener y asignar valor
    // propiedad privada solo se accede de manera local (dentro de la clase)
    private decimal _some;

    // constructor tiene el mismo nombre de la clase 
    public Sale( decimal total){
        this.Total= total;
        

    }
    public string GetInfo(){
        return "El total es " + Total;
    }
}