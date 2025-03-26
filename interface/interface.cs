
// var sale = new Sale();
// var beer = new Beer();

// Some(sale);
// Some(beer);


// // el argumento save es de tipo Isave
// void Some(ISave save)
// {
//     // como es implemntado por la interfaz ya sabemos que metodos tiene
//     save.Save();

// }
// interface ISale
// {
//     decimal Total { get; set; }
// }
// interface ISave
// {
//     public void Save();
// }
// // implementamos la interfaz en la clase Sale, se puedesn agregar mas interfaces
// public class Sale : ISale, ISave
// {
//     // tiene que tener las mismas propiedades de la interfaz 
//     public decimal Total { get; set; }
//     public void Save()
//     {
//         Console.WriteLine("Se Guardo ");
//     }

// }

// public class Beer : ISave
// {
//     public void Save()
//     {
//         Console.WriteLine("Se Guardo en servicio ");
//     }

// }