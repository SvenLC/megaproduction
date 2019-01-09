# Dictionnaire des données

| Numéro | Date     | responsable | descriptif                           |
| ------ | -------- | ----------- | ------------------------------------ |
| 1.4.0  | 09/10/18 | S. Le Cann  | Réorganisation et ajouts d'entités   |
| 1.3.0  | 15/11/18 | S. Le Cann  | Réorganisation et ajouts d'entités   |
| 1.2.0  | 14/11/18 | S. Le Cann  | Ajout des entitées                   |
| 1.1.0  | 14/11/18 | S. Le Cann  | Ajout des entitées, ajout des champs |
| 1.0.0  | 11/11/18 | B. Ragot    | Création du document                 |

## Entité Utilisateur

| Libellé de la propriété | Nom du champ       | Type |
| ----------------------- | ------------------ | ---- |
| Identifiant             | UTI_ID             | N    |
| Nom                     | UTI_NOM            | A    |
| Prenom                  | UTI_PRENOM         | A    |
| Login                   | UTI_LOGIN          | A    |
| Mot de passe            | UTI_MDP            | AN   |
| Est administrateur      | UTI_ADMINISTRATEUR | B    |

## Entité Prospect

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | PRO_ID       | N    |
| NOM                     | PRO_NAME     | AN   |

## Entité client

| Libellé de la propriété   | Nom du champ | Type |
| ------------------------- | ------------ | ---- |
| Identifiant               | CLI_ID       | N    |
| numéro de siret           | CLI_SIRET    | AN   |
| numéro RNA (Associations) | CLI_RNA      | AN   |
  
## Entité partenaires de diffusions

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | PAR_ID       | N    |
| Login                   | PAR_LOGIN    | AN   |
| mots de passe           | PAR_MDP      | AN   |
  
## Entité Offres de castings

| Libellé de la propriété         | Nom du champ                | Type |
| ------------------------------- | --------------------------- | ---- |
| Identifiant                     | CAST_ID                     | N    |
| Intitulé                        | CAST_INTITULE               | AN   |
| Référence                       | CAST_REFERENCE              | AN   |
| Date de début de publication    | CAST_DATE_DEBUT_PUBLICATION | DATE |
| Durée de diffusion              | CAST_DUREE_DIFFUSION        | N    |
| Date de début du contrat        | CAST_DATE_DEBUT_CONTRAT     | DATE |
| Nombre de poste                 | CAST_NBR_POSTE              | N    |
| Description du poste            | CAST_DESCRIPTION_POSTE      | AN   |
| Description du profil recherché | CAST_DESCRIPTION_PROFIL     | AN   |

## Fiche de contact

| Libellé de la propriété | Nom du champ    | Type |
| ----------------------- | --------------- | ---- |
| Identifiant             | CTC_ID          | N    |
| Description             | CTC_DESCRIPTION | A    |
| numéro de téléphone     | CTC_NUM_TEL     | AN   |
| numéro de fax           | CTC_NUM_FAX     | AN   |
| adresse email           | CTC_EMAIL       | AN   |
| Est principale          | CTC_PRINCIPALE  | B    |

## Entité Adresse

| Libellé de la propriété | Nom du champ    | Type |
| ----------------------- | --------------- | ---- |
| Identifiant             | ADR_ID          | N    |
| Numéro de la voie       | ADR_NUM_VOIE    | N    |
| Libellé de la rue       | ADR_LIBELLE_RUE | AN   |
| Ville                   | adr_ville       | A    |

## Entité Localisation

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | LOC_ID       | AN   |
| libelle                 | LOC_LIBELLE  | AN   |

## Entité Code postal

| Libellé de la propriété | Nom du champ    | Type |
| ----------------------- | --------------- | ---- |
| Code commune            | CPT_COMMUNE     | N    |
| Code postal             | CPT_CODEPOST    | N    |
| Code département        | CPT_DEPARTEMENT | N    |
| Code Insee              | CPT_INSEE       | N    |

## Entité Domaines de métiers

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | DOM_ID       | N    |
| Libellé                 | DOM_LIBELLE  | A    |

## Entité Métiers

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | MET_ID       | N    |
| Libellé                 | MET_LIBELLE  | A    |

## Entité Contrats

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | CON_ID       | N    |
| Libellé                 | CON_LIBELLE  | A    |

## Entité Statuts juridique

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | JUR_ID       | N    |
| Libellé                 | JUR_LIBELLE  | A    |

## Contenu éditorial

| Libellé de la propriété | Nom du champ    | Type |
| ----------------------- | --------------- | ---- |
| Identifiant             | EDI_ID          | N    |
| Description             | EDI_DESCRIPTION | AN   |
| Contenu                 | EDI_CONTENU     | AN   |

## Type de contenu éditorial

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Identifiant             | CET_ID       | N    |
| Libellé                 | CET_LIBELLE  | AN   |

## Information base de données

| Libellé de la propriété | Nom du champ | Type |
| ----------------------- | ------------ | ---- |
| Libelle                 | DBI_LIBELLE  | AN   |
| Type                    | DBI_TYPE     | AN   |
| Valeur                  | DBI_VALEUR   | AN   |

## Administration de la base de données

| Libellé de la propriété | Nom du champ  | Type |
| ----------------------- | ------------- | ---- |
| Identifiant             | DBA_ID        | N    |
| Horodatage              | DBA_DATEHEURE | DATE |
| Nom                     | DBA_NOM       | A    |
| Nature                  | DBA_NATURE    | AN   |
| Commande                | DBA_COMMANDE  | AN   |




https://sqlpro.developpez.com/cours/normes/#L3.1
https://blog.developpez.com/exercices-sql/p10901/exercices-sql/modelisation_d_une_adresse