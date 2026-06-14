using MUnitsConverter.Models;

namespace MUnitsConverter.Services
{
    public class ConversionService : IConversionService
    {
        private readonly ILengthConversionService _lengthConversionService;
        private readonly ITemperatureConversionService _temperatureConversionService;
        private readonly IWeightConversionService _weightConversionService;
        public ConversionService(
            ILengthConversionService lengthConversionService,
            ITemperatureConversionService temperatureConversionService, 
            IWeightConversionService weightConversionService)
        {
            _lengthConversionService = lengthConversionService;
            _temperatureConversionService = temperatureConversionService;
            _weightConversionService = weightConversionService;
        }
        public ConversionResponse Convert(ConversionRequest request)
        {
            switch (request.Category.ToLower())
            {
                case "temperature":
                    return _temperatureConversionService.Convert(request);
                case "length":
                    return _lengthConversionService.Convert(request);
                case "weight":
                    return _weightConversionService.Convert(request);
                default:
                    return new ConversionResponse { Message = "Unsupported category." };
            }
        }

    }
}
