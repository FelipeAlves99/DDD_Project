using System;
using System.Collections.Generic;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.IService.ItemServices;
using Microsoft.AspNetCore.Mvc;

namespace DDD.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private IAddItemService _addItem { get; set; }
        private IConsultItemService _consultItem { get; set; }
        private IDeleteItemService _deleteItem { get; set; }
        private IUpdateItemService _updateItem { get; set; }

        public ItemController(IAddItemService addItem, IConsultItemService consultItem,
            IDeleteItemService deleteItem, IUpdateItemService updateItem)
        {
            _addItem = addItem;
            _consultItem = consultItem;
            _deleteItem = deleteItem;
            _updateItem = updateItem;
        }

        //GET: api/v1/Item?id={id}
        [HttpGet]
        public IActionResult GetItem(int? id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                if (id.HasValue == false)
                    return Ok(_consultItem.ConsultItemService());

                if (id.HasValue && id != 0)
                    return Ok(_consultItem.ConsultItemIdService(Convert.ToInt32(id)));
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //PUT: api/v1/Item?id={id}
        [HttpPut]
        public IActionResult PutItem(int id, [FromBody] Item item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                if (id != item.Id)
                    return BadRequest();

                _updateItem.UpdateItemService(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //PATCH: api/v1/Item
        [HttpPatch]
        public IActionResult PatchPedido([FromBody] List<Item> item)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                _updateItem.UpdateStorageService(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //POST: api/v1/Item        
        [HttpPost]
        public IActionResult PostItem([FromBody] Item item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                _addItem.AddItemService(item);
                return Created("", item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //DELETE: api/v1/Item?id={id}
        [HttpDelete]
        public IActionResult DeleteItem(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                _deleteItem.DeleteItemByIdService(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}