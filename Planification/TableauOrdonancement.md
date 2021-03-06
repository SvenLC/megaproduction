# Tableau d'ordonancement des tâches

| Numéro | Date     | responsable | descriptif           |
| ------ | -------- | ----------- | -------------------- |
| 1.0.1  | 21/11/18 | B. Ragot    | Création du document |

| Id  | Tâche                                          | Dépendance | Durée |       |
| --- | ---------------------------------------------- | ---------- | ----- | ----- |
| A   | Gestions des prospects (Client lourd)          | E          | 2     | Check |
| B   | Gestion des offres (Client lourd)              | A,H        | 2     | Check |
| D   | Authentification (Client lourd)                | G, AA      | 2     | Check |
| E   | Gestion des utilisateurs (Client lourd)        | D          | 1     | Check |
| F   | Gestion du contenu éditorial (Client lourd)    | E          | 1     | Check |
| G   | Interface utilisateur (Client lourd)           |            | 15    | Check |
| H   | Gérer les listes de référentiel (Client lourd) | E          | 1     | Check |
| I   | Installation Node.js API Privée                | R          | 0.25  | Check |
| J   | API REST CRUD Privée                           | I          | 20    | Check |
| K   | Installation Node.js API public                | R          | 0.25  | Check |
| L   | API REST Read only                             | J, K       | 2     | Check |
| M   | Installation Windows server (Azure)            |            | 0.25  | Check |
| N   | Installation SQLServer (Azure)                 | M          | 0.25  | Check |
| O   | Paramétrage SQLServer                          | N          | 0.25  | Check |
| P   | Création de la BDD                             | O          | 0.25  | Check |
| Q   | Création des tables                            | P          | 1     | Check |
| R   | Contraintes                                    | Q          | 0.25  | Check |
| S   | Installation serveur web                       |            | 0.25  | Check |
| T   | Page d'accueil (Client léger)                  | BB, CC, S  | 0.5   | Check |
| U   | Page des offres (Client léger)                 | BB, CC, S  | 2     | Check |
| V   | Moteur de recherche (Client léger)             | T,U,V      | 3     | Check |
| W   | Page éditoriale (Client léger)                 | BB, CC, S  | 1     | Check |
| X   | Documentation utilisateur                      | V, F, B    | 5     |       |
| Y   | Documentation technique                        | Z          | 5     |       |
| Z   | Test                                           | V, F, B    | 3     |       |
| AA  | Sécurisation locale API Privée                 | J          | 1     | Check |
| BB  | Sécurisation par authentification API Publique | L          | 1     | Check |
| CC  | Design du site web                             |            | 2.5   | Check |

Valeur d'une unité de durée = 30m

