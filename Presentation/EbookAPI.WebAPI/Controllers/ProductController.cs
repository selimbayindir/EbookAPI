using Ebook.Application.Repositories;
using Ebook.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EbookAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async Task Get() //Task olarak ayarlamalısın AddScoped Kullanmak için
        {
            //await _productWriteRepository.AddRangeAsync(new ()
            // {
            //     new (){Id=Guid.NewGuid(),ProductName="Product 1",Price=100,CreatedDate=DateTime.UtcNow,Stock =10},
            //     new(){Id=Guid.NewGuid(),ProductName="Product 2",Price=200,CreatedDate=DateTime.UtcNow,Stock =20},
            //     new(){Id=Guid.NewGuid(),ProductName="Product 3",Price=300,CreatedDate=DateTime.UtcNow,Stock =130},
            //     new(){Id=Guid.NewGuid(),ProductName="Product 3",Price=300,CreatedDate=DateTime.UtcNow,Stock =130}

            // });
         Product p= await _productReadRepository.GetByIdAsync("636B8944-0B30-4FE8-AEE6-23EAD59A5092",false); ///false olursa tracking çalışmıyacaktır vt ye yansımaz
            p.ProductName = "Eyüp Sabri";

            //var count = await _productWriteRepository.SaveAsync();
           await _productWriteRepository.SaveAsync();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product=await _productReadRepository.GetByIdAsync(id);
            return Ok(product);

        }
       // [HttpGet]
       // public  Task<IActionResult> GetAllProducts()
       // {

       //}
    }
}
