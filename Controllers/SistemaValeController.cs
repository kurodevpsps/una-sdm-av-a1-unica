using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ValeAtivos324261675.Models;
using ValeAtivos324261675.Data;
using SQLitePCL;


namespace ValeAtivos324261675.Controllers
{[Route("api/[controller]")]
[ApiController]
public class SistemaValeController : ControllerBase
{
    private readonly AppDbContext _context;

    public SistemaValeController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Equipamento>>> GetCaracteristicasEquipamentos ()
    {
        return await _context.CaracteristicasEquipamentos.ToListAsync();
    }

    [HttpGet("{nome}")]
    public async Task<ActionResult<Equipamento>> GetEquipamento(string nome)
    {
        var equipamento = await _context.CaracteristicasEquipamentos.FindAsync(nome);
        if (equipamento == null) return NotFound();
        return equipamento;

    }

    [HttpPost]
    public async Task<ActionResult<Equipamento>> PostEquipamento(Equipamento equipamento)
    {
        _context.CaracteristicasEquipamentos.Add(equipamento);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetEquipamento), new {id = equipamento.Id}, equipamento);
    }
}}