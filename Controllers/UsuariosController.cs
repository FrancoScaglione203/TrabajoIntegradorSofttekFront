using Data.Base;
using Data.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using TrabajoIntegradorSofttekFront.ViewModels;

namespace TrabajoIntegradorSofttekFront.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public UsuariosController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Usuarios()
        {
            return View();
        }

        public async Task<IActionResult> UsuariosAddPartial()
        {

            return PartialView("~/Views/Usuarios/Partial/UsuariosAddPartial.cshtml");
            //var usuariosViewModel = new UsuariosViewModel();
            //if (usuario != null)
            //{
            //    usuariosViewModel = usuario;
            //}


        }

        public IActionResult GuardarUsuario(UsuarioDto usuario)
        {
            var token = HttpContext.Session.GetString("Token");
            var baseApi = new BaseApi(_httpClient);
            var usuarios = baseApi.PostToApi("Usuario", usuario, token);
            return View("~/Views/Usuarios/Usuarios.cshtml");
        }
    }
}
