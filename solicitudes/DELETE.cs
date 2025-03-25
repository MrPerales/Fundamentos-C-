using ClassPost;

class Program
{
    static async Task Main()
    {
        // cambiamos el endpoint para hacer el delete 

        string url = "https://jsonplaceholder.typicode.com/posts/98";

        var client = new HttpClient();


        var httpResponse = await client.DeleteAsync(url);

        if (httpResponse.IsSuccessStatusCode)
        {

            var result = await httpResponse.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }




    }
}