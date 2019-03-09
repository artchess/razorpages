using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsRazorPages.Models;

namespace ProductsRazorPages.Pages.Product
{
    public class IndexModel : PageModel
    {
        IRepository _repository;

        public List<Models.Product> Products { get; set; }

        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }


        public void OnGet()
        {
            Products = _repository.GetList();
        }
    }
}