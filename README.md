# RaceDay-Part-Three
RaceDay – Event Management System

Project Overview

RaceDay is a web-based event management system developed using ASP.NET Core. It allows participants to browse and enrol in sporting events, while organisers can manage events and related information.

The system focuses on South African running, walking and cycling events.

Technologies Used

* C#
* ASP.NET Core Web API
* ASP.NET Core MVC
* .NET 8
* Entity Framework Core
* SQL Server
* Azure Blob Storage
* Swagger
* xUnit
* GitHub Actions
* Docker configuration

Main Features

* User registration and login.
* Role-based access for Organisers and Participants.
* Profile viewing and updating.
* Event browsing and management.
* Participant event enrolment.
* Event image uploads using Azure Blob Storage.
* RESTful API endpoints.
* Automated testing.

Project Structure

* RaceDay.API: Backend API and database operations.
* RaceDay.MVC: User-facing web application.
* RaceDay.Tests: Automated application tests.
* .github/workflows: GitHub Actions CI pipeline.

Setup Instructions

1. Clone the repository:
    git clone https://github.com/thatokhotsomofikwe/RaceDay-Part-Three.git
2. Open the solution in Visual Studio.
3. Configure the SQL Server connection string and Azure Blob Storage credentials using User Secrets.
4. Restore NuGet packages.
5. Build the solution.
6. Run the API and MVC projects.

Testing and CI

The project uses xUnit for automated testing and GitHub Actions for continuous integration.

The latest successful CI run confirms:

* API build: Passed.
* MVC build: Passed.
* Automated tests: 3 passed, 0 failed.

YouTube Link:
https://www.youtube.com/watch?v=TLMwAY2rvtk

Framework: .NET 8
Workflow:
<img width="1366" height="768" alt="image" src="https://github.com/user-attachments/assets/208ff089-e489-48e7-bf5b-de225d3e6ecd" />


