using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FastTickets.Models
{
    public class PromoterModel
    {
        [Key]
        public int PromoterId { get; set; }

        [DisplayName("Promoter do Evento")]
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public List<CadastroEventoModel> ListaEventos { get; set; }

    }
}