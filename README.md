# Dating Application

👥 **DatingApp** – Full Stack Web Application with .NET 9 & Angular 20

This repository contains a production-grade full-stack application developed while following Neil Cummings' course on modern web development. It features a robust .NET 9 backend API integrated with an Angular 20 frontend, leveraging Entity Framework Core for seamless data access and persistence.

## 🔧 Tech Stack Overview

> 1. Backend: ASP.NET Core 9 Web API
> 1. Frontend: Angular 20 SPA
> 1. Database: EF Core + SQL Server
> 1. Authentication: JWT-based Auth
> 1. Real-Time Communication: SignalR
> 1. UI Components: Angular Material

🚀 The project emphasizes clean architecture, secure authentication, rich user profiles, and scalable design patterns—ideal for full-stack developers aiming to sharpen practical skills.

### 🔗 Inspired by [Neil Cummings' `DatingApp` course and source code](https://github.com/TryCatchLearn/DatingApp)

## Prerequisites

- .NET 9.0 SDK
- Node.js 18+ (for Angular frontend)
- SQL Server or SQLite
- Visual Studio 2022 or VS Code

## Getting Started

1. Clone the repository
2. Navigate to the project directory
3. Restore dependencies: `dotnet restore`
4. Run the API: `dotnet run --project src/API`
5. Open browser to: `https://localhost:5001/scalar/v1` OR `https://localhost:5001/openapi/v1.json`

## Project Setup Instructions

```powershell
# Check .NET version
dotnet --info
dontnet -h

# List available templates
dotnet new list

# Create solution
dotnet sln -h
dotnet new sln

# Create API project with controllers
dotnet new webapi -controllers -n API -f net9.0 -o src/API
dotnet sln add src/API/

# List solution projects
dotnet sln list

# Restore packages
dotnet restore

# Run the application
dotnet watch --project .\src\API\
```

## Project Structure

```text
├── src/
│   ├── API/              # ASP.NET Core Web API
│   └── Client/           # Angular frontend (coming soon)
├── docs/                 # Documentation and images
│   └── images/           # Screenshots and diagrams
├── tests/               # Unit and integration tests
├── Directory.Build.props # Common build properties
├── Directory.Packages.props # Centralized package management
└── datingapp-course.sln # Solution file
```

## Features

- [ ] User Authentication & Authorization
- [ ] User Profiles & Photo Upload
- [ ] Real-time Messaging (SignalR)
- [ ] Matching Algorithm
- [ ] Like/Unlike Functionality
- [ ] Private Messaging
- [ ] Admin Panel
- [x] OpenAPI Documentation
- [x] Scalar API Explorer
- [x] Welcome Endpoint

## API Endpoints

### Available Endpoints

| Method | Endpoint           | Description         | Response                                     |
| ------ | ------------------ | ------------------- | -------------------------------------------- |
| GET    | `/`                | Welcome message     | JSON with message, timestamp, and request ID |
| GET    | `/weatherforecast` | Sample weather data | JSON array of weather forecasts              |

### API Documentation

> 1. [Open API Specification](https://localhost:7007/openapi/v1.json)
> 1. [Scalar API Explorer](https://localhost:7007/scalar/v1)

![Scalar UI](./docs/images/Scalar_UI.PNG)

### Welcome Endpoint Example

The root endpoint (`/`) returns a JSON response with the following structure:

```json
{
  "message": "Welcome to Dating App API",
  "timestamp": "2025-07-02T10:30:45.123Z",
  "requestId": "123e4567-e89b-12d3-a456-426614174000"
}
```

#### Testing the Welcome Endpoint

You can test the welcome endpoint using PowerShell:

```powershell
curl -k https://localhost:7007/ | ConvertFrom-Json | ConvertTo-Json -Depth 3
```

This endpoint demonstrates:

- **Modern .NET Minimal APIs** with proper OpenAPI documentation
- **Strongly-typed responses** using record types
- **Clean architecture** with separated endpoint definitions
- **Comprehensive API documentation** with Scalar UI

## Development

### HTTPS Development Certificate

Before running the API, ensure you have a valid HTTPS development certificate installed and trusted:

```powershell
# Check if a valid certificate exists
dotnet dev-certs https --check

# Check if the certificate is trusted
dotnet dev-certs https --check --trust

# If no certificate exists, create and trust one
dotnet dev-certs https --trust
```

Expected output for a properly configured certificate:

```text
PS D:\STSA\datingapp-course> dotnet dev-certs https --check
A valid certificate was found: 36667FA153D45489BE53860872D5F693E20C9577 - CN=localhost - Valid from 2024-12-27 23:03:40Z to 2025-12-27 23:03:40Z - IsHttpsDevelopmentCertificate: true - IsExportable: true
Run the command with both --check and --trust options to ensure that the certificate is not only valid but also trusted.

PS D:\STSA\datingapp-course> dotnet dev-certs https --check --trust
A trusted certificate was found: 36667FA153D45489BE53860872D5F693E20C9577 - CN=localhost - Valid from 2024-12-27 23:03:40Z to 2025-12-27 23:03:40Z - IsHttpsDevelopmentCertificate: true - IsExportable: true
```

### Running the API

```powershell
# Navigate to API project
cd src/API

# Run in development mode
dotnet run

# Or run with hot reload
dotnet watch run
```

The API will be available at:

- HTTPS: `https://localhost:7007`
- HTTP: `http://localhost:5228`

### Development API Documentation

- **OpenAPI Specification**: `/openapi/v1.json`
- **Scalar API Explorer**: `/scalar/v1` (Development only)

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- [Neil Cummings](https://github.com/TryCatchLearn) for the excellent course and guidance
- The .NET and Angular communities for their amazing tools and frameworks
