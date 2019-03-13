using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using Gps.Seguridad;
using Microsoft.EntityFrameworkCore;
using Gps.BasedeDatos.BasedeDatos;
using Gps.Administrador.Apis.Modelos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Gps.BasedeDatos.Modelos;

namespace Gps.Administrador.Apis.Controllers
{
    [Produces("application/json")]
    [Route("api/Autentificacion")]
    public class AutentificacionController : Controller
    {



        private readonly IConfiguration _configuration;
        private ICriptografiacs cripto;
        private SqlServerAplicationContext context;
        public AutentificacionController(IConfiguration configuration, ICriptografiacs criptografiacs, SqlServerAplicationContext Contect)
        {
            _configuration = configuration;
            cripto = criptografiacs;
            context = Contect;
        }


        private string CrearToken(BasedeDatos.Modelos.Usuarios user)
        {
            var claims = new[]
           {
            new Claim("UserData", JsonConvert.SerializeObject(user))
            };

            // Generamos el Token
            var token = new JwtSecurityToken
            (
                issuer: _configuration["ApiAuth:Issuer"],
                audience: _configuration["ApiAuth:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(60),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["ApiAuth:SecretKey"])),
                SecurityAlgorithms.HmacSha256)
            );

            // Retornamos el token
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Login([FromBody]AutentificacionModel autentificacion)
        {

            using (var con = context)
            {
                var usuario = con.Usuarios.Where(a => a.NombreUsuario == autentificacion.usuario).FirstOrDefault();
                if (usuario != null)
                {
                    if (cripto.Decrypt(usuario.Contrasena) == autentificacion.contrasena)
                    {
                        string tokensttring = CrearToken(usuario);
                        dynamic datarespuesta = new System.Dynamic.ExpandoObject();
                        datarespuesta.guid = usuario.Guid;
                        datarespuesta.token = tokensttring;

                        return Ok(new Respuesta(datarespuesta, false, 0));
                    }
                    else
                    {
                        return Ok(new Respuesta(null, true, 401, "Contrasena Invalida"));
                    }

                }
                else
                {
                    return Ok(new Respuesta(null, true, 401, "Usuario No Existe"));
                }


            }

        }


        [HttpPost]
        [Route("[action]")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Oauth([FromBody]OauthModel guid)
        {
            var user = User.Identity as ClaimsIdentity;
            var someClaim = user.FindFirst("UserData");

            var usuario = JsonConvert.DeserializeObject<Usuarios>(someClaim.Value);
            dynamic datarespuesta = new System.Dynamic.ExpandoObject();
            using (var _contex = context)
            {
                
                datarespuesta.NombreUsuario = usuario.Nombre;
                datarespuesta.ApellidoUsuario = usuario.Apellido;
                datarespuesta.Usuario = usuario.NombreUsuario;
               
                datarespuesta.TipodeUsuarioEmpresa = usuario.TipodeUsuarioEmpresa;
                datarespuesta.TipodeUsuarioMaestro = usuario.TipodeUsuarioMaestro;
                datarespuesta.Permisos = _contex.MenuOpcionesUsuario.Where(a => a.IdUsuarios == usuario.Id).ToList();


            }


            return Ok(datarespuesta);
        }


        }

    public class OauthModel
    {
      public string guid { get; set; }
    }
}