using Microsoft.AspNetCore.Mvc;
using DeveloperStore.API.Models;
using DeveloperStore.API.Services;
using System.Collections.Generic;

namespace DeveloperStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        // Construtor que injeta o serviço IProductService
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // Endpoint para obter todos os produtos
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            // Chama o serviço para obter todos os produtos
            return Ok(_productService.GetAllProducts());
        }

        // Endpoint para obter um produto por ID
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound(); // Retorna NotFound caso o produto não seja encontrado
            }
            return Ok(product); // Retorna o produto encontrado
        }

        // Endpoint para criar um novo produto
        [HttpPost]
        public ActionResult<Product> CreateProduct(Product product)
        {
            var createdProduct = _productService.CreateProduct(product);
            // Retorna o produto criado, com status 201 Created e o local do recurso
            return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.ProductId }, createdProduct);
        }

        // Endpoint para atualizar um produto existente
        [HttpPut("{id}")]
        public ActionResult<Product> UpdateProduct(int id, Product product)
        {
            // Compara o ID da URL com o ID do objeto de produto
            if (id != Convert.ToInt32(product.ProductId))  // Convertendo ProductId para int
            {
                return BadRequest(); // Retorna BadRequest se os IDs não coincidirem
            }

            var updatedProduct = _productService.UpdateProduct(product);
            return Ok(updatedProduct); // Retorna o produto atualizado
        }

        // Endpoint para deletar um produto
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id); // Chama o serviço para deletar o produto
            return NoContent(); // Retorna NoContent, que é um status 204
        }
    }
}
