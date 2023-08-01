using System;
using System.ComponentModel.DataAnnotations;

namespace Desenvolvimento.Models
{
    public class ProtocoloModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "Informe o email correto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informer o Numero do Protocolo")]
        public int NumProtocolo { get; set; }

        [Required(ErrorMessage = "Informe o Tipo")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Informe a Data do protocolo")]
        public DateTime DataProtocolo { get; set; }
    }
}
