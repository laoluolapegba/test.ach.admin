#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["services/admin/NuGet.Config", "services/admin/"]
COPY ["services/admin/host/IntelliPort.AdminService.HttpApi.Host/IntelliPort.AdminService.HttpApi.Host.csproj", "services/admin/host/IntelliPort.AdminService.HttpApi.Host/"]
COPY ["shared/IntelliPort.Shared.Hosting/IntelliPort.Shared.Hosting.csproj", "shared/IntelliPort.Shared.Hosting/"]
COPY ["services/admin/src/IntelliPort.AdminService.HttpApi/IntelliPort.AdminService.HttpApi.csproj", "services/admin/src/IntelliPort.AdminService.HttpApi/"]
COPY ["services/admin/src/IntelliPort.AdminService.Application.Contracts/IntelliPort.AdminService.Application.Contracts.csproj", "services/admin/src/IntelliPort.AdminService.Application.Contracts/"]
COPY ["services/admin/src/IntelliPort.AdminService.Domain.Shared/IntelliPort.AdminService.Domain.Shared.csproj", "services/admin/src/IntelliPort.AdminService.Domain.Shared/"]
COPY ["services/admin/src/IntelliPort.AdminService.EntityFrameworkCore/IntelliPort.AdminService.EntityFrameworkCore.csproj", "services/admin/src/IntelliPort.AdminService.EntityFrameworkCore/"]
COPY ["services/admin/src/IntelliPort.AdminService.Domain/IntelliPort.AdminService.Domain.csproj", "services/admin/src/IntelliPort.AdminService.Domain/"]
COPY ["services/admin/src/IntelliPort.AdminService.Application/IntelliPort.AdminService.Application.csproj", "services/admin/src/IntelliPort.AdminService.Application/"]
RUN dotnet restore "services/admin/host/IntelliPort.AdminService.HttpApi.Host/IntelliPort.AdminService.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/services/admin/host/IntelliPort.AdminService.HttpApi.Host"
RUN dotnet build "IntelliPort.AdminService.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IntelliPort.AdminService.HttpApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IntelliPort.AdminService.HttpApi.Host.dll"]