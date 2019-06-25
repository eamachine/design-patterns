FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["BeverageMachine/BeverageMachine.csproj", "BeverageMachine/"]
RUN dotnet restore "BeverageMachine/BeverageMachine.csproj"
COPY . .
WORKDIR "/src/BeverageMachine"
RUN dotnet build "BeverageMachine.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BeverageMachine.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BeverageMachine.dll"]