namespace CodeFirstEF_example
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        public List<Post> Posts { get; set; }

        public override string ToString()
        {
            return string.Format("#{0} <<{1}>> \n{2}",BlogId,Name,string.Join("\n",Posts));
        }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public override string ToString()
        {
            return string.Format("[---{0}---]\nNews: {1}\n{2}\n---------------------",
                                        PostId,Title,Content);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Blog theBlog = new Blog();
            theBlog.BlogId = 1;
            theBlog.Name = "My Smashing Blog";
            theBlog.Posts = new List<Post>(); // prepare the list of posts


            Post p1 = new Post();
            p1.PostId = 1;
            p1.Title = "The first (smashing) post";
            p1.Content = "Hello, welcome to the blog!";
            theBlog.Posts.Add(p1);

            Post p2 = new Post();
            p2.PostId = 2;
            p2.Title = "And now for something seriously smashing...";
            p2.Content = "Bla bla bla!";
            theBlog.Posts.Add(p2);

            Console.WriteLine(theBlog);
        }
    }
}