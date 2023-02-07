using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryPRojectFull.Server.Data;
using FoodDeliveryPRojectFull.Shared.Domains;
using FoodDeliveryPRojectFull.Server.IRepository;

namespace FoodDeliveryPRojectFull.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesReportController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SalesReportController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/SalesReport
        [HttpGet]
        public async Task<IActionResult> GetSale()
        {
            var SalesReport = await _unitOfWork.SalesReport.GetAll(includes: q => q.Include(x =>x.Food).Include(x => x.Customer));
            return Ok(SalesReport);
        }

        // GET: api/SalesReport/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSale(int id)
        {
            var Sale = await _unitOfWork.SalesReport.Get(q => q.Id == id);
            if (Sale == null)
            {
                return NotFound();
            }
            return Ok(Sale);
        }

        // PUT: api/SalesReport/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSale(int id, SalesReport Sale)
        {
            if (id != Sale.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Sale.Update(Sale);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SaleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // POST: api/SalesReport
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SalesReport>> PostSale(SalesReport Sale)
        {
            await _unitOfWork.SalesReport.Insert(Sale);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSale", new { id = Sale.Id }, Sale);
        }

        // DELETE: api/SalesReport/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSale(int id)
        {
            var Sale = await _unitOfWork.Sale.Get(q => q.Id == id);
            if (Sale == null)
            {
                return NotFound();
            }

            await _unitOfWork.SalesReport.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SaleExists(int id)
        {
            var Sale = await _unitOfWork.Sale.Get(q => q.Id == id);
            return Sale != null;
        }
    }
}
