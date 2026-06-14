using MUnitsConverter.Models;

namespace MUnitsConverter.Services
{
    /// <summary>
    /// Provides length unit conversion services.
    /// </summary>
    /// <remarks>
    /// This service is responsible for converting length measurements between different units.
    /// </remarks>
    public interface ILengthConversionService
    {
        /// <summary>
        /// Converts a length measurement from one unit to another.
        /// </summary>
        /// <param name="request">The conversion request containing the source value, source unit, and target unit.</param>
        /// <returns>A <see cref="ConversionResponse"/> containing the converted value and conversion metadata.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="request"/> is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the conversion cannot be performed.</exception>
        ConversionResponse Convert(ConversionRequest request);
    }
}
