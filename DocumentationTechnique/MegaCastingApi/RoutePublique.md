# Route API publique

## Offre castings

| URL                          | Méthode | Body  | Réponse               |
| ---------------------------- | ------- | ----- | --------------------- |
| /offrecastings               | GET     |       | Liste d'offre         |
| /offrecastings               | POST    | Offre | Offre                 |
| /offrecastings/{id}          | GET     |       | Offre                 |
| /offrecastings/{id}          | PUT     | Offre | Offre                 |
| /offrecastings/{id}          | DEL     |       | Offre                 |
| /offrecastings/formated      | GET     |       | Liste d'offre formaté |
| /offrecastings/formated/{id} | GET     |       | Liste d'offre formaté |

## Adresse

| URL           | Méthode | Body    | Réponse         |
| ------------- | ------- | ------- | --------------- |
| /adresses     | GET     |         | Liste d'adresse |
| /adresses     | POST    | Adresse | Adresse         |
| /adresses{id} | GET     |         | Adresse         |
| /adresses{id} | PUT     | Adresse | Adresse         |
| /adresses{id} | DEL     |         | Adresse         |

## Client

| URL          | Méthode | Body   | Réponse         |
| ------------ | ------- | ------ | --------------- |
| /Clients     | GET     |        | Liste de client |
| /Clients     | POST    | Client | Client          |
| /Clients{id} | GET     |        | Client          |
| /Clients{id} | PUT     | Client | Client          |
| /Clients{id} | DEL     |        | Client          |

## Contrat

| URL           | Méthode | Body    | Réponse         |
| ------------- | ------- | ------- | --------------- |
| /Contrats     | GET     |         | Liste de client |
| /Contrats     | POST    | Contrat | Contrat         |
| /Contrats{id} | GET     |         | Contrat         |
| /Contrats{id} | PUT     | Contrat | Contrat         |
| /Contrats{id} | DEL     |         | Contrat         |

## Contact

| URL           | Méthode | Body    | Réponse          |
| ------------- | ------- | ------- | ---------------- |
| /contacts     | GET     |         | Liste de contact |
| /contacts     | POST    | Contact | Contact          |
| /contacts{id} | GET     |         | Contact          |
| /contacts{id} | PUT     | Contact | Contact          |
| /contacts{id} | DEL     |         | Contact          |

## Domaine de métiers

| URL                 | Méthode | Body            | Réponse                     |
| ------------------- | ------- | --------------- | --------------------------- |
| /domaineMetiers     | GET     |                 | Liste de domaine de metiers |
| /domaineMetiers     | POST    | Domaine Metiers | Domaine de metiers          |
| /domaineMetiers{id} | GET     |                 | Domaine de metiers          |
| /domaineMetiers{id} | PUT     | Domaine Metiers | Domaine de metiers          |
| /domaineMetiers{id} | DEL     |                 | Domaine de metiers          |

## Localisation

| URL               | Méthode | Body         | Réponse                |
| ----------------- | ------- | ------------ | ---------------------- |
| /Localisation     | GET     |              | Liste de localisations |
| /Localisation     | POST    | Localisation | Localisation           |
| /Localisation{id} | GET     |              | Localisation           |
| /Localisation{id} | PUT     | Localisation | Localisation           |
| /Localisation{id} | DEL     |              | Localisation           |

## Métier

| URL          | Méthode | Body   | Réponse         |
| ------------ | ------- | ------ | --------------- |
| /metiers     | GET     |        | Liste de metier |
| /metiers     | POST    | Metier | Metier          |
| /metiers{id} | GET     |        | Metier          |
| /metiers{id} | PUT     | Metier | Metier          |
| /metiers{id} | DEL     |        | Metier          |

## Partenaire

| URL              | Méthode | Body       | Réponse              |
| ---------------- | ------- | ---------- | -------------------- |
| /partenaires     | GET     |            | Liste de partenaires |
| /partenaires     | POST    | Partenaire | Partenaire           |
| /partenaires{id} | GET     |            | Partenaire           |
| /partenaires{id} | PUT     | Partenaire | Partenaire           |
| /partenaires{id} | DEL     |            | Partenaire           |

## Prospect

| URL                    | Méthode | Body     | Réponse           |
| ---------------------- | ------- | -------- | ----------------- |
| /Prospect              | GET     |          | Liste de prospect |
| /Prospect              | POST    | Prospect | Prospect          |
| /Prospect{id}          | GET     |          | Prospect          |
| /Prospect{id}          | PUT     | Prospect | Prospect          |
| /Prospect{id}          | DEL     |          | Prospect          |
| /Prospect{id}/formated | get     |          | Prospect formaté  |

## Statut juridique

| URL                  | Méthode | Body             | Réponse                   |
| -------------------- | ------- | ---------------- | ------------------------- |
| /statutJuridique     | GET     |                  | Liste de statut juridique |
| /statutJuridique     | POST    | Statut juridique | Statut juridique          |
| /statutJuridique{id} | GET     |                  | Statut juridique          |
| /statutJuridique{id} | PUT     | Statut juridique | Statut juridique          |
| /statutJuridique{id} | DEL     |                  | Statut juridique          |

## Utilisateurs

| URL                   | Méthode | Body                       | Réponse             |
| --------------------- | ------- | -------------------------- | ------------------- |
| /Utilisateurs         | GET     |                            | Liste d'utilisateur |
| /Utilisateurs         | POST    | Utilisateur                | Utilisateur         |
| /Utilisateurs{id}     | GET     |                            | Utilisateur         |
| /Utilisateurs{id}     | PUT     | Utilisateur sans le mdp    | Utilisateur         |
| /Utilisateurs{id}/mdp | PUT     | Utilisateur uniquement mdp | Utilisateur         |
| /Utilisateurs{id}     | DEL     |                            | Utilisateur         |

