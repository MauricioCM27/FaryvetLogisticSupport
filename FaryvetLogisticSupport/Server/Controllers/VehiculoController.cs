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
    public class VehiculoController : Controller
    {
        private readonly ApplicationDbContext context;

        public VehiculoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vehiculo>>> Get()
        {
            return await context.FLS_Vehiculos.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Vehiculo vehiculo)
        {
            context.Add(vehiculo);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerVehiculo", new { placa = vehiculo.placa }, vehiculo);
        }

        [HttpGet("{placa}", Name = "obtenerVehiculo")]
        public async Task<ActionResult<Vehiculo>> Get(string placa)
        {
            return await context.FLS_Vehiculos.FirstOrDefaultAsync(x => x.placa == placa);
        }
    }
}
