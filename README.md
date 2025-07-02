# Dating Application

👥 DatingApp – Full Stack Web Application with .NET 9 & Angular 20 This repository contains a production-grade full-stack application developed while following Neil Cummings’ course on modern web development. It features a robust .NET 9 backend API integrated with an Angular 20 frontend, leveraging Entity Framework Core for seamless data access and persistence.

## 🔧 Tech Stack Overview

> 1. Backend: ASP.NET Core 9 Web API
> 1. Frontend: Angular 20 SPA
> 1. Database: EF Core + SQL Server
> 1. Authentication: JWT-based Auth
> 1. Real-Time Communication: SignalR
> 1. UI Components: Angular Material

🚀 The project emphasizes clean architecture, secure authentication, rich user profiles, and scalable design patterns—ideal for full-stack developers aiming to sharpen practical skills.

🔗 Inspired by [Neil Cummings’ DatingApp course and source code](https://github.com/TryCatchLearn/DatingApp)

## How to create this solution

```powershell
dotnet --info

dotnet new list

dotnet sln -h
dotnet new sln

dotnet new webapi -controllers -n API -f net9.0
dotnet sln add .\src\API\

dotnet sln list
```
