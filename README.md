# Comandos importantes:

- Baixar imagem do MSSQL:
```shell
docker pull mcr.microsoft.com/mssql/server
```

- Subir o container do MSSQL:
```shell
docker run --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=SenhaForte123#" -p 1433:1433 -d mcr.microsoft.com/mssql/server
```
