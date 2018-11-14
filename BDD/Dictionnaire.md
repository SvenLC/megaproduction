# Dictionnaire des données

| Numéro | Date     | responsable | descriptif                           |
| ------ | -------- | ----------- | ------------------------------------ |
| 1.1.0  | 14/11/18 | S. Le Cann  | Ajout des entitées, ajout des champs |
| 1.0.0  | 11/11/18 | B. Ragot    | Création du document                 |

## Entité client

| Libellé de la propriété       | Nom du champ  | Type |
| ----------------------------- | ------------- | ---- |
| Identifiant                   | cli_id        | N    |
| Dénomination                  | cli_denom     | AN   |
| numéro de téléphone           | cli_tel       | AN   |
| numéro de fax                 | cli_fax       | AN   |
| adresse email                 | cli_email     | AN   |
| numéro de siret               | cli_siret     | AN   |
| numéro RNA (Associations)     | cli_rna       | AN   |
| numéro TVA Intracommunautaire | cli_tva_intra | AN   |
  
## Entité partenaires de diffusions

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | part_id      | N    |
| Dénomination            | part_denom   | AN   |
| numéro de téléphone     | part_tel     | AN   |
| numéro de fax           | part_fax     | AN   |
| adresse email           | part_email   | AN   |
| Login                   | part_login   | AN   |
| mots de passe           | part_mdp     | AN   |
  
## Entité Offres de castings

| Libellé de la propriété         | Nom du champ        | Type |
| ------------------------------- | ------------------- | ---- |
| Identifiant                     | cast_id             | N    |
| Intitulé                        | cast_intit          | AN   |
| Référence                       | cast_ref            | AN   |
| Date de début de publication    | cast_date_deb_pub   | DATE |
| Durée de diffusion              | cast_dur_diff       | N    |
| Date de début du contrat        | cast_date_deb_contr | DATE |
| Nombre de poste                 | cast_nbr_post       | N    |
| Description du poste            | cast_desc_post      | AN   |
| Description du profil recherché | cast_desc_prof_rech | AN   |

## Entité Adresse

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Numéro de la voie       | adr_num_voie | N    |
| Nom de la rue           |

## Entité Ville

## Entité Code postal

## Entité Domaine de métiers

## Entité Métiers

## Entité Contrats

## Entité Contact

## Entité Statuts juridique

- Contenu  éditorial
  - Fiches  métiers
  - Conseils
  - Interviews

https://sqlpro.developpez.com/cours/normes/#L3.1
https://blog.developpez.com/exercices-sql/p10901/exercices-sql/modelisation_d_une_adresse