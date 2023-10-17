FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CoffeeAPI/CoffeeAPI.csproj", "CoffeeAPI/"]
RUN dotnet restore "CoffeeAPI/CoffeeAPI.csproj"
COPY . .
WORKDIR "/src/CoffeeAPI"
RUN dotnet build "CoffeeAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoffeeAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoffeeAPI.dll"]
