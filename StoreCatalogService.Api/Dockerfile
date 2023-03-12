FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["StoreCatalogService.Api/StoreCatalogService.Api.csproj", "StoreCatalogService.Api/"]
RUN dotnet restore "StoreCatalogService.Api/StoreCatalogService.Api.csproj"
COPY . .
WORKDIR "/src/StoreCatalogService.Api"
RUN dotnet build "StoreCatalogService.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StoreCatalogService.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StoreCatalogService.Api.dll"]
