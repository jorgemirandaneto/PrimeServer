using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prime.Models
{ 
    [Table("ClientePessoaFisica", Schema = "dbo")]
    public class ClientePessoaFisica
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public DateTime dataCriacao { get; set; }

        public string telefone { get; set; }

        public string instituicaoFinanceira { get; set; }
    }
}