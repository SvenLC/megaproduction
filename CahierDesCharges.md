# Cahier des charges

| Numéro | Date     | responsable | descriptif                        |
| ------ | -------- | ----------- | --------------------------------- |
| 1.0.0  | 16/10/18 | S. Le Cann  | Création du document              |
| 1.0.1  | 16/10/18 | S. Le Cann  | Rédaction des principales parties |
| 1.0.1  | 21/10/18 | B. Ragot    | Review et modification générales  |

## Contexte et problématiques

### Contexte

La société MégaProduction souhaite mettre en place un point de rencontre entre professionnels et artistes dans le cadre de la recherche de casting. Afin de répondre à ce souhait, ils veulent mettre en place une plateforme complète comprenant un backoffice de gestion des annonces, un site internet multi-support de consultation professionnel et digne de confiance et la mise à disposition d'un flux de casting.

Les équipes de MegaCastings effectue des recherches de casting au près d'un réseau de partenaire. Les professionnels souhaitant publier des annonces de casting seront contactés par les équipes de MegaCastings pour vérifier la véracité des informations fournies. Différentes formules tarifaires seront proposés sous la forme de pack de x Castings.

Les artistes souhaitant voir les annonces le feront via le site internet et contacteront les professionnel en direct. Les annonces seront crées par les équipes de MegaCastings à l'aide d'un client lourd. Un professionnel pourra récupérer ses annonces à travers un flux de casting.

### Problématiques

- Mises à disposition des annonces sur un site internet multi-plateforme
  - Mises en places d'un moteur de recherche.
- Mises à disposition d'un flux de casting pour les partenaires
  - Sécurisation de l'accès au flux par authentification.
- Gestion des castings à l'aide d'un client lourd
  - Afficher, ajouter, éditer, supprimer les clients, les partenaires de diffusion et les offres de castings d'une interface simple et intuitive
- Mises en place d'une base de donnée pour stocker
  - Des clients (organisations à la recherche d'artiste)
  - Des partenaires de diffusion
  - Des offres de casting
  - Des listes de référentiel(types de contrats, domaines de métiers, métiers)
- Importance du lien permanent entre les partenaires et megacasting quant à la diffusion des annonces.
- Traitement interne non-automatisé des annonces.

## Objectifs

- Mettre en place un client lourd accessible uniquement par les employés de l'équipe de MegaCasting et doit être simple et disponible sur tous les postes de la société.
- Les solutions doivent être ergonomique.
- Le site doit être seulement en consultation.
- Mise en place d'une API RestFull pour les partenaires.
- Mise en place d'un serveurWeb.
- Mise en place d'un serveur de base de données.

## Fonctionnalités détaillées

### Client lourd

Le client lourd doit permettre de réaliser les actions suivantes à l'aide d'un interface simple et intuitive :

- Gestion des clients
  - Ajouter
  - Afficher
  - Mettre à jour
  - Supprimer

- Gestion des partenaires de diffusions
  - Ajouter
  - Afficher
  - Mettre à jour
  - Supprimer

- Gestion des offres de castings
  - Ajouter
  - Afficher
  - Mettre à jour
  - Supprimer

- Gestion des listes de référentiels
  - Ajouter
  - Afficher
  - Mettre à jour
  - Supprimer

- Gestion du contenu éditorial
  - Ajouter
  - Mettre à jour
  - Supprimer

![Image 001](./src/img/alert.png)
    Ceci n'a rien à faire ici je pense.

Le client lourd doit être disponible sur tous les postes de la société et être adapté à un fonctionnement à long terme.

    Le client lourd permettra aussi de gérer le contenu éditorial du site web. (Fiches métiers, conseils, interview)

![Image 001](./src/img/alert.png)

    Tout ceci ne parles pas de fonctionnalité, ça regroupe des contraintes en autres et les fonctionnalités sont mal formulés.

## Client web

Le site internet doit dynamiquement exploiter la base de données de MegaCasting, afin de mettre en avant les offres de castings.
Le design doit être clair et intuitif et permettre de naviguer de façon adapté depuis tablette et mobile.

Les fiches de castings doivent faire paraitre en plus des informations relative au casting, les informations suivantes :

- URL du site internet du partenaire
- Email
- Téléphone
- Fax ou adresse postale

Ces informations sont publique et peuvent être visible par tout le monde.

Le site internet devra aussi intégrer un moteur de recherche qui permettra de rechercher rapidement les offres de castings qui correspondent aux profils des artistes.

Le site internet doit permettre de visualiser le contenu éditorial de megacasting.

## Serveur web

Le serveur web met à disposition des partenaires identifiés auprès de MegaCasting, un flux de diffusion qui reprendra toutes les informations relative aux fiches de castings. Ce flux sera fournis par une API REST sous format JSON et pourra être consommé par les partenaires de diffusions, afin de leur simplifier l'accès aux données.

![Image 001](./src/img/alert.png)

    Pour moi ça va dans l'analyse détaillé. Champs déplacé dans BDD dictionnaire.

## Serveur de base de données

La base de données, installé sur un serveur dédié doit être robuste et garantir l'intégrité des données.

Les données contenues dans la base de données contiendrons les informations suivantes :

### Différentes tables

- Clients
  - Dénomination
  - Statut juridique
  - adresse
  - numéro de téléphone
  - numéro de fax
  - adresse email
  - numéro de siret (Pour les entreprises)
  - numéro RNA (Associations)
  
- Partenaires de diffusions
  - Dénomination
  - Statut juridique
  - numéro de téléphone
  - numéro de fax
  - adresse email
  - Login
  - mots de passe
  
- Offres de castings
  - Intitulé
  - Référence
  - Domaine de métier
  - Métier
  - Type de contrat
  - Date de début de publication
  - Durée de diffusion
  - Date de début du contrat
  - Nombre de poste
  - Localisation
  - Description du poste
  - Description du profil recherché
  - Coordonnées
  - #Référentiels
  - #Client

- Listes de référentiels

- Contenu  éditorial
  - Fiches  métiers
  - Conseils
  - Interviews
