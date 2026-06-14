using MUnitsConverter.Enums;
using MUnitsConverter.Models;

namespace MUnitsConverter.Services
{
    public class ConversionService : IConversionService
    {
        private readonly Dictionary<string, Dictionary<string, double>> conversionFactors =
            new Dictionary<string, Dictionary<string, double>>
            {
                { CategoryEnum.LENGTH.ToString().ToLower(), new Dictionary<string, double>
                    {
                        { LengthCategoryEnum.METER.ToString().ToLower(), 1.0 }, // 1 Meter = 1 Meter
                        { LengthCategoryEnum.FOOT.ToString().ToLower() , 3.28084 }, // 1 Meter = 3.28084 Feet
                        { LengthCategoryEnum.KILOMETER.ToString().ToLower() , 0.001 }, // 1 Meter = 0.001 Kilometers
                        { LengthCategoryEnum.MILE.ToString().ToLower() , 0.000621371 } // 1 Meter = 0.000621371 Miles
                    }
                },
                { CategoryEnum.WEIGHT.ToString().ToLower(), new Dictionary<string, double>
                    {
                        { WeightCategoryEnum.KILOGRAM.ToString().ToLower(), 1.0 }, // 1 Kilogram = 1 Kilogram
                        { WeightCategoryEnum.POUND.ToString().ToLower(), 2.20462 }, // 1 Kilogram = 2.20462 Pounds
                        { WeightCategoryEnum.GRAM.ToString().ToLower(), 1000.0 } // 1 Kilogram = 1000 Grams
                    }
                }
            };

        public ConversionResponse Convert(ConversionRequest request)
        {
            if (request.Category.ToLower() == CategoryEnum.TEMPERATURE.ToString().ToLower())
            {
                return ConvertTemperature(request);
            }

            if (!conversionFactors.ContainsKey(request.Category.ToLower()))
                return new ConversionResponse { Message = "Unsupported category." };

            var category = conversionFactors[request.Category.ToLower()];

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

        private ConversionResponse ConvertTemperature(ConversionRequest request)
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
