# Dictionnaire des données

## Table clients

| Description               | Nom du champ          | Type    | Nullable |
| ------------------------- | --------------------- | ------- | -------- |
| Identifiant               | Cli_Identifiant (PK)  | INT     | Non null |
| Dénomination              | Cli_Denomination      | VARCHAR | Non null |
| Statut juridique          | Cli_StatutJuridique   | VARCHAR | Non null |
| numéro de téléphone       | Cli_NumeroTelephone   | VARCHAR | Non null |
| numéro de fax             | Cli_NumeroFax         | VARCHAR | Non null |
| adresse email             | Cli_EMail             | VARCHAR | Non null |
| numéro de siret           | Cli_NumeroSiret       | VARCHAR | Nullable |
| numéro RNA (Associations) | Cli_NumeroRna         | VARCHAR | Nullable |
| Adresse                   | Addr_Identifiant (FK) | INT     | Non null |
  
## Table Partenaires de diffusions

| Description         | Nom du champ          | Type    | Nullable |
| ------------------- | --------------------- | ------- | -------- |
| Identifiant         | Part_Identifiant (PK) | INT     | Non null |
| Dénomination        | Part_Denomination     | VARCHAR | Non null |
| Statut juridique    | Part_StatutJuridique  | VARCHAT | Non null |
| numéro de téléphone | Part_NumeroTelephone  | VARCHAR | Non null |
| numéro de fax       | Part_NumeroFax        | VARCHAR | Non null |
| adresse email       | Part_EMail            | VARCHAR | Non null |
| Login               | Part_Login            | VARCHAR | Non null |
| mots de passe       | Part_MotDePasse       | VARCHAR | Non null |
  
## Offres de castings

| Description | Nom du champ          | Type    | Nullable |
| ----------- | --------------------- | ------- | -------- |
| Identifiant | Cast_Identifiant (PK) | INT     | Non null |
| Intitulé    | Cast_Intitule         | VARCHAR | Non null |
|Référence|Cast_Reference|VARCHAR|Non null|
  - Domaine de métier //TODO : #Référentiels
  - Métier //TODO : #Référentiels
  - Type de contrat //TODO : #Référentiels
  - Date de début de publication
  - Durée de diffusion
  - Date de début du contrat
  - Nombre de poste
  - Localisation
  - Description du poste
  - Description du profil recherché
  - Coordonnées
  - #Client

Faire les différentes table des listes de référentiel

- Contenu  éditorial
    - Fiches  métiers
    - Conseils
    - Interviews