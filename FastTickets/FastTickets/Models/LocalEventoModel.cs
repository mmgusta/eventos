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
        public string Nome { get; set; }

        [Column("endereco")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Column("capacidade")]
        public int Capacidade { get; set; }

    }
}