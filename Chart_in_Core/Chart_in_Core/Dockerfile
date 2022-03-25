#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Chart_in_Core/Chart_in_Core.csproj", "Chart_in_Core/"]
RUN dotnet restore "Chart_in_Core/Chart_in_Core.csproj"
COPY . .
WORKDIR "/src/Chart_in_Core"
RUN dotnet build "Chart_in_Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Chart_in_Core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Chart_in_Core.dll"]