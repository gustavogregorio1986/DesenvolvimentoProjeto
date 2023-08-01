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

        public IActionResult Editar(int id)
        {
            ProtocoloModel protocolo = _protocoloRepositorio.BuscarPorId(id);
            return View(protocolo);
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

        [HttpPost]
        public IActionResult Alterar(ProtocoloModel protocolo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _protocoloRepositorio.Atualizar(protocolo);
                    TempData["MensagemSucesso"] = "Protocolo atualizado com sucesso.";
                    return RedirectToAction("Consultar");
                }
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Protocolo não atualizado com sucesso, tente novamente, erro: {erro.Message}";
                return RedirectToAction("Consultar");
            }

            return View("Editar", protocolo);
        }

        public IActionResult Consultar()
        {
            List<ProtocoloModel> listar = _protocoloRepositorio.ListarTodos();
            return View(listar);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ProtocoloModel protocolo = _protocoloRepositorio.BuscarPorId(id);
            return View(protocolo);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _protocoloRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Protocolo Apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Ops, não conseguimos apagar o seu Protocolo";
                }

                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar o seu contato, mais detalhes do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
