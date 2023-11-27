using Libreria_DGGR.Data.Services;
using Libreria_DGGR.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Libreria_DGGR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private PublishersService _publisherService;
        public PublishersController(PublishersService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpPost("add-publisher")]
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            var newPublisher = _publisherService.AddPublisher(publisher);
            return Created(nameof(AddPublisher), newPublisher);
            //try
            //{
            //    var newPublisher = _publisherService.AddPublisher(publisher);
            //    return Created(nameof(AddPublisher), newPublisher);
            //}
            //catch (PublisherNameExceptions ex)
            //{
            //    return BadRequest($"{ex.Message}, Nombre de la editora: {ex.PublisherName}");
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
        }

        [HttpGet("get-publisher-by-id-/{id}")]
        public IActionResult GetPublisherById(int id)
        {
            var _response = _publisherService.GetPublisherByID(id);
            if (_response != null)
            {
                return Ok(_response);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("delete-publisher-by-id/{id}")]
        public IActionResult DeletePublisherById(int id)
        {
            try
            {
                _publisherService.DeletePublisherById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
