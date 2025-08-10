FROM mcr.microsoft.com/dotnet/sdk:8.0

# Optional: basic tools you’ll likely want
RUN apt-get update && \
    apt-get install -y git ca-certificates curl && \
    rm -rf /var/lib/apt/lists/*

# Consistent working dir (matches devcontainer.json)
WORKDIR /FanxinPizza

# Speed up dotnet CLI in containers
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1 \
    DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1 \
    ASPNETCORE_URLS=http://0.0.0.0:5027

# Expose HTTP (use HTTP in dev to avoid cert setup)
EXPOSE 5027