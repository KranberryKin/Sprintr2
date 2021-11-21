FROM mcr.microsoft.com/dotnet/sdk:5.0
COPY ./Sprintr2/bin/Release/net5.0/publish/ App/
WORKDIR /App
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Sprintr2.dll
