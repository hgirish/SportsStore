using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class AdminController :  Controller
    {
        private readonly IProductRepository repository;

        public AdminController(IProductRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index() => View(repository.Products);
    }
}
