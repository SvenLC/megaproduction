# Dictionnaire des données

| Numéro | Date     | responsable | descriptif                           |
| ------ | -------- | ----------- | ------------------------------------ |
| 1.2.0  | 14/11/18 | S. Le Cann  | Ajout des entitées                   |
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
| Identifiant             | par_id       | N    |
| Dénomination            | par_denom    | AN   |
| numéro de téléphone     | par_tel      | AN   |
| numéro de fax           | par_fax      | AN   |
| adresse email           | par_email    | AN   |
| Login                   | par_login    | AN   |
| mots de passe           | par_mdp      | AN   |
  
## Entité Offres de castings

| Libellé de la propriété         | Nom du champ       | Type |
| ------------------------------- | ------------------ | ---- |
| Identifiant                     | cas_id             | N    |
| Intitulé                        | cas_intit          | AN   |
| Référence                       | cas_ref            | AN   |
| Date de début de publication    | cas_date_deb_pub   | DATE |
| Durée de diffusion              | cas_dur_diff       | N    |
| Date de début du contrat        | cas_date_deb_contr | DATE |
| Nombre de poste                 | cas_nbr_post       | N    |
| Description du poste            | cas_desc_post      | AN   |
| Description du profil recherché | cas_desc_prof_rech | AN   |

## Entité Adresse

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Numéro de la voie       | adr_num_voie | N    |
| Nom de la rue           |

## Entité Ville

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | vil_id       | N    |
| Nom de la ville         | vil_nom      | A    |

## Entité Code postal

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | cpl_id       | N    |
| Code                    | cpl_code     | N    |
| Nom                     | cpl_nom      | N    |

## Entité Domaine de métiers

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | dom_id       | N    |
| Libellé                 | dom_lib      | A    |


## Entité Métiers

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | met_id       | N    |
| Libellé                 | met_lib      | A    |

## Entité Contrats

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | con_id       | N    |
| Libellé                 | con_lib      | A    |

## Entité Contact

## Entité Statuts juridique

- Contenu  éditorial
  - Fiches  métiers
  - Conseils
  - Interviews

https://sqlpro.developpez.com/cours/normes/#L3.1
https://blog.developpez.com/exercices-sql/p10901/exercices-sql/modelisation_d_une_adresse