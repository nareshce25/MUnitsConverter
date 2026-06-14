using MUnitsConverter.Enums;

namespace MUnitsConverter.Common
{
    public static class CommonHelper
    {
        public static Dictionary<string, Dictionary<string, double>> ConversionFactors =
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
    }
}
