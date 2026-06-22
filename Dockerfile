# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

COPY *.slnx .
COPY src/MyApp/*.csproj ./src/MyApp/
COPY tests/MyApp.Tests/*.csproj ./tests/MyApp.Tests/

RUN dotnet restore CicdLearning.slnx

COPY . .

RUN dotnet publish src/MyApp/MyApp.csproj -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "MyApp.dll"]