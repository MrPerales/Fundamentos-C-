using CervezaClass;

namespace Fundamentos.Linq
{

    class LINQComplejo
    {
        List<Bar> bares = new List<Bar>(){
            new Bar("El bar"){
            cervezas = new List<Cerveza>(){
                    new Cerveza(cantidad:10,name: "Pale Ale"){ Alcohol=7,Marca="Minerva"},
            new Cerveza(cantidad:5,name:"Ticus"){ Alcohol=8,Marca="Colima"},
            new Cerveza(cantidad:8,name: "Stout"){ Alcohol=7,Marca="Minerva"},
                }
            },
            new Bar("El bar 2"){
                cervezas = new List<Cerveza>(){
            new Cerveza(cantidad:100, name: "Piedra lisa"){ Alcohol=6,Marca="Colina"},
            new Cerveza(cantidad:8,name: "Stout"){ Alcohol=7,Marca="Minerva"},


                }
            },
            new Bar("El bar nuevo")

        };

        public List<Bar> GetBarsWithEspecificBeer()
        {
            //  esta consulta devuelve una lista de bares donde hay cervezas con el nombre deseado

            var bar = (from d in bares
                       where d.cervezas.Where((c) => c.Name == "Ticus").Count() > 0
                       select d).ToList();

            Console.WriteLine(bar);

            // esta consulta devuelve una lista de bares 
            // en la que su listado de cervezas tienen SOLO los campos de nombre y cantidad
            var bar2 = (from d in bares
                        where d.cervezas.Where((c) => c.Name == "Ticus").Count() > 0
                        select new BarData(d.Nombre)
                        {     ///listado de BarData
                            // hacemos una subconsulta 
                            bebidas = (from a in d.cervezas  // from a en la coleccion de bares hsy uns lista de cervezas 
                                       select new Bebida(a.Name, a.Cantidad) //creamos o seleccionamos que elementos van a estar en la lista de BarData
                                       ).ToList()
                        }
               ).ToList();

            // Por regresar algo 

            return bar;
        }
    }
}

//  List<Cerveza> cervezas = new List<Cerveza>(){
//             new Cerveza(cantidad:10,name: "Pale Ale"){ Alcohol=7,Marca="Minerva"},
//             new Cerveza(cantidad:5,name:"Ticus"){ Alcohol=8,Marca="Colima"},
//             new Cerveza(cantidad:8,name: "Stout"){ Alcohol=7,Marca="Minerva"},
//             new Cerveza(cantidad:100, name: "Piedra lisa"){ Alcohol=6,Marca="Colina"},

//         };
