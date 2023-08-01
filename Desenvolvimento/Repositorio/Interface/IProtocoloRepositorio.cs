using Desenvolvimento.Models;
using System.Collections.Generic;

namespace Desenvolvimento.Repositorio.Interface
{
    public interface IProtocoloRepositorio
    {
        ProtocoloModel Adiciona(ProtocoloModel protocolo);

        List<ProtocoloModel> ListarTodos();
    }
}
