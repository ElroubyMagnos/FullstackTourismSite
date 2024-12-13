using boardingdata;
using boardingdata.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoardItalicProj.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeaderController : ControllerBase
    {
        private readonly ILogger<HeaderController> _logger;

        public HeaderController(ILogger<HeaderController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetHeaderSlideImages")]
        public async Task<HeaderSliderImage[]> GetHeaderSlideImages()
        {
            var boarding = new boarding();

            return await boarding.SliderImages.ToArrayAsync();
        }

        [HttpGet("GetWCU")]
        public async Task<WCUBox[]> GetWCU()
        {
            var boarding = new boarding();

            return await boarding.WCUBoxs.ToArrayAsync();
        }

        [HttpGet("GetTravels")]
        public async Task<Travel[]> GetTravels()
        {
            var boarding = new boarding();

            return await boarding.Travels.ToArrayAsync();
        }
    }
}
