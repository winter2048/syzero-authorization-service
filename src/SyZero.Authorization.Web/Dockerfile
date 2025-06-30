FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 5001
COPY . .
ENTRYPOINT ["dotnet", "SyZero.Authorization.Web.dll"]