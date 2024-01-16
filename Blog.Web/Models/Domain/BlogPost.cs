namespace Blog.Web.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }

        public string? Cabecalho { get; set; }

        public string? TituloPagina { get; set; }

        public string? Conteudo { get; set; }

        public string? DescricaoBreve { get; set; }

        public string? URLDaImagem { get; set; }

        public string? URLHandle { get; set; }

        public DateTime DataPublicacao { get; set; }

        public string? AutorDaPublicacao { get; set; }

        public bool EhVisivel { get; set; }

        public ICollection<Tag> Tags { get; set; } //um BlogPost pode ter várias tags (uma coleção de tags)
    }
}
