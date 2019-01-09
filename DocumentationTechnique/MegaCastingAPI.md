# MegaCastin API

## Choix technologique

### API

Backend Node.JS https://github.com/nodejs/node
ORM Sequalize https://github.com/sequelize/sequelize
Cloud azure
https://megacastingapi.azurewebsites.net

### Azure cloud

Paramètres de l'application

    WEBSITE_NODE_DEFAULT_VERSION
    8.11.1

### Intégration continue

Utilisation du service Serveur de builds Kudu App Service pour le déploiement automatique des applications nodejs dans azure directement à partir de repository github

### Base de données

SQL server, cloud azure
megacasting.database.windows.net

## Notice d'installation

<<<<<<< HEAD
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

=======
## Librairies node

### Sequelize-auto

Permet de créer automatiquement les models de données sequelize dans nodejs à partir d'une base de données

        sequelize-auto -o "./models" -d MEGACASTING -h megacasting.database.windows.net -u adminmegacasting -p 1433 -x t4tX38CwrHQJbDWkl2qr -e mssql -c config.json

Config.json

        {
            "host": "megacasting.database.windows.net",
            "dialect": "mssql",
            "dialectOptions": {
            "encrypt": true
            }
        }

### Tedious

Tedious est l'implémentation en javascript du Tabular Data Stream Protocol (TDS) de microsoft. C'est le protocole de comunication entre un client et une base de données relationel SQL Server

### bcrypt

Pour l'utilisation de bcrypt. Installer en administrateur les outils de développement de microsoft, Visual Studio Build Tools avec la commande

        npm install --global --production windows-build-tools

        node-gyp --python C:/Python27/
        npm config set python C:/Python27/python.exe

Ensuite installer l'addon Node.js node-gyp

        npm install -g node-gyp

switch vers bcryptjs

        https://www.npmjs.com/package/bcryptjs

Fonctionne en local
Fonctionne sur Azure

Bcrypt a trop de dépendance système tel que python 2.7 windows build tools, qui ne sont pas intégré de base sur azure. Installation non réussi. Avec Bcryptjs, il n'y a pas de dépendance. Fonctionne parfaitement.

### jsonwebtoken

        npm install --save jsonwebtoken

### MegaCasting Wiki

Déploiement d'un wiki à l'aide de wikijs sur l'hébergeur Heroku.

Documentation disponible ici -> https://github.com/Requarks/wiki

script de déploiement pour Heroku
>>>>>>> 43693d983931d88965b19356347e42c7743c5555
