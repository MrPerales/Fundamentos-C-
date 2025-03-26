// using System.Text.Json;
// using ClassPost;

// class Program
// {
//     static async Task Main()
//     {
//         // cambiamos el endpoint para hacer put 
//         string url = "https://jsonplaceholder.typicode.com/posts/98";

//         var client = new HttpClient();

//         Post post = new Post()
//         {
//             body = "other body",
//             title = "other new title"
//         };

//         // serializamos 
//         var data = JsonSerializer.Serialize<Post>(post);

//         // mandamos los datos faltates 
//         var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

//         // hacemos peticion PUT 
//         var httpResponse = await client.PutAsync(url, content);

//         if (httpResponse.IsSuccessStatusCode)
//         {
//             // respuesta del endpoint 
//             var result = await httpResponse.Content.ReadAsStringAsync();

//             var putResult = JsonSerializer.Deserialize<Post>(result);


//         }

//     }
// }