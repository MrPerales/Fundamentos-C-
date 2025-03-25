// using System.Text.Json;
// using ClassPost;

// class Program
// {
//     // 
//     static async Task Main()
//     {
//         string url = "https://jsonplaceholder.typicode.com/posts";
//         HttpClient client = new HttpClient();

//         var resp = await client.GetAsync(url);

//         if (resp.IsSuccessStatusCode)
//         {
//             var content = await resp.Content.ReadAsStringAsync(); // me da el contenido

//             // deserializamos y lo ponemos en una lista 

//             List<Post> posts = JsonSerializer.Deserialize<List<Post>>(content);

//             foreach (var post in posts)
//             {
//                 Console.WriteLine($"Id: {post.id}, UserId: {post.userID}, Title: {post.title}, Body: {post.body}");
//                 Console.WriteLine("---------------------------------------------");
//             }
//         }

//     }
// }
