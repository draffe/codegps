using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Utilidades.RequestUtility;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Gps.Administrador.Cliente.Controllers
{
    public class OauthController : Controller
    {

        IRequest _request;
        private IConfiguration _configuration;

        public OauthController(IRequest request, IConfiguration configuration)
        {
            _request = request;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index(string token, string guid)
        {
            dynamic datarespuesta = new System.Dynamic.ExpandoObject();
            datarespuesta.guid = guid;
            string respuesta = _request.Post(new Uri(string.Format("{0}/api/{1}/Oauth", _configuration["Configuracion:UrlApi"], "Autentificacion")), datarespuesta, token);
            var OauthRespuesta = JsonConvert.DeserializeObject<OauthRespuesta>(respuesta);
            var claims = new List<Claim>
                    {
                        new Claim("OauthRespuesta", JsonConvert.SerializeObject(OauthRespuesta)),
                        
                    };

            if(OauthRespuesta.TipodeUsuarioMaestro=="0")
            {
                claims.Add(new Claim(ClaimTypes.Role, "Master"));
            }
            ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties() { IsPersistent = true });

             

            return Redirect("/Administrador");

        }
    }

    public class OauthRespuesta
    {
        public string  NombreUsuario {get;set;}
        public string ApellidoUsuario { get;set;}
        public string Usuario { get;set;}
        public string TipodeUsuarioEmpresa {get;set;}
        public string TipodeUsuarioMaestro {get;set;}
        public List<MenuOpcionesUsuario> Permisos{get;set;}
    }

    public class MenuOpcionesUsuario
    {
        public int MenuOpcionesId { get; set; }
        public int UsuariosId { get; set; }
    }

}