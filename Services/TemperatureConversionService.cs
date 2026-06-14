using MUnitsConverter.Enums;
using MUnitsConverter.Models;

namespace MUnitsConverter.Services
{
    public class TemperatureConversionService : ITemperatureConversionService
    {
        public ConversionResponse Convert(ConversionRequest request)
        {
            double result = 0;

            if (request.FromUnit.ToLower() == TemperatureCategoryEnum.CELSIUS.ToString().ToLower()
                && request.ToUnit.ToLower() == TemperatureCategoryEnum.FAHRENHEIT.ToString().ToLower())
            {
                result = (request.Value * 9 / 5) + 32;
            }
            else if (request.FromUnit.ToLower() == TemperatureCategoryEnum.FAHRENHEIT.ToString().ToLower()
                && request.ToUnit.ToLower() == TemperatureCategoryEnum.CELSIUS.ToString().ToLower())
            {
                result = (request.Value - 32) * 5 / 9;
            }
            else if (request.FromUnit.ToLower() == TemperatureCategoryEnum.CELSIUS.ToString().ToLower()
                && request.ToUnit.ToLower() == TemperatureCategoryEnum.KELVIN.ToString().ToLower())
            {
                result = request.Value + 273.15;
            }
            else if (request.FromUnit.ToLower() == TemperatureCategoryEnum.KELVIN.ToString().ToLower()
                && request.ToUnit.ToLower() == TemperatureCategoryEnum.CELSIUS.ToString().ToLower())
            {
                result = request.Value - 273.15;
            }
            else
            {
                return new ConversionResponse { Message = "Unsupported temperature conversion." };
            }

            return new ConversionResponse
            {
                ConvertedValue = result,
                Message = $"{request.Value} {request.FromUnit} = {result} {request.ToUnit}"
            };
        }

    }
}
