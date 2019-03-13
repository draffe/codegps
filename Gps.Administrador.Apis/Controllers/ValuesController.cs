﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Gps.BasedeDatos.BasedeDatos;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Gps.Administrador.Apis.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private SqlServerAplicationContext _context;

        public ValuesController(SqlServerAplicationContext context)
        {
            _context = context;
        }


        // GET api/values
        //[HttpGet, Authorize]
        [HttpGet]
        [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
        public IEnumerable<string> Get()
        {
        

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
