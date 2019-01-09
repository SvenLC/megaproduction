# API

## Choix technologique

### Nodejs

Pour la réalisation des API notre choix s'est porté sur la plateforme logiciel libre et événementielle Nodejs écrite en Javascript.

Nodejs intègre un serveur HTTP. Son fonctionnement est basé sur une boucle événementielle lui permettant de supporter de fortes montées en charge.

L’utilisation de Node.js en tant que serveur web permet de traiter un gros volume de requêtes simultanément de manière efficace. Cette performance élevée s’explique par une conception asynchrone (modèle non bloquant) permettant d’éviter les attentes. Ainsi, plusieurs requêtes peuvent être lancées en parallèle. Les résultats sont traités au fil de l'eau.

Node utilise le compilateur JavaScript V8 de Google focalisé sur les performances et la sécurité. A l'origine, la machine virtuelle V8 a été créée pour interpréter le JavaScript dans le navigateur Chrome. Merci aux développeurs de Google, le moteur V8 est et restera à la pointe de la technologie. Par ricochet, les progrès de V8 impactent directement Node.js.

Le gestionnaire de packages npm
Initialement gestionnaire de packages de Node.js, npm est aujourd'hui le gestionnaire de packages du monde JavaScript. On y trouve aussi bien des modules pour le backend que pour le frontend.

Les développeurs sont très actifs. Ils contribuent constament à l'amélioration des librairies Node.js au point d'en faire un problème à part entière : la JavaScript fatigue.

Npm compte aujourd'hui plus de 500 000 packages et le nombre ne cesse d'augmenter, bien plus rapidement que pour les autres langages.

Une technologie stable et éprouvée
Node.js n’est plus la petite dernière des technologies. C'est une techologie utilisée et éprouvée par les géants du web : Netflix, Trello, PayPal, LinkedIn, Walmart, Uber, Medium, Groupon, Ebay ou la NASA.

Ce support par les gros acteurs et cette politique de Long Term Support (LTS) donne à Node.js l'avantage d'être une technologie sûre et un bon choix sur l'avenir.

### 

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


