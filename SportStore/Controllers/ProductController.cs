using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IPproductRepository repository;

        public ProductController(IPproductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Products);



    }
}
