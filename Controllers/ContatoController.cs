using DIO_Projeto_API.Context;
using DIO_Projeto_API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DIO_Projeto_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();

            return CreatedAtAction(nameof(FindById), new{id = contato.Id}, contato);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id) 
        {
            var contato = _context.Contatos.Find(id);

            if(contato == null)
            return NotFound();

            return Ok(contato);
        }

        [HttpGet("FindByName")]
        public IActionResult FindByName(string nome) 
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contato contato) 
        {
            var contatoUpdate = _context.Contatos.Find(id);
            if(contatoUpdate == null)
            return NotFound();

            contatoUpdate.Nome = contato.Nome;
            contatoUpdate.Telefone = contato.Telefone;
            contatoUpdate.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoUpdate);
            _context.SaveChanges();

            return Ok(contatoUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            var contatoDelete = _context.Contatos.Find(id);
            if(contatoDelete == null)
            return NotFound();
            
            _context.Contatos.Remove(contatoDelete);
            _context.SaveChanges();
            
            return NoContent();
        }
    }
}