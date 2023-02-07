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
    public class DeliveryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeliveryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Deliver
        [HttpGet]
        public async Task<IActionResult> GetDelivery()
        {
            var Deliver = await _unitOfWork.Delivery.GetAll(includes: q => q.Include(x =>x.Food).Include(x => x.Customer));
            return Ok(Deliver);
        }

        // GET: api/Deliveries/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDelivery(int id)
        {
            var Delivery = await _unitOfWork.Delivery.Get(q => q.Id == id);

            if (Delivery == null)
            {
                return NotFound();
            }

            return Ok(Delivery);
        }

        // PUT: api/Deliveries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDelivery(int id, Delivery Deliver)
        {
            if (id != Deliver.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Delivery.Update(Deliver);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await DeliveryExists(id))
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

        // POST: api/Deliveries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Delivery>> PostDelivery(Delivery Delivery)
        {
            await _unitOfWork.Delivery.Insert(Delivery);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetDelivery", new { id = Delivery.Id }, Delivery);
        }

        // DELETE: api/Deliveries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDelivery (int id)
        {
            var Delivery = await _unitOfWork.Delivery.Get(q => q.Id == id);
            if (Delivery == null)
            {
                return NotFound();
            }

            await _unitOfWork.Delivery.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> DeliveryExists(int id)
        {
            var Delivery = await _unitOfWork.Delivery.Get(q => q.Id == id);
            return Delivery != null;
        }
    }
}
