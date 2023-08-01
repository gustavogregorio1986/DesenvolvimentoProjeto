using Desenvolvimento.Models;
using System.Collections.Generic;

namespace Desenvolvimento.Repositorio.Interface
{
    public interface IProtocoloRepositorio
    {
        ProtocoloModel Adiciona(ProtocoloModel protocolo);

        List<ProtocoloModel> ListarTodos();

        ProtocoloModel BuscarPorId(int id);

        ProtocoloModel Atualizar(ProtocoloModel protocolo);

        bool Apagar(int id);
    }
}
