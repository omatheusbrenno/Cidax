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
        [ProducesResponseType(typeof(ResponseRegisteredLocationGeoJson), StatusCodes.Status201Created)]
        public IActionResult CreateLocation(RequestRegisterLocationGeoJson request)
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
        [ProducesResponseType(typeof(ResponseRegisteredLocationGeoJson), StatusCodes.Status204NoContent)]
        public IActionResult UpdateLocation(string id, RequestRegisterLocationGeoJson request)
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
