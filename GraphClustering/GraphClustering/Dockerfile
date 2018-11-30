FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 16679
EXPOSE 44302

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY GraphClustering/GraphClustering.csproj GraphClustering/
RUN dotnet restore GraphClustering/GraphClustering.csproj
COPY . .
WORKDIR /src/GraphClustering
RUN dotnet build GraphClustering.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish GraphClustering.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GraphClustering.dll"]
