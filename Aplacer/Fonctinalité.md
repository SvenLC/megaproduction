# Mega casting Fonctionnalité

## Client lourd

### Difféfents acteurs

- Employé de MegaCasting

### Fonctionnalités

- Espace membre pour s'authentifier
- Gérer les prospects
  - Afficher
  - Ajouter
    - Faire devenir partenaire
    - Faire devenir client
    - Gérer les informations clients
    - Gérer les informations partenaires de diffusion
    - Gérer les informations utilisateurs
  - Éditer
    - Faire devenir partenaire
    - Faire devenir client
    - Gérer les informations clients
    - Gérer les informations partenaires de diffusion
    - Gérer les informations utilisateurs
  - Supprimer
- Gérer les utilisateurs
  - Afficher
  - Ajouter
  - Éditer
    - Rendre inactif
    - Passer en administrateur
  - Supprimer
- Gérer les offres des castings
  - Afficher
  - Ajouter
  - Éditer
  - Supprimer           
- Gérer le contenu éditorial
  - Gérer le contenu
    - Afficher
    - Ajouter
    - Éditer
    - Supprimer
- Gérer les listes de référentiel
  - Rechercher un type de contrat
  - Gérer les types de contrats
    - Afficher
    - Ajouter
    - Éditer
    - Supprimer
  - Gérer les métiers
    - Afficher
    - Ajouter
    - Éditer
    - Supprimer
  - Gérer les domaines de métier
    - Afficher
    - Ajouter
    - Éditer
    - Supprimer
  - Gérer les status juridiques
    - Afficher
    - Ajouter
    - Éditer
    - Supprimer


## Client léger

### Différents acteurs

### Fonctionnalités

- Visualiser les offres de casting
- Rechercher des offres de casting
- Visualiser le contenu éditorial  

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

- API publique
- API privée

### Fonctionnalités

- Stocker les données
  - Des clients (organisations à la recherche d’artiste)
  - Des partenaires de diffusion
  - Des offres de casting
  - Des listes de référentiel (types de contrat, domaines de métier, métiers, catégories ...)
  - contenu éditorial
  - adresses
  - contacts