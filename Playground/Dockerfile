FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Playground/Playground.csproj", "Playground/"]
RUN dotnet restore "Playground/Playground.csproj"
COPY . .
WORKDIR "/src/Playground"
RUN dotnet build "Playground.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Playground.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Playground.dll"]
