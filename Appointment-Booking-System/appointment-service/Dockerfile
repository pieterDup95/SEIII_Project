# BUILD STAGE
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy pre-downloaded packages
COPY nuget-packages /root/.nuget/packages

# Copy project files
COPY . .

# Restore using the pre-downloaded packages
RUN dotnet restore --no-cache --packages /root/.nuget/packages

# Publish
RUN dotnet publish -c Release -o /app/publish

# RUNTIME STAGE
FROM mcr.microsoft.com/dotnet/aspnet:8.0


# --- SET TIMEZONE TO SOUTH AFRICA ---
RUN apt-get update && apt-get install -y tzdata && \
    ln -fs /usr/share/zoneinfo/Africa/Johannesburg /etc/localtime && \
    dpkg-reconfigure -f noninteractive tzdata


WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "appointment-service.dll"]