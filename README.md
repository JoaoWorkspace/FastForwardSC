# FastForwardSC
A Shopping Center Website

## Launch SQL Server Docker Container

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Shopping!" -p 1433:1433 -d --name sqlserver mcr.microsoft.com/mssql/server:2022-latest
