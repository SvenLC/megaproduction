# Mega casting Fonctionnalité

## Client lourd

### Difféfents acteurs

- Employé de MegaCasting

### Fonctionnalités

- Espace membre pour s'authentifier
- Rechercher un client
- Gérer les clients
  - Afficher
  - Ajouter
  - Éditer
  - Supprimer
- Rechercher un partenaire de diffusion
- Gérer les partenaires de diffusion
  - Afficher
  - Ajouter
  - Éditer
  - Supprimer
- Rechercher une offre de casting
- Gérer les offres des castings
  - Gérer les catégories
  - Gérer les offres
  - Afficher
  - Ajouter
  - Éditer
- Supprimer           
- Rechercher un contenu éditorial
- Gérer le contenu éditorial
  - Gérer les différents catégories
  - Gérer le contenu
    - Afficher
    - Ajouter
    - Éditer
    - Supprimer
- Recherche un membre
- Gérer les membres
  - Afficher
  - Ajouter
  - Éditer
    - Rendre inactif
    - Passer en administrateur
  - Supprimer
- Gérer les listes de référentiel
  - Rechercher un type de contrat
  - Gérer les types de contrats
    - Afficher
    - Ajouter
    - Éditer
    - Supprimer
  - Rechercher un métier
  - Gérer les métiers
    - Afficher
    - Ajouter
    - Éditer
    - Supprimer
  - Rechercher un domaine de métier
  - Gérer les domaines de métier
    - Afficher
    - Ajouter
    - Éditer
    - Supprimer
  - Recherher un status juridiques
  - Gérer les status juridiques
    - Afficher
    - Ajouter
    - Éditer
    - Supprimer

Le contenu éditorial est sous forme d'article, sauvegarde en base de donnée. Écrite au format normal et stockage convertit en html.

Ajout ?

- Administer le site web
- Visualiser les demandes de token
- Créer des comptes web pour les clients

## Client léger

### Différents acteurs

### Fonctionnalités

- Visualiser les offres de casting
- Rechercher des offres de casting
  - Filtré par catégorie les recherches
- Visualiser le contenu éditorial  

Ajout ?

- Moteur de recherche pour le contenu éditorial
- Créer un compte (postulant)
- Répondre à une offre de casting
- Mise à disposition d'un sous-domaine pour l'API
  - Affichage des documentations utilisateurs pour les flux json client.
  - Demande d'un nouveau token.
- Mise à disposition d'un espace d'administration simple
  - Permet de modifier les pages statiques du site
  - Administrer le sous domaine de l'API

## API/Service

### API partenaire

#### Différents acteurs

- partenaire

#### Fonctionnalités

- Récupérer les flux de castings
- Authentifier un utilsateur

### API privée

#### Différents acteurs

- client léger
- client lourd

#### Fonctionnalités
- Permettre d'intéragir avec la base de donnée
- Authentifier un utilsateur

## Base de donnée

### Différents acteurs

- client léger
- client lourd

### Fonctionnalités

- Stocker les données
  - Des clients (organisations à la recherche d’artiste)
  - Des partenaires de diffusion
  - Des offres de casting
  - Des listes de référentiel (types de contrat, domaines de métier, métiers, catégories ...)
  - contenu éditorial