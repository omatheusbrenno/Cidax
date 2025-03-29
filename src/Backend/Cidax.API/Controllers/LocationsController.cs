using Cidax.Communication.Requests;
using Cidax.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cidax.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterLocationJson), StatusCodes.Status201Created)]
        public IActionResult CreateLocation(RequestRegisterLocationJson request)
        {
            return Created();
        }

        [HttpGet]
        public IActionResult GetAllLocations()
        {
            return Ok();
        }

        [HttpGet("geojson")]
        public IActionResult GetLocationsAsGeoJson()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetLocationById(string id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ResponseUpdateLocationJson), StatusCodes.Status204NoContent)]
        public IActionResult UpdateLocation(string id, ResquestUpdateLocationJson request)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLocation(string id)
        {
            return NoContent();
        }
    }
}
