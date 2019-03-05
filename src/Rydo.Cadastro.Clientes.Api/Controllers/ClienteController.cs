﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Rydo.Cadastro.Clientes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        public ClienteController()
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.CompletedTask;
            return Ok(new { id = Guid.NewGuid().ToString(), message = "Ping", create_at = DateTime.Now });
        }
    }
}
