FROM microsoft/dotnet:sdk

COPY . ./

RUN dotnet restore
RUN dotnet publish -c Release -o ./app

WORKDIR src/ducktales.api/app

EXPOSE 5000
ENTRYPOINT ["dotnet", "ducktales.api.dll"]