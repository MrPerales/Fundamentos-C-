var show = Show;
show("hola ");

Some(show, "Hola, soy un mensaje");

void Show(string message)
{
    Console.WriteLine(message);

}
// Action es un elemento que recive "void" osea que no retorna nada 
// Action<string> que tipo de dato recive
// Some es una funcion que recive funciones como parametro 
void Some(Action<string> fn, string message)
{
    Console.WriteLine("hace algo al inicio");
    fn(message);
    Console.WriteLine("Hace algo al final ");

}


// Ahora vamos a hacer lo mismo pero con una funcion que RETORNE algo 
var showReturn = ShowReturn;
SomeReturn(showReturn, "Retorna este mensaje ");
string ShowReturn(string message)
{
    return message.ToUpper();
}
// Func es un elemento que recive un tipo de dato y SI RETORNA algo 
// Func<string, string> al pricipio ponemos los tipos de dato que va a recivir  
//  y al final el tipo de dato que se va a retornar 
// 
void SomeReturn(Func<string, string> fn, string message)
{
    Console.WriteLine("hace algo al inicio");
    Console.WriteLine(fn(message));

    Console.WriteLine("Hace algo al final ");
}