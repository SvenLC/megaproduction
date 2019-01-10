# Gestion des riques

| Numéro | Date     | responsable | descriptif           |
| ------ | -------- | ----------- | -------------------- |
| 1.0.1  | 21/11/18 | B. Ragot    | Création du document |

- Difficulté d'utiliser les nouvelles technologies
  - Gravité = 3
  - Fréquence = 2
  - Criticité =  6

  - Responsable : S. Lecann & B. Ragot
  - Prévention : Délai plus long pour réaliser les tâches.
  - Réparation :
    - Retour en arrière si début de projet
    - Retour en arrière sur la fonctionnalité si possible
    - Changement de priorités des fonctionnalités pour gagner du temps.

- Perte de la connection avec la base de donnée.

  - Gravité = 2
  - Fréquence = 1 
  - Criticité =  2


  - Responsable : S. Lecann
  - Prévention : Haute disponibilité dans le cloud Azure.
  - Réparation :
    - Redémarrage du serveur.
    - Démarrage d'une nouvelle instance SQL Server et nouvelle import de la base de donnée.

- Perte de connection avec l'api.

  - Gravité = 1
  - Fréquence = 1 
  - Criticité =  1


  - Responsable : S. Lecann
  - Prévention : Haute disponibilité dans le cloud Azure.
  - Réparation :
    - Redémarrage du serveur.
    - Démarrage d'une nouvelle instance et changement de référence du domaine.


- Problème d'intégration continué de l'api

  - Gravité = 2
  - Fréquence = 1 
  - Criticité =  2


  - Responsable : S. Lecann
  - Prévention : Test unitaire
  - Réparation :
    - Restauration d'un ancien commit

- Charge de travaille annexe trop importante.

  - Gravité = 2
  - Fréquence = 3 
  - Criticité =  6


  - Responsable : S. Lecann
  - Prévention : Définition d'un planning modulable.
  - Réparation :
    - Allongement des temps de réalisation des tâches.
    - Nouveau planning.

- Problème de communication avec les services externes lors de l'oral

  - Gravité = 4
  - Fréquence = 1 
  - Criticité =  4


  - Responsable : S. Lecann
  - Prévention : Haute disponibilité du cloud.
  - Réparation :
    - Redémarrage du serveur.
    - Démarrage d'une nouvelle instance SQL Server et nouvelle import de la base de donnée.



