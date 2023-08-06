using ApartmentManagementSystem.Entities;
using ApartmentManagementSystem.MsDbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApartmentManagementSystem.Controllers
{
    public class BillsController
    {
        //private readonly ManagementSystemDbContext _context;

        //public BillsController(ManagementSystemDbContext context)
        //{
        //    _context = context;
        //}

        //// List bills
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Bill>>> GetBills()
        //{
        //    return await _context.Bills.ToListAsync();
        //}

        //// create new bill
        //[HttpPost]
        //public async Task<IActionResult> CreateBill(Bill bill)
        //{
        //    _context.Bills.Add(bill);
        //    await _context.SaveChangesAsync();
        //    return Ok(bill);
        //}

        //// Fatura detaylarını getirme
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Bill>> GetBill(int id)
        //{
        //    var fatura = await _context.Bills.FindAsync(id);
        //    if (fatura == null)
        //        return NotFound();

        //    return fatura;
        //}

        //// Fatura güncelleme
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateFatura(int id, Bill bill)
        //{
        //    if (id != bill.BillId)
        //        return BadRequest();

        //    _context.Entry(bill).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FaturaExists(id))
        //            return NotFound();
        //        else
        //            throw;
        //    }

        //    return NoContent();
        //}

        //// Fatura silme
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteFatura(int id)
        //{
        //    var fatura = await _context.Bills.FindAsync(id);
        //    if (fatura == null)
        //        return NotFound();

        //    _context.Bills.Remove(fatura);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool FaturaExists(int id)
        //{
        //    return _context.Bills.Any(f => f.BillId == id);
        //}
    }

}
