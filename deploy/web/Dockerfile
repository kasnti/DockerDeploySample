FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY ./publish/ /app 
EXPOSE 80
ENTRYPOINT ["dotnet","WebApi.dll"]