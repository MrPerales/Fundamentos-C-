using System.Text.Json;

namespace Fundamentos.solicitudes
{

    class SendRequest<T>
    {
        private HttpClient _client = new HttpClient();
        private string _url = "https://jsonplaceholder.typicode.com/posts";

        public async Task<T> Get()
        {
            var httpResponse = await _client.GetAsync(_url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                var posts = JsonSerializer.Deserialize<T>(content);

                // foreach (var post in posts)
                // {
                //     Console.WriteLine($"Id: {post.id}, UserId: {post.userID}, Title: {post.title}, Body: {post.body}");
                //     Console.WriteLine("---------------------------------------------");
                // }
                return posts;
            }

            return default(T);
        }
        public async Task<T> Post(T post)
        {
            // serializamos el contenido 

            var data = JsonSerializer.Serialize<T>(post);
            // cuando hacemos solicitud POST tenemos que mandar mas cosas 
            // - datos serializados 
            // - formato en el que lo mandas 
            // - typo de contenido que mandamos
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await _client.PostAsync(_url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                // leemos el contenido que nos regresa la peticion 
                var result = await httpResponse.Content.ReadAsStringAsync();
                // deserializamos para poder usarlo en C# 
                var postResult = JsonSerializer.Deserialize<T>(result);
                return postResult;
            }
            return default(T);
        }
        public async Task<T> Put(T payload, int id)
        {
            // serializamos 
            var data = JsonSerializer.Serialize<T>(payload);
            // content
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _client.PutAsync(_url + id, content);
            if (httpResponse.IsSuccessStatusCode)
            {
                // respuesta del endpoint 
                var result = await httpResponse.Content.ReadAsStringAsync();

                var putResult = JsonSerializer.Deserialize<T>(result);
                return putResult;
            }
            return default(T);
        }

        public async Task<T> Delete(int id)
        {
            var httpResponse = await _client.DeleteAsync(_url + id);
            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();
                var deleteResult = JsonSerializer.Deserialize<T>(result);

                return deleteResult;
            }

            return default(T);
        }

    }
}