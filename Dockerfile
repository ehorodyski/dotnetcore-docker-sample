FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore dotnet-example.csproj
COPY . ./
RUN dotnet publish dotnet-example.csproj -c Release -o out
FROM microsoft/dotnet:2.2-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "dotnet-example.dll"]