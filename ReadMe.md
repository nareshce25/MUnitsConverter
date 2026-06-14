# Measurement Units Converter

A comprehensive .NET 8 ASP.NET Core Web API for converting between different measurement units including length, temperature, and weight.

## Overview

Measurement Units Converter is a RESTful API built with .NET 8 and ASP.NET Core that provides conversion services between commonly used measurement units. The solution follows clean architecture principles with service interfaces, implementations, and controllers for maintainable and scalable code.

## Features

- **Length Conversion**: Convert between meters and feet
- **Temperature Conversion**: Convert between Celsius and Fahrenheit
- **Weight Conversion**: Convert between kilograms and pounds
- **Rate Limiting**: Built-in rate limiting to protect API endpoints
- **Swagger/OpenAPI**: Interactive API documentation and testing interface
- **Dependency Injection**: Loosely coupled, testable architecture

## 🏗 Architecture Diagram

```mermaid
flowchart TD
    A[Client Request] --> B[ConversionController]
    B -->|API Call| C[IConversionService]
    C --> D[ConversionService]

    D -->|Length & Weight| E[Conversion Factors Dictionary]
    D -->|Temperature| F[Temperature Conversion Logic]

    E --> G[ConversionResponse]
    F --> G[ConversionResponse]

    G --> H[Return JSON Response]


## Getting Started

### Prerequisites

- .NET 8 SDK or later
- Visual Studio 2022 (recommended)

### Installation

1. Clone the repository:
2. Restore dependencies:
3. Build the solution:
4. Run the application:

### API Endpoints
- `POST /api/convert/length`: Convert between meters and feet
- `POST /api/convert/temperature`: Convert between Celsius and Fahrenheit
- `POST /api/convert/weight`: Convert between kilograms and pounds
### Example Request
```json
{
  "value": 100,
  "fromUnit": "meters",
  "toUnit": "feet"
}
```
### Example Response
```json
{
  "convertedValue": 328.084,
  "fromUnit": "meters",
  "toUnit": "feet"
}
```
## Rate Limiting

The API implements rate limiting with the following default policy:
- **Limit**: 5 requests
- **Window**: 10 seconds
- **Queue Limit**: 2 queued requests

## API Documentation

Interactive Swagger/OpenAPI documentation is available at:

Use the Swagger UI to explore and test all available endpoints.

## Conversion Factors

- **Length**: 1 meter = 3.28084 feet
- **Temperature**: °F = (°C × 9/5) + 32
- **Weight**: 1 kilogram = 2.20462 pounds

## Technologies

- **.NET 8**: Latest long-term support framework
- **ASP.NET Core**: Web API framework
- **Swagger/OpenAPI**: API documentation
- **Rate Limiting**: Built-in middleware for request throttling

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is open source and available under the MIT License.

## Contact

For more information, visit the [GitHub repository](https://github.com/nareshce25/MeasurementUnitsConverter).
   