﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaryvetLogisticSupport.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FaryvetLogisticSupport.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacturaEspecialController : Controller
    {
        private readonly ApplicationDbContext context;

        public FacturaEspecialController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Factura>>> Get()
        {
            return await context.FLS_Facturas.Where(F => F.formaDespacho != "CAMION").ToListAsync();
        }
    }
}