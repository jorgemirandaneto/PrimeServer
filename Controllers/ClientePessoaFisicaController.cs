using System;
using System.Collections.Generic;
using System.Linq;
using Prime.Context;
using Prime.Models;
using Microsoft.AspNetCore.Mvc;

namespace Prime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientePessoaFisicaController :  ControllerBase
    {
        private readonly TodoContext context;
        
        public ClientePessoaFisicaController(TodoContext _context)
        {
            this.context = _context;
        }  

        [HttpGet]
        public IEnumerable<ClientePessoaFisica> Get () {
            return context.ClientePessoaFisica.ToList();
        }

        [HttpGet ("{id}")]
        public ClientePessoaFisica Get (int id) {
            return context.ClientePessoaFisica.Find(id);
        }

        [HttpPost]
        public IActionResult Post ([FromBody] ClientePessoaFisica pessoa) {
            try
            {
                pessoa.dataCriacao = DateTime.Now;                
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
        public IActionResult Put ([FromBody] ClientePessoaFisica pessoa) {
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