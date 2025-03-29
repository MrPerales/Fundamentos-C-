namespace ClassPost
{

    public class Post : IRequest
    {
        public int UserID { set; get; }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}