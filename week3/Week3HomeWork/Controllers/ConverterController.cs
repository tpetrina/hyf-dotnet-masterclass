using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Week3HomeWork.Models;

namespace Week3HomeWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConverterController : ControllerBase
    {
        [HttpGet("GallonsToLitres")]
        public double GallonsToLitres(int Litres)
        {
            return 0.264 * Litres;
        }

        [HttpGet("ConvertMiles")]
        public Distance ConvertMiles(int miles)
        {
            return new Distance { Miles = miles, Kilometers = miles * 1.609 };
        }

        [HttpPost("convert")]
        public List<ConversionResponse> ConvertValues([FromBody] ConversionRequest Request)
        {
            return new ConversionResponse().conversions(Request);
        }

    }
}
