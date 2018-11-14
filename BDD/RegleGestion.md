# Mega casting

## Règles de gestion

| Numéro | Date     | responsable | descriptif                     |
| ------ | -------- | ----------- | ------------------------------ |
| 1.2.0  | 14/11/18 | S. Le Cann  | Mise en page, ajouts de règles |
| 1.1.0  | 14/11/18 | S. Le Cann  | Ajout règles                   |
| 1.0.0  | 11/11/18 | B. Ragot    | Création du document           |

### Utilisateurs

- Un utilisateur a un et un seul compte
- Un utilisateur doit s'authentifier pour utiliser le client lourd
- Un utilisateur peut créer, modifier, valider, supprimer 0 ou plusieurs offres
- Un utilisateur peut créer, modifier, supprimer 0 ou plusieurs clients
- Un utilisateur peut créer, modifier, supprimer 0 ou plusieurs partenaires
- Un utilisateur peut créer, modifier, supprimer 0 ou plusieurs fiches adresse
- Un utilisateur peur créer, modifier, supprimer 0 ou plusieurs fiches de contact
- Un utilisateur peut être administrateur

### Administrateur

- Un administrateur est un utilisateur
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs utilisateurs
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs administrateurs
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs métiers
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs domaines de métiers
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs types de contrats
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs statuts juridiques
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs localisation

### Client

- Un client possède une et une seule adresse.
- Un client a un et un seul statut juridique
- Un client peut être lié à 0 ou plusieurs offres
- Un client peut être partenaire
- Un client peut être lié à 0 ou plusieurs fiches de contact
  
### Offre de casting

- Une offre de casting correspond à un et un seul client.
- Une offre de casting correspond a un et un seul métier
- Une offre de casting correspond à une et une seule localisation
- Une offre de casting peut être crée par un et un seul utilisateur
- Une offre de casting peut être modifier par un ou plusieurs utilisateurs
- Une offre de casting peut être validée par un ou plusieurs utilisateurs
- Une offre de casting peut être supprimé par un ou plusieurs utilisateurs
- Une offre de casting est lié à un et un seul métier
- Une offre de casting est lié à un et un seul domaine de métier
- Une offre de casting est lié à un et un seul type de contrat
- Une offre de casting a une et une seule localisation
- Une offre de casting correspond à une et une seule fiche de contact
- Une offre de casting publiée sur le site web est visible par tout le monde

### Partenaire

- Un partenaire de diffusion a un et un seul compte
- Un partenaire doit s'authentifier pour utiliser l'API
- Un partenaire de diffusuon peut récupérer la liste des offres à travers une API

### Listes de référentiels

- Un domaine de métier peut correspondre à plusieurs offres de casting
- Un domaine de métier peut correspondre à un ou plusieurs métiers
- Un métier peut correspondre à plusieurs offres de casting
- Un métier peut correspondre à plusieurs domaines de métiers
- Un statut juridique peut être rattaché à plusieurs clients ou partenaires.
- Une localisation peut être rattachée à plusieurs offres de casting ou adresse  
- Une adresse peut correspondre à plusieurs client.
- Une adresse a une et une seule localisation
- Si une adresse n'est lié à aucun client elle est supprimé
