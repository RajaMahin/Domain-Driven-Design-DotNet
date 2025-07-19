# Domain-Driven Design with ASP.NET Core
![DDDD](https://github.com/user-attachments/assets/782c2893-819a-4d8c-8dd1-6a44f5b8d86f)

This repository contains my hands-on implementation of Domain-Driven Design (DDD) concepts while following the [LinkedIn Learning Course on DDD] 

The goal is to reinforce my understanding by building a clean, modular, and maintainable application based on DDD principles in ASP.NET Core.

Each and every branch contains the topic section wise code. 

## ✅ Topics Covered

- DDD fundamentals: Entities, Value Objects, Aggregates, Repositories
- Clean architecture layers: Domain, Application, Infrastructure, Presentation
- Entity Framework Core with rich domain models
- Domain Events and Ubiquitous Language
- Bounded Contexts and Aggregates

## 📦 Technologies Used

- ASP.NET Core Web API
- C# 12
- Entity Framework Core
- SQL Server
- xUnit for testing

## 🧠 What I Learned

- Structuring projects with DDD patterns
- Applying tactical design (Aggregates, Value Objects)
- Building testable and decoupled applications
- Using domain events to capture business behavior

## 📂 Project Structure

- `Domain`: Core business logic
- `Application`: Use cases and services
- `Infrastructure`: Data access & implementations
- `WebAPI`: REST endpoints

## 🚀 Getting Started

To run the project:
1. Clone the repo
2. Update connection string
3. Run migrations
4. Launch Web API

```bash
dotnet ef database update
dotnet run
