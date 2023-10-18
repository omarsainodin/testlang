# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /src
COPY . .
RUN dotnet restore "./WebApp na may About me/WebApp na may About me.csproj" --disable-parallel
RUN dotnet publish "./WebApp na may About me/WebApp na may About me.csproj" -c Release -o /app
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build-env /app ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "WebApp na may About me.dll"]