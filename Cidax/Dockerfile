FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/GeoLocations.API/", "GeoLocations.API/"]
COPY ["src/GeoLocations.Application/", "GeoLocations.Application/"]
COPY ["src/GeoLocations.Domain/", "GeoLocations.Domain/"]
COPY ["src/GeoLocations.Infrastructure/", "GeoLocations.Infrastructure/"]
COPY ["src/Shared/", "Shared/"]
RUN dotnet restore "GeoLocations.API/GeoLocations.API.csproj"
WORKDIR "/src/GeoLocations.API"
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GeoLocations.API.dll"]