using MUnitsConverter.Models;

namespace MUnitsConverter.Services
{
    /// <summary>
    /// Provides weight unit conversion services.
    /// </summary>
    /// <remarks>
    /// This service is responsible for converting weight measurements between different units
    /// such as kilograms, pounds, grams, ounces, and tons.
    /// </remarks>
    public interface IWeightConversionService
    {
        /// <summary>
        /// Converts a weight measurement from one unit to another.
        /// </summary>
        /// <param name="request">The conversion request containing the weight value, source unit, and target unit.</param>
        /// <returns>A <see cref="ConversionResponse"/> containing the converted weight and conversion metadata.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="request"/> is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the weight conversion cannot be performed.</exception>
        ConversionResponse Convert(ConversionRequest request);
    }
}
