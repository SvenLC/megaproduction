# Dictionnaire des données

## Table clients
|Description|Nom du champ|Type|Nullable|
|----|----|----|-----|
|Identifiant|Cli_Id|INT|Non null|
|Dénomination|Cli_Denomination|VARCHAR|Non null|
|Statut juridique|Cli_StatutJuridique|VARCHAR|Non null|
|Adresse|Cli_Adresse|
numéro de téléphone
numéro de fax
adresse email
numéro de siret (Pour les entreprises)
numéro RNA (Associations)
  
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