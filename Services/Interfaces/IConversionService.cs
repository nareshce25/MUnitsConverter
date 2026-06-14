using MUnitsConverter.Models;

namespace MUnitsConverter.Services
{
    public interface IConversionService
    {
        ConversionResponse Convert(ConversionRequest request);
    }
}
