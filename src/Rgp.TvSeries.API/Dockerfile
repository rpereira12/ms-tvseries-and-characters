#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Rgp.TvSeries.API/Rgp.TvSeries.API.csproj", "Rgp.TvSeries.API/"]
COPY ["Rgp.TvSeries.Bootstrap/Rgp.TvSeries.Bootstrap.csproj", "Rgp.TvSeries.Bootstrap/"]
COPY ["Rgp.TvSeries.Application/Rgp.TvSeries.Application.csproj", "Rgp.TvSeries.Application/"]
COPY ["Rgp.TvSeries.CrossCutting/Rgp.TvSeries.CrossCutting.csproj", "Rgp.TvSeries.CrossCutting/"]
COPY ["Rgp.TvSeries.Core/Rgp.TvSeries.Core.csproj", "Rgp.TvSeries.Core/"]
COPY ["Rgp.TvSeries.Data/Rgp.TvSeries.Data.csproj", "Rgp.TvSeries.Data/"]
RUN dotnet restore "Rgp.TvSeries.API/Rgp.TvSeries.API.csproj"
COPY . .
WORKDIR "/src/Rgp.TvSeries.API"
RUN dotnet build "Rgp.TvSeries.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rgp.TvSeries.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rgp.TvSeries.API.dll"]