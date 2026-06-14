using MUnitsConverter.Models;

namespace MUnitsConverter.Services
{
    /// <summary>
    /// Provides temperature unit conversion services.
    /// </summary>
    /// <remarks>
    /// This service is responsible for converting temperature measurements between different temperature scales
    /// such as Celsius, Fahrenheit, and Kelvin.
    /// </remarks>
    public interface ITemperatureConversionService
    {
        /// <summary>
        /// Converts a temperature measurement from one scale to another.
        /// </summary>
        /// <param name="request">The conversion request containing the temperature value, source scale, and target scale.</param>
        /// <returns>A <see cref="ConversionResponse"/> containing the converted temperature and conversion metadata.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="request"/> is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the temperature conversion cannot be performed.</exception>
        ConversionResponse Convert(ConversionRequest request);
    }
}
