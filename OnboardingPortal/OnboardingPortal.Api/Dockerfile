FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OnboardingPortal.Api/OnboardingPortal.Api.csproj", "OnboardingPortal.Api/"]
RUN dotnet restore "OnboardingPortal.Api/OnboardingPortal.Api.csproj"
COPY . .
WORKDIR "/src/OnboardingPortal.Api"
RUN dotnet build "OnboardingPortal.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnboardingPortal.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnboardingPortal.Api.dll"]
