using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace FastTickets.Models
{
    
    [Table("LOCAL_EVENTO")]
    public class LocalEventoModel
    {
        [Key]
        [Column("localid")]
        public int LocalId { get; set; }

        [Column("nome")]
        [Required(ErrorMessage = "Digite o local do Evento")]
        [StringLength(100, ErrorMessage = "O local deve ter entre 1-100 caracteres")]
        [DisplayName("Local do Evento")]
        public string Nome { get; set; }

        [Column("endereco")]
        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Digite o endereço do Evento")]
        [StringLength(150, ErrorMessage = "O endereço deve ter entre 1-150 caracteres")]
        public string Endereco { get; set; }

        [Column("capacidade")]
        [Required(ErrorMessage = "O campo capacidade é obrigatório")]
        [Range(100,100000)]
        public int Capacidade { get; set; }

    }
}