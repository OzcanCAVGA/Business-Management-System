
# Business Management System

Business Management System is a comprehensive application designed to streamline and manage various business operations. This project provides an efficient business management solution by enabling users to manage products and categories.


## Features

-   **Product Management**: Add, update, and delete products with detailed information.
-   **Category Management**: Organize products into categories and manage them effectively.
-   **Authentication**: Secure user login and authorization with JWT (JSON Web Token).
-   **API Documentation**: Explore and test API endpoints with integrated Swagger support.

## Technologies Used

-   **.NET 6**
-   **Entity Framework Core**
-   **Autofac**
-   **FluentValidation**
-   **Microsoft IdentityModel Tokens**
-   **Microsoft.AspNetCore.Authentication.JwtBearer**
-   **Swashbuckle (Swagger)**

## Project Structure

```md
Business-Management-System
│
├── Core/
│   ├── Utilities/
│   ├── Interceptors/
│   └── Extensions/
│
├── Business/
│   ├── Abstract/
│   ├── Concrete/
│   ├── DependencyResolvers/
│   └── ValidationRules/
│
├── DataAccess/
│   ├── Abstract/
│   ├── Concrete/
│   └── Migrations/
│
├── Entities/
│   ├── DTOs/
│   └── Models/
│
└── WebAPI/
    ├── Controllers/
    ├── Program.cs
    └── appsettings.json
```



## Architecture Overview

The project is designed using **layered architecture**, which separates concerns into distinct layers, making it scalable, maintainable, and testable.

### Project Structure

Here's a breakdown of each layer and its purpose:

#### Core

-   **Purpose**: Provides the foundational infrastructure and shared utilities used across other layers.
-   **Aspect-Oriented Programming (AOP)**:
    -   **Description**: The project uses **Aspect-Oriented Programming (AOP)** to handle cross-cutting concerns such as logging, caching, and validation. This is achieved using **Autofac.Extras.DynamicProxy** to intercept method calls and apply behaviors dynamically.
    -   **Example Use Cases**:
        -   Logging method execution details.
        -   Validating inputs using custom attributes.
        -   Implementing caching for expensive or repetitive operations.
-   **Directories**:
    -   `Utilities/`: Common helper functions and reusable components.
    -   `Interceptors/`: Handles cross-cutting concerns like logging or caching.
    -   `Extensions/`: Provides extension methods for improved functionality.
**Business**:

-   **Purpose**: Contains business logic and rules, ensuring that the core functionality of the application is both modular and maintainable.
    
-   **Aspect-Oriented Programming (AOP)**:
    
    -   **Description**: The business layer leverages **Aspect-Oriented Programming (AOP)** to handle cross-cutting concerns such as validation, logging, and caching dynamically. This is implemented using **Autofac.Extras.DynamicProxy**, which allows method calls to be intercepted and additional behaviors to be applied without altering the business logic.
    -   **Benefits**:
        -   Promotes separation of concerns by isolating cross-cutting logic from business rules.
        -   Reduces redundancy and enhances maintainability by centralizing shared behaviors.
    -   **Example Use Cases**:
        -   Validation logic is enforced dynamically before business methods execute.
        -   Logging or performance monitoring is applied across methods without modifying individual implementations.
        -   Caching mechanisms are added to reduce repetitive computations or database queries.
-   **Directories**:
    
    -   `Abstract/`: Interfaces defining business contracts, ensuring loosely coupled and testable components.
    -   `Concrete/`: Implementations of the business contracts that define the core business processes.
    -   `DependencyResolvers/`: Configures dependency injection for the application, including the setup of interceptors for AOP.
    -   `ValidationRules/`: Defines validation logic using **FluentValidation**, which works seamlessly with AOP to apply validations dynamically.
3.  **DataAccess**:
    
    -   **Purpose**: Manages database operations and interacts with the database.
    -   **Directories**:
        -   `Abstract/`: Interfaces for repository patterns.
        -   `Concrete/`: Implementations of the repositories using Entity Framework Core.
        -   `Migrations/`: Tracks database schema changes.
4.  **Entities**:
    
    -   **Purpose**: Defines the data models and DTOs (Data Transfer Objects) used throughout the application.
    -   **Directories**:
        -   `DTOs/`: Objects designed for data transfer between layers.
        -   `Models/`: Entity classes representing the database schema.
5.  **WebAPI**:
    
    -   **Purpose**: Exposes API endpoints to interact with the application.
    -   **Files**:
        -   `Controllers/`: Contains API endpoint implementations.
        -   `Program.cs`: Configures application startup.
        -   `appsettings.json`: Stores application configurations like database connections.

## Required Packages

**Core**
```bash
dotnet add Core package Autofac --version 8.1.1
dotnet add Core package Autofac.Extensions.DependencyInjection --version 10.0.0
dotnet add Core package Autofac.Extras.DynamicProxy --version 7.1.0
dotnet add Core package FluentValidation --version 11.10.0
dotnet add Core package Microsoft.AspNetCore.Http --version 2.1.34
dotnet add Core package Microsoft.Data.SqlClient --version 2.1.7
dotnet add Core package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.0
dotnet add Core package Microsoft.Extensions.Configuration.Binder --version 6.0.0
dotnet add Core package Microsoft.IdentityModel.Tokens --version 6.8.0
```

**Business**
```bash
dotnet add Business package Autofac --version 8.1.1
dotnet add Business package Autofac.Extensions.DependencyInjection --version 10.0.0
dotnet add Business package Autofac.Extras.DynamicProxy --version 7.1.0
dotnet add Business package FluentValidation --version 11.10.0
dotnet add Business package Microsoft.AspNetCore.Http --version 2.1.34
dotnet add Business package Microsoft.AspNetCore.Http.Abstractions --version 2.1.1
```

**DataAccess**
```bash
dotnet add DataAccess package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.0
dotnet add DataAccess package Microsoft.Data.SqlClient --version 2.1.7
```

**WebAPI**
```bash
dotnet add WebAPI package Microsoft.AspNetCore.Authentication.JwtBearer --version 6.0.8
dotnet add WebAPI package Swashbuckle.AspNetCore --version 6.5.0
dotnet add WebAPI package Microsoft.IdentityModel.Tokens --version 6.8.0
```

Below is the list of required packages for each layer, their versions, and how to install them:


## Setup and Running

1.  **Clone the Repository**:
    
	```bash
	git clone https://github.com/OzcanCAVGA/Business-Management-System.git
	cd Business-Management-System
	```    
2.  **Install Dependencies**:
    
    ```bash
    dotnet restore
    ```
    
3.  **Apply Database Migrations**:
    
	```bash
	dotnet ef database update
	```
4.  **Start the Application**:
    
	```bash
	dotnet run --project WebAPI
	```
    
5.  **Explore the API with Swagger**:
    
    -   Visit `http://localhost:5000/swagger` in your browser.


