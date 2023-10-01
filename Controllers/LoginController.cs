using Data.Base;
using Data.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TrabajoIntegradorSofttekFront.Models;

namespace TrabajoIntegradorSofttekFront.Controllers
{

	public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public LoginController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Ingresar(LoginDto login)
        {
            var baseApi = new BaseApi(_httpClient);
            var token = await baseApi.PostToApi("Login", login);
            var resultadoLogin = token as OkObjectResult;
            var apiResponse = JsonConvert.DeserializeObject<ApiResponse<LoginResponse>>(resultadoLogin.Value.ToString());
            ViewBag.Nombre = apiResponse.Data.Nombre;
            ViewBag.Cuil = apiResponse.Data.Cuil;

            return View("~/Views/Home/Index.cshtml", apiResponse.Data);
        }
    }
}
