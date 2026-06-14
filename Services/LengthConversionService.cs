using MUnitsConverter.Common;
using MUnitsConverter.Models;

namespace MUnitsConverter.Services
{
    public class LengthConversionService : ILengthConversionService
    {
        public ConversionResponse Convert(ConversionRequest request)
        {
            var category = CommonHelper.ConversionFactors[request.Category.ToLower()];

            if (!category.ContainsKey(request.FromUnit.ToLower()) || !category.ContainsKey(request.ToUnit.ToLower()))
                return new ConversionResponse { Message = "Unsupported unit." };

            double baseValue = request.Value / category[request.FromUnit.ToLower()];
            double convertedValue = baseValue * category[request.ToUnit.ToLower()];

            return new ConversionResponse
            {
                ConvertedValue = convertedValue,
                Message = $"{request.Value} {request.FromUnit} = {convertedValue} {request.ToUnit}"
            };
        }
    }
}
