FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY ["./$(build.artifactstagingdirectory)", "."]
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "fh-family-experience-web.dll"]