using Desenvolvimento.Models;
using Desenvolvimento.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Desenvolvimento.Controllers
{
    public class ProtocoloController : Controller
    {
        private readonly IProtocoloRepositorio _protocoloRepositorio;

        public ProtocoloController(IProtocoloRepositorio portocoloRepositorio)
        {
            _protocoloRepositorio = portocoloRepositorio;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(ProtocoloModel protocolo)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _protocoloRepositorio.Adiciona(protocolo);
                    TempData["MensagemSucesso"] = "Protocolo cadastrado com sucesso.";
                    return RedirectToAction("Consultar");
                }

                return View(protocolo);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Protocolo não cadastrado com sucesso, tente novamente, erro: {erro.Message}";
                return RedirectToAction("Consultar");
            }
        }

        public IActionResult Consultar()
        {
            List<ProtocoloModel> listar = _protocoloRepositorio.ListarTodos();
            return View(listar);
        }
    }
}
