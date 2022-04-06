using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Showtime.Domain.Interfaces;
using Showtime.Domain.Entities;
using Showtime.Service.Validators;
using Showtime.Service.Services;
using System.Collections.Generic;

namespace Showtime.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private readonly IShowService _showService;

        public ShowController(IShowService showService)
        {
            _showService = showService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Show show)
        {
            if (show == null)
                return NotFound();

            return Execute(() => _showService.Add<ShowValidator>(show).Id);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Show show)
        {
            if (show == null)
                return NotFound();

            return Execute(() => _showService.Update<ShowValidator>(show).Id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(id==0)
                return NotFound();

            Execute(() =>
            {
                _showService.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var show = _showService.Get();
            return Execute(() => _showService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _showService.GetById(id));
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
