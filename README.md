# CoffeeShopPOS

CoffeeShopPOS is a .NET console simulation of a coffee shop ordering workflow. It models drink customization, brewing behavior, and order lifecycle transitions with small, focused classes.

## Features

- Order flow through taking order, preparation, payment, and pickup states
- Drink customization with decorators for milk, syrup, and whipped cream
- Brewer abstraction for manual and automatic preparation styles
- Simple console entry point for walking through a full order cycle

## Tech Stack

- C# 12
- .NET 8 console app

## Getting Started

```bash
dotnet restore
dotnet run --project CoffeeShopPOS/CoffeeShopPOS.csproj
```

## Project Structure

- `CoffeeShopPOS.sln`: Visual Studio solution
- `CoffeeShopPOS/`: application source
- `CoffeeShopPOS/Program.cs`: console entry point
