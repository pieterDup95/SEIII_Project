# BUILD STAGE
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy pre-downloaded packages from host
COPY nuget-packages /root/.nuget/packages


#COPY /certs/ /usr/local/share/ca-certificates/
#RUN cat /usr/local/share/ca-certificates/* >> /etc/ssl/certs/ca-certificates.crt

# Copy your project files
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

# -------------------------------------


WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "appointment-service.dll"]

#docker-compose build --no-cache
#docker-compose up



#wsl --unregister rancher-desktop
#wsl -d rancher-desktop-data