using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShelbyWeb.Models
{
    public class ZUsuario
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }
    }
}