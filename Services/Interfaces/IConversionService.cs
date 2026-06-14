using MUnitsConverter.Models;

namespace MUnitsConverter.Services
{
    /// <summary>
    /// Defines a contract for unit conversion services.
    /// </summary>
    /// <remarks>
    /// Implementations of this interface provide functionality to convert measurements
    /// from one unit to another based on the conversion request parameters.
    /// </remarks>
    public interface IConversionService
    {
        /// <summary>
        /// Converts a measurement from one unit to another.
        /// </summary>
        /// <param name="request">The conversion request containing the value, source unit, and target unit.</param>
        /// <returns>A <see cref="ConversionResponse"/> containing the converted value and conversion details.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="request"/> is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the conversion cannot be performed with the provided parameters.</exception>
        ConversionResponse Convert(ConversionRequest request);
    }
}
