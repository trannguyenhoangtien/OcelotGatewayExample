using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using ProductAPI.Services;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> ProductList()
        {
            return _productService.GetProductList();
        }

        [HttpGet("{id}")]
        public Product GetProductId(int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPost]
        public Product AddProduct(Product product)
        {
            return _productService.AddProduct(product);
        }

        [HttpPut]
        public Product UpdateProduct(Product product)
        {
            return _productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public bool DeleteProduct(int id)
        {
            return _productService.DeleteProduct(id);
        }
    }
}