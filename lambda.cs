// ruecuerda que el ultimo int es el tipo de dato que va a retornar 
Func<int, int, int> Sumar = (a, b) => a + b;

Func<int, int> Some = (a) => a * 2;

Sumar(2, 1);


// podemos pasar los parametro como una arroy function o lambda
SomeReturn((a, b) => a + b, 5); //10
void SomeReturn(Func<int, int, int> fn, int number)
{
    var result = fn(number, number);
    Console.WriteLine(result);
}