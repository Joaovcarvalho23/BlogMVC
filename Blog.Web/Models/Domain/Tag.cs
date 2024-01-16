namespace Blog.Web.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }

        public string? Nome { get; set; }

        public string? ExibicaoNome { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; } //uma tag pode ter uma coleção de posts de blog
    }
}
