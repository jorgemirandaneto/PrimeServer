using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prime.Models
{
    [Table("ClientePessoaJuridica", Schema = "dbo")]
    public class ClientePessoaJuridica
    {
       [Key]
        public int id { get; set; }

        public string uf { get; set; }

        public string nomeFantasia { get; set; }

        public string cnpj { get; set; }

        public string instituicaoFinanceira { get; set; }
        
    }
}