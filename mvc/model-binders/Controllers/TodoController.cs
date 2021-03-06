using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody]Todo todo)
        {
            return Created($"/todo/{todo.Id}", todo);
        }
    }
}