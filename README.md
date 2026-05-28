# Squirrel API

A .NET Core Web API for managing bank customer information.

## Project Overview

This is a RESTful API built with .NET Core for the Squirrel Bank management system. It provides endpoints to manage customer information including customer lists, details, and operations.

## Features

- Get list of all customers
- Customer data with: ID, Full Name (HoTen), Email, Phone Number (SoDienThoai)
- Pre-loaded with 5 sample customers
- Docker support for containerized deployment

## Sample Customers

1. Nguyễn Văn A - nguyenvana@example.com - 0901234567
2. Trần Thị B - tranthib@example.com - 0902345678
3. Lê Văn C - levanc@example.com - 0903456789
4. Phạm Thị D - phamthid@example.com - 0904567890
5. Hoàng Văn E - hoangvane@example.com - 0905678901

## API Endpoints

### Get All Customers
- **URL**: `/api/customer`
- **Method**: `GET`
- **Response**: Returns JSON array of all customers

## Running the Application

### Local Development
```bash
cd SquirrelAPI
dotnet restore
dotnet run
```

### Docker
```bash
docker build -t squirrel-api .
docker run -p 80:80 -p 443:443 squirrel-api
```

## Technology Stack

- .NET Core 10.0
- ASP.NET Core Web API
- Docker

## Author

HangVuZxjv
