using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IService.ItemServices;
using DDD.Domain.Interfaces.IService.OrderServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IAddOrderService _addOrder { get; set; }
        private IConsultOrderService _consultOrder { get; set; }
        private IUpdateOrderService _updateOrder { get; set; }

        private IUpdateItemService _updateItem { get; set; }

        public OrderController(IAddOrderService addOrder, IConsultOrderService consultOrder,
            IUpdateOrderService updateOrder, IUpdateItemService updateItem)
        {
            _addOrder = addOrder;
            _consultOrder = consultOrder;
            _updateOrder = updateOrder;

            _updateItem = updateItem;
        }

        //GET: api/v1/Order?id={id}
        [HttpGet]
        public IActionResult GetOrderId(int? id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Order Order = null;
            try
            {
                if (!id.HasValue)
                    return Ok(_consultOrder.ConsultOrderService());

                if (id.HasValue && id != 0)
                    Order = _consultOrder.ConsultOrderByIdService(Convert.ToInt32(id));

                if (Order != null)
                    return Ok(Order);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //PATCH: api/v1/Order/Id/{id}
        [HttpPatch("{id}")]
        public IActionResult PatchOrder([FromRoute] int id, [FromBody] Order Order)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                if (id != Order.Id)
                    return BadRequest();

                _updateOrder.UpdateOrderService(Order);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //POST: api/v1/Order
        [HttpPost]
        public IActionResult PostOrder([FromBody] Order Order)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var OrderFeito = _addOrder.AddOrderService(Order);
                return Ok(OrderFeito);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}