# Règles de gestion

## Versionnage

| Numéro | Date     | responsable | descriptif                     |
| ------ | -------- | ----------- | ------------------------------ |
| 1.4.0  | 09/01/18 | S. Le Cann  | Modifications des règles       |
| 1.3.0  | 15/11/18 | S. Le Cann  | Modifications des règles       |
| 1.2.0  | 14/11/18 | S. Le Cann  | Mise en page, ajouts de règles |
| 1.1.0  | 14/11/18 | S. Le Cann  | Ajout règles                   |
| 1.0.0  | 11/11/18 | B. Ragot    | Création du document           |


## Utilisateurs

- Un utilisateur a un et un seul compte
- Un utilisateur doit s'authentifier pour utiliser le client lourd
- Un utilisateur peut créer, modifier, valider, supprimer 0 ou plusieurs offres
- Un utilisateur peut créer, modifier, supprimer 0 ou plusieurs prospects
- Un utilisateur peut créer, modifier, supprimer 0 ou plusieurs clients
- Un utilisateur peut créer, modifier, supprimer 0 ou plusieurs partenaires
- Un utilisateur peut créer, modifier, supprimer 0 ou plusieurs fiches adresse
- Un utilisateur peur créer, modifier, supprimer 0 ou plusieurs fiches de contact
- Un utilisateur peut être administrateur

## Administrateur

- Un administrateur est un utilisateur
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs utilisateurs
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs administrateurs
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs métiers
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs domaines de métiers
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs types de contrats
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs statuts juridiques
- Un administrateur peut créer, modifier, supprimer 0 ou plusieurs localisation

## Prospect

- Un prospect peut être un client et/ou un partenaire.
- Un prospect est lié à une fiche de contact principale.
- Un prospect peut être lié à 1 ou plusieurs fiches de contact

## Client

- Un client possède une et une seule adresse.
- Un client a un et un seul statut juridique
- Un client peut être lié à 0 ou plusieurs offres
- Un client peut être partenaire

## Partenaire de diffusion

- Un partenaire de diffusion a un et un seul compte
- Un partenaire doit s'authentifier pour utiliser l'API
- Un partenaire de diffusuon peut récupérer la liste des offres à travers une API
  
## Offre de casting

- Une offre de casting correspond à une et une seule localisation
- Une offre de casting peut être crée par un et un seul utilisateur
- Une offre de casting peut être modifier par un ou plusieurs utilisateurs
- Une offre de casting peut être validée par un ou plusieurs utilisateurs
- Une offre de casting peut être supprimé par un ou plusieurs utilisateurs
- Une offre de casting correspond à un et un seul client
- Une offre de casting est liée à un et un seul métier
- Une offre de casting est liée à un et un seul type de contrat
- Une offre de casting est liée a une et une seule localisation
- Une offre de casting est liée a un et un seul contact
- Une offre de casting publiée sur le site web est visible par tout le monde

## Adresse et fiche contact

- Une adresse peut correspondre à plusieurs client.
- Une adresse a une et une seule localisation
- Si une adresse n'est lié à aucun client elle est supprimé
- Une fiche de contact est lié à un et un seul prospect
- Une fiche de contact peut être principale, c'est elle qui permet de contacter directement le prospect.

## Listes de référentiels

- Un domaine de métier peut correspondre à plusieurs offres de casting
- Un domaine de métier peut correspondre à un ou plusieurs métiers
- Un métier peut correspondre à plusieurs offres de casting
- Un domaine peut correspondre à plusieurs offres de casting
- Un métier correspond à un et un seul domaine de métiers
- Un statut juridique peut être rattaché à plusieurs clients ou partenaires.
