using Blog.Web.Data;
using Blog.Web.Models.Domain;
using Blog.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        private BlogDbContext _blogDbContext;

        public AdminTagsController(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            //Mapeando a Tag Request para a model domain Tag
            var minhaTag = new Tag
            {
                Nome = addTagRequest.Nome,
                ExibicaoNome = addTagRequest.ExibicaoNome
            };

            _blogDbContext.TabelaTags.Add(minhaTag);
            _blogDbContext.SaveChanges();

            return View("Add");
        }
    }
}
