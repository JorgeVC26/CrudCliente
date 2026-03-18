using Microsoft.AspNetCore.Mvc;
using CrudCliente.Data;
using CrudCliente.Models;


namespace CrudCliente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Clientes.ToList());
        }

        [HttpPost]
        public IActionResult Post(Cliente customer)
        {
            _context.Clientes.Add(customer);
            _context.SaveChanges();
            return Ok(customer);
        }
    }
}