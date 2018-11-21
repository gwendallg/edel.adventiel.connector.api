FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ["Edel.Connector.Frontend.Api/Edel.Connector.Api.csproj", "Edel.Connector.Frontend.Api/"]
RUN dotnet restore "Edel.Connector.Frontend.Api/Edel.Connector.Api.csproj"
COPY . .
WORKDIR "/src/Edel.Connector.Frontend.Api"
RUN dotnet build "Edel.Connector.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Edel.Connector.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app

ARG DEFAULT_HOSTS="localhost:27017"
ARG DEFAULT_JWT_VALID_ISSUER="http://localhost"
ARG DEFAULT_JWT_VALID_AUDIENCE="http://localhost"
ARG DEFAULT_JWT_SECURITY_KEY="akaojodd-*koajide=-=-zkj"
ARG DEFAULT_DB_NAME="edel"
ARG DEFAULT_DB_USER="edel-connector"
ARG DEFAULT_DB_PASSWORD="edel-connector"
ARG DEFAULT_DB_OPTIONS=""

ENV HOSTS=$DEFAULT_HOSTS
ENV JWT_VALID_ISSUER=$DEFAULT_JWT_VALID_ISSUER
ENV JWT_VALID_AUDIENCE=$DEFAULT_JWT_VALID_AUDIENCE
ENV JWT_SECURITY_KEY=$DEFAULT_JWT_SECURITY_KEY
ENV DB_USER=$DEFAULT_DB_USER
ENV DB_PASSWORD=$DEFAULT_DB_PASSWORD
ENV DB_OPTIONS=$DEFAULT_DB_OPTIONS
ENV DB_NAME=$DEFAULT_DB_NAME

COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Edel.Connector.Api.dll"]