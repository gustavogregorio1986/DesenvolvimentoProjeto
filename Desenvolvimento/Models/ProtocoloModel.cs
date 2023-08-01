using System;

namespace Desenvolvimento.Models
{
    public class ProtocoloModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int NumProtocolo { get; set; }

        public string Tipo { get; set; }

        public DateTime DataProtocolo { get; set; }
    }
}
