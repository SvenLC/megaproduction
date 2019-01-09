# Base de données

## Versionnage

| Numéro | Date     | responsable | descriptif                   |
| ------ | -------- | ----------- | ---------------------------- |
| 1.2.0  | 09/01/19 | S. Le Cann  | Ajout MCD, MLD, choix techno |
| 1.1.0  | 14/11/18 | S. Le Cann  | Création du documet          |

## Choix technologiques

### Système de gestion de base de données

Nous avons choisi d'utiliser une base de données relationnel pour stocker les données de l'application. Le choix du système de gestion de base de données s'est porté sur SQL Server 2017.

Nous avons fait ce choix pour les raisons suivantes :

- Performance
- Très bonne intégration avec l'environnement .Net lors de la phase de prototypage
- Faible coût d'hébergement dans le cloud Azure de microsoft
- Compétences techniques de l'équipe
- Possibilité d'administration grace à l'outil Microsoft SQL Server Management Studio

### Outil de modélisation

Concernant la modélisation, notre choix s'est porté sur le logiciel JMerise. Il convient parfaitement à nos besoin sans être honéreux comparé à des solutions comme Power AMC. L'équipe ayant déjà utilisée ce logiciel, la compétence technique était acquise.

Ce logiciel nous a permis de réaliser la modélisation logique des données, ainsi que la modélisation physique des données, ainsi que la structure des tables.

### MCD

![MCD](../BDD/MGC_MCDv2.png)

-----------------------------------------------------------

### MLD

![MLD](../BDD/MGC_MLDv2.png)

### Règles de nommages

Nous avons fait le choix de normaliser le nommage des différentes tables ainsi que des champs en nous appuyant sur les travaux de Frédéric Brouard, MVP SQL Server, Enseignant aux Arts & Métiers et à l'ISEN Toulon et auteur du blog https://sqlpro.developpez.com

Le document de référence sur lequel nous nous somme appuyé se nomme "Norme interne de modélisation et développement Base de Données" disponible à cette adresse https://docplayer.fr/4959366-Norme-interne-de-modelisation-et-developpement-base-de-donnees.html

De ce document nous avons en principalement retenu les règles de nommage des tables et des champs. Ces règles s'articulent ainsi.

Un nom d’entité est composé comme suit :

- la lettre T
- un blanc souligné (underscore)
- une lettre parmi :
  - E pour entité,
  - R pour référence
  - S pour système
  - X pour référence externe
  - pour héritée
  - G pour générique
  - A pour administrative
  - H pour historique 
- un nom explicite jamais pluralisé, comprenant éventuellement des blancs soulignés
- un blanc souligné (underscore)
- le trigramme de l’entité

Exemple pour la table partenaire : T_E_PARTENAIRE_PART

Pour le champs ID on aura : PAR_ID

Ce nommage nous permet d'éviter le plus possible les risques de doublons dans les noms ainsi que de savoir juste en lisant le nom de la table à quoi elle correspond.

Nous avons aussi auto-documenté notre base de données en créant deux tables DBA_INFO et DBA_ADMIN

T_S_DATABASE_ADMIN_DBA

| Colonne | Type           | Longueur      | Oblig. | Validité                |
| ------- | -------------- | ------------- | ------ | ----------------------- |
| DBA_ID  | autoincrément  | DBA_DATEHEURE |        | horodatage              | par défaut dateheure courante |
| DBA_NOM | alphanumérique | 32            |        | nom, prénom utilisateur |


T_S_DATABASE_INFO_DBI

| Colonne     | Type           | Longueur | Oblig. | Validité                                                            |
| ----------- | -------------- | -------- | ------ | ------------------------------------------------------------------- |
| DBI_LIBELLE | alphanumérique | 128      | oui    | Clef                                                                |
| DBI_TYPE    | alphanumérique | 12       | oui    | 'alpha' , 'entier', 'réel', 'booléen', 'date', 'heure', 'dateheure' |
| DBI_VALEUR  | alphanumérique | 256      | oui    |

Ce qui donne par exemple :

| DBI_LIBELLE              | DBI_TYPE  | DBI_VALEUR               |
| ------------------------ | --------- | ------------------------ |
| Nom                      | alpha     | mabase                   |
| Date création            | date      | 20051125                 |
| SGBDR                    | alpha     | MS SQL Server 2017       |
| MCD                      | alpha     | MGC.mcd                  |
| MPD                      | alpha     | EPS_SQS2000.mpd          |
| Script                   | SQL alpha | EPS_SQS2000.sql          |
| Dernier script SQL diff. | alpha     | EPS_SQS2000_20051121.sql |
| Version base             | alpha     | 1.7                      |
| Langue                   | alpha     | Français                 |

### Hébergement

La base de données sera hébergé dans le cloud Microsoft Azure et bénificiera d'un contrôle d'accès par filtrage ip, pour qu'elle ne soit accessible que par l'API privée.