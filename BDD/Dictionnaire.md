# Dictionnaire des données

| Numéro | Date     | responsable | descriptif                           |
| ------ | -------- | ----------- | ------------------------------------ |
| 1.3.0  | 15/11/18 | S. Le Cann  | Réorganisation et ajouts d'entités   |
| 1.2.0  | 14/11/18 | S. Le Cann  | Ajout des entitées                   |
| 1.1.0  | 14/11/18 | S. Le Cann  | Ajout des entitées, ajout des champs |
| 1.0.0  | 11/11/18 | B. Ragot    | Création du document                 |

## Entité Utilisateur

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | uti_id       | N    |
| Nom                     | uti_nom      | A    |
| Prenom                  | uti_prenom   | A    |
| Login                   | uti_login    | A    |
| Mot de passe            | uti_mdp      | AN   |
| Est administrateur      | uti_admin    | B    |

## Entité Prospect

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | pro_id       | N    |
| Dénomination            | pro_denom    | AN   |

## Entité client

| Libellé de la propriété   | Nom du champ | Type |
| ------------------------- | ------------ | ---- |
| Identifiant               | cli_id       | N    |
| numéro de siret           | cli_siret    | AN   |
| numéro RNA (Associations) | cli_rna      | AN   |
  
## Entité partenaires de diffusions

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | par_id       | N    |
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

## Fiche de contact

| Libellé de la propriété | Nom du champ   | Type |
| ----------------------- | -------------- | ---- |
| Identifiant             | ctc_id         | N    |
| Description             | ctc_desc       | A    |
| numéro de téléphone     | ctc_tel        | AN   |
| numéro de fax           | ctc_fax        | AN   |
| adresse email           | ctc_email      | AN   |
| Est principale          | ctc_principale | B    |

## Entité Adresse

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Numéro de la voie       | adr_num_voie | N    |
| Libellé de la rue       | adr_lib_rue  | AN   |
| Code postal             | adr_cp       | N    |
| Ville                   | adr_ville    | A    |

## Entité Localisation

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | loc_libelle  | AN   |

## Entité Code postal

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | cpl_id       | N    |
| Code                    | cpl_code     | N    |
| Nom                     | cpl_nom      | N    |

## Entité Domaines de métiers

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

## Entité Statuts juridique

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | jur_id       | N    |
| Libellé                 | jur_libelle  | A    |

https://sqlpro.developpez.com/cours/normes/#L3.1
https://blog.developpez.com/exercices-sql/p10901/exercices-sql/modelisation_d_une_adresse