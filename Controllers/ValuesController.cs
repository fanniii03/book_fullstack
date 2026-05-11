using books_backend.Data;
using books_backend.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace books_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRepository booksrepository;
        public ValuesController(IRepository repository)
        {
            this.booksrepository = repository;
        }
        [HttpPost]
        public void Create([FromBody] Books book)
        {
            booksrepository.Create(book);
        }
        [HttpPut("{id}")]
        public void Update([FromBody]Books newbook,string id)
        {
            booksrepository.Update(newbook,id);
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Books> Get()
        {
            return booksrepository.Get();
        }


        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            booksrepository.Delete(id);
        }
    }
}
