// using System.Text.Json;
// using ClassPost;

// class Program
// {
//     static async Task Main()
//     {
//         string url = "https://jsonplaceholder.typicode.com/posts";

//         var client = new HttpClient();

//         Post post = new Post()
//         {
//             userID = 50,
//             body = "body",
//             title = "new title"
//         };
//         // serializamos el contenido 

//         var data = JsonSerializer.Serialize<Post>(post);
//         // cuando hacemos solicitud POST tenemos que mandar mas cosas 
//         // - datos serializados 
//         // - formato en el que lo mandas 
//         // - typo de contenido que mandamos
//         var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
//         // hacemos la solicitud POST 
//         var httpResponse = await client.PostAsync(url, content);

//         if (httpResponse.IsSuccessStatusCode)
//         {
//             // leemos el contenido que nos regresa la peticion 
//             var result = await httpResponse.Content.ReadAsStringAsync();
//             // deserializamos para poder usarlo en C# 
//             var postResult = JsonSerializer.Deserialize<Post>(result);
//             Console.WriteLine(postResult?.body);
//             Console.WriteLine(postResult?.id);

//         }

//     }
// }