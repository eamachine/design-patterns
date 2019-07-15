FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["DesignPatterns/DesignPatterns.csproj", "DesignPatterns/"]
RUN dotnet restore "DesignPatterns/DesignPatterns.csproj"
COPY . .
WORKDIR "/src/DesignPatterns"
RUN dotnet build "DesignPatterns.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DesignPatterns.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DesignPatterns.dll"]