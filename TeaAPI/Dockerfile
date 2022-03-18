FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /source
COPY . .
RUN dotnet restore "TeaAPI.csproj" --disable-parallel
RUN dotnet publish "TeaAPI.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /app
COPY --from=build /app ./
ENV ASPNETCORE_URLS=http://+11111
ENV ASPNETCORE_ENVIRONMENT=Development

ENTRYPOINT ["dotnet", "TeaAPI.dll"]