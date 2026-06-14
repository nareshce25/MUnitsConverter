using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MUnitsConverter.Models;
using MUnitsConverter.Services;

namespace MUnitsConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _conversionService;

        public ConversionController(IConversionService conversionService)
        {
            _conversionService = conversionService;
        }

        /// <summary>
        /// Converts a value from one unit to another.
        /// </summary>
        /// <remarks>
        /// Example request:
        ///
        ///     POST /api/conversion/convert
        ///     {
        ///        "value": 10,
        ///        "fromUnit": "meter",
        ///        "toUnit": "foot",
        ///        "category": "length"
        ///     }
        ///
        /// Example response:
        ///
        ///     {
        ///        "convertedValue": 32.8084,
        ///        "message": "10 meter = 32.8084 foot"
        ///     }
        ///
        /// </remarks>
        /// <param name="request">Conversion request object</param>
        /// <returns>Converted value and message</returns>
        /// <response code="200">Returns the converted value</response>
        /// <response code="400">If the request is invalid</response>
        [HttpPost("convert")]
        public IActionResult Convert([FromBody] ConversionRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request.");
            }
            var response = _conversionService.Convert(request);
            return Ok(response);
        }
    }
}
