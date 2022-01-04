using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Showtime.Domain.Interfaces;
using Showtime.Domain.Entities;
using Showtime.Service.Validators;

namespace Showtime.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private IBaseService<Show> _baseShowService;

        public ShowController(IBaseService<Show> baseShowService)
        {
            _baseShowService = baseShowService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Show show)
        {
            if (show == null)
                return NotFound();

            return Execute(() => _baseShowService.Add<ShowValidator>(show).Id);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Show show)
        {
            if (show == null)
                return NotFound();

            return Execute(() => _baseShowService.Update<ShowValidator>(show).Id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(id==0)
                return NotFound();

            Execute(() =>
            {
                _baseShowService.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _baseShowService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseShowService.GetById(id));
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
