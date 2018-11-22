# MegaCastin API

## Choix technologique

### API

Backend Node.JS https://github.com/nodejs/node
ORM Sequalize https://github.com/sequelize/sequelize
Cloud azure
https://megacastingapi.azurewebsites.net

### Base de données

SQL server, cloud azure
megacasting.database.windows.net

## Notice d'installation

https://vmokshagroup.com/blog/building-restful-apis-using-node-js-express-js-and-ms-sql-server
https://medium.freecodecamp.org/how-to-deploy-your-super-cool-node-app-to-azure-from-github-47ebff6c5448

### ORM

Sequelize
https://github.com/sequelize/sequelize
Import des models en utilisant sequelize-auto
https://github.com/sequelize/sequelize-auto

sequelize-auto  -c './config.json' -o './models' -d MEGACASTING -h megacasting.database.windows.net -u adminmegacasting  -x t4tX38CwrHQJbDWkl2qr

fichier config.json
{
  "host": "megacasting.database.windows.net",
  "dialect": "mssql",
  "dialectOptions": {
    "encrypt": true
  }
}

