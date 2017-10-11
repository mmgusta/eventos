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
        public int EventoId { get; set; }

        [DisplayName("Nome do Evento")]
        public string NomeEvento { get; set; }

        [DisplayName("Data do Evento")]
        public DateTime DataEvento { get; set; }

        [DisplayName("Local do Evento")]
        public int LocalId { get; set; }

        [DisplayName("Promoter do Evento")]
        public int PromoterId { get; set; }

        public virtual LocalEventoModel LocalEvento { get; set; }

        public virtual  PromoterModel Promoter { get; set; }


    }
}