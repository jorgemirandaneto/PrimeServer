using System.Collections.Generic;
using System.Linq;
using Prime.Context;
using Prime.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Prime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientePessoaJuridicaController :  ControllerBase
    {
        private readonly TodoContext context;
        
        public ClientePessoaJuridicaController(TodoContext _context)
        {
            this.context = _context;
        }  

        [HttpGet]
        public IEnumerable<ClientePessoaJuridica> Get () {
            return context.ClientePessoaJuridica.ToList();
        }

        [HttpGet ("{id}")]
        public ClientePessoaJuridica Get (int id) {
            return context.ClientePessoaJuridica.Find(id);
        }

        [HttpPost]
        public IActionResult Post ([FromBody] ClientePessoaJuridica pessoa) {
            try
            {
                context.Add(pessoa);  
                context.SaveChanges(); 
                return Ok();
            }
            catch (System.Exception ex)
            {
                 return NotFound(ex);
            }
        }

        [HttpPut]
        public IActionResult Put ([FromBody] ClientePessoaJuridica pessoa) {
            try
            {
                context.Update(pessoa);  
                context.SaveChanges(); 
                return Ok ();
            }
            catch (System.Exception ex)
            {
                return NotFound(ex);
            }
            
        }

        [HttpDelete ("{id}")]
        public IActionResult Delete (int id) {
            try
            {
                var pessoa = context.ClientePessoaFisica.Find(id);            
                context.Remove(pessoa);  
                context.SaveChanges();  
                return Ok();
            }
            catch (System.Exception ex)
            {
                return NotFound(ex);
            }
        }      
    }
}