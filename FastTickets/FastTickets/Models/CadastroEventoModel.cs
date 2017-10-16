using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FastTickets.Models
{

    [Table("EVENTO")]
    public class CadastroEventoModel
    {
        [Key]
        [Column("eventoID")]
        public int EventoId { get; set; }

        [Column("nome")]
        [DisplayName("Nome do Evento")]
        public string Nome { get; set; }

        [Column("data")]
        [DisplayName("Data do Evento")]
        public DateTime Data { get; set; }


        [Column("localid")]
        [DisplayName("Local do Evento")]
        public int LocalId { get; set; }



    //    public virtual List<LocalEventoModel> LocalEvento { get; set; }


    }
}