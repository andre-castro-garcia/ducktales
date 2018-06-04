FROM microsoft/dotnet:sdk

COPY . ./

RUN dotnet restore
RUN dotnet publish -c Release -o ./app

WORKDIR src/ducktales.api/app

EXPOSE 5000
CMD dotnet ducktales.api.dll