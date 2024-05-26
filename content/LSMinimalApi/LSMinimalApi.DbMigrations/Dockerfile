FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["LSMinimalApi.DbMigrations/LSMinimalApi.DbMigrations.csproj", "LSMinimalApi.DbMigrations/"]
RUN dotnet restore "LSMinimalApi.DbMigrations/LSMinimalApi.DbMigrations.csproj"
COPY . .
WORKDIR "/src/LSMinimalApi.DbMigrations"
RUN dotnet build "LSMinimalApi.DbMigrations.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "LSMinimalApi.DbMigrations.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LSMinimalApi.DbMigrations.dll"]
