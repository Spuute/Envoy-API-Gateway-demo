FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /source
COPY . .
RUN dotnet restore "CoffeeAPI.csproj" --disable-parallel
RUN dotnet publish "CoffeeAPI.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /app
COPY --from=build /app ./

ENTRYPOINT ["dotnet", "CoffeeAPI.dll"]