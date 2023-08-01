using Desenvolvimento.Data;
using Desenvolvimento.Models;
using Desenvolvimento.Repositorio.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Desenvolvimento.Repositorio
{
    public class ProtocoloRepositorio : IProtocoloRepositorio
    {
        private BancoContext _bancoContext;

        public ProtocoloRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ProtocoloModel Adiciona(ProtocoloModel protocolo)
        {
            _bancoContext.Protocolos.Add(protocolo);
            _bancoContext.SaveChanges();

            return protocolo;
        }

        public bool Apagar(int id)
        {
            ProtocoloModel protocolodb = BuscarPorId(id);

            if (protocolodb == null) throw new System.Exception("Houve um erro na hora de apagar o protocolo");

            _bancoContext.Protocolos.Remove(protocolodb);
            _bancoContext.SaveChanges();

            return true;
        }

        public ProtocoloModel Atualizar(ProtocoloModel protocolo)
        {
            ProtocoloModel protocolodb = BuscarPorId(protocolo.Id);

            if (protocolodb == null) throw new System.Exception("Houve um erro no cadastro do protocolo");

            protocolodb.Nome = protocolo.Nome;
            protocolodb.Email = protocolo.Email;
            protocolodb.NumProtocolo = protocolo.NumProtocolo;
            protocolodb.Tipo = protocolo.Tipo;
            protocolodb.DataProtocolo = protocolo.DataProtocolo;

            _bancoContext.Protocolos.Update(protocolodb);
            _bancoContext.SaveChanges();

            return protocolodb;
        }

        public ProtocoloModel BuscarPorId(int id)
        {
            return _bancoContext.Protocolos.FirstOrDefault(x => x.Id == id);
        }

        public List<ProtocoloModel> ListarTodos()
        {
            return _bancoContext.Protocolos.ToList();
        }
    }
}
