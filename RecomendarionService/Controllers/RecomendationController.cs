using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecomendarionService.Models.EF;

namespace RecomendarionService.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class RecomendationController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Products> Get(int id)
        {
            using (var context = new DataProductsContext())
            {
                //get all authors
                return context.Products.Where(d => d.Id == id).ToList();
            }
        }
    }
}