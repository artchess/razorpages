using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsRazorPages.Models;

namespace ProductsRazorPages.Pages.Product
{
    public class DetailsModel : PageModel
    {
        IRepository _repository;
        public Models.Product Product { get; set; }

        public DetailsModel(IRepository repository)
        {
            _repository = repository;
        }

        public void OnGet(int id)
        {
            Product = _repository.GetProductById(id);
        }
    }
}