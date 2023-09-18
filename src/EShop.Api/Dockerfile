FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5233

ENV ASPNETCORE_URLS=http://+:5233

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["EShop.Api/EShop.Api.csproj", "EShop.Api/"]
COPY ["EShop.Application/EShop.Application.csproj", "EShop.Application/"]
COPY ["EShop.Contracts/EShop.Contracts.csproj", "EShop.Contracts/"]
COPY ["EShop.Domain/EShop.Domain.csproj", "EShop.Domain/"]
COPY ["EShop.Infrastructure/EShop.Infrastructure.csproj", "EShop.Infrastructure/"]
RUN dotnet restore "EShop.Api/EShop.Api.csproj"
COPY . .
WORKDIR "/src/EShop.Api"
RUN dotnet build "EShop.Api.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "EShop.Api.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EShop.Api.dll"]
