- **Code erreur globale**

  | Code | Nom                          | Description                                     |
  | ---- | ---------------------------- | ----------------------------------------------- |
  | 001  | WrongSignature               | Signature d'appel incorrecte                    |
  | 002  | UnkownFailure                | Échec d'origine inconnu                         |
  | 003  | InvalidParameterType         | Type de paramètre incorrect                     |
  | 008  | WrongParameter               | Paramètre incorrect                             |
  | 003  | MissingParamater             | Paramètre  manquant                             |
  | 004  | NotImplementedAction         | Pas encore implémenté                           |
  | 005  | MissingAuthenticationToken   | Token d'authentification manquant               |
  | 005  | WrongAuthenticationTokenType | Type incorrect pour le token d'authentification |
  | 006  | InvalidToken                 | Token non valide                                |
  | 008  | WrongParameter               | Paramètre incorrect                             |
  | 009  | RequestExpired               | Requête expirée                                 |

- **Code erreur spécifique à l'api privée**

  | Code | Nom                   | Description             |
  | ---- | --------------------- | ----------------------- |
  | 101  | DataBaseUnavailable   | DataBase non disponible |
  | 102  | ForeignKeyRestriction | Problème de foreignKey  |

- **Code erreur spécifique à l'api publique**

  | Code | Nom                      | Description                              |
  | ---- | ------------------------ | ---------------------------------------- |
  | 201  | PrivateAPIUnavailable    | API privée injoignable                   |
  | 202  | PrivateAPIDoNotImplement | Méthode non implémenté dans l'api privée |
