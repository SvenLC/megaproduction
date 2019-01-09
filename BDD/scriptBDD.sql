/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: T_S_UTILISATEUR_UTI
------------------------------------------------------------*/
CREATE TABLE T_S_UTILISATEUR_UTI(
	UTI_ID       INT IDENTITY (1,1) NOT NULL ,
	UTI_NOM      VARCHAR (50) NOT NULL ,
	UTI_PRENOM   VARCHAR (50) NOT NULL ,
	UTI_LOGIN    VARCHAR (50) NOT NULL ,
	UTI_MDP      VARCHAR (50) NOT NULL ,
	UTI_ADMIN    bit  NOT NULL  ,
	CONSTRAINT T_S_UTILISATEUR_UTI_PK PRIMARY KEY (UTI_ID)
);


/*------------------------------------------------------------
-- Table: T_E_PROSPECT_PRO
------------------------------------------------------------*/
CREATE TABLE T_E_PROSPECT_PRO(
	PRO_ID      INT IDENTITY (1,1) NOT NULL ,
	PRO_DENOM   VARCHAR (50) NOT NULL  ,
	CONSTRAINT T_E_PROSPECT_PRO_PK PRIMARY KEY (PRO_ID)
);


/*------------------------------------------------------------
-- Table: T_E_PARTENAIRE_PAR
------------------------------------------------------------*/
CREATE TABLE T_E_PARTENAIRE_PAR(
	PRO_ID      INT  NOT NULL ,
	PAR_LOGIN   VARCHAR (50) NOT NULL ,
	PAR_MDP     VARCHAR (50) NOT NULL ,
	PRO_DENOM   VARCHAR (50) NOT NULL  ,
	CONSTRAINT T_E_PARTENAIRE_PAR_PK PRIMARY KEY (PRO_ID)

	,CONSTRAINT T_E_PARTENAIRE_PAR_T_E_PROSPECT_PRO_FK FOREIGN KEY (PRO_ID) REFERENCES T_E_PROSPECT_PRO(PRO_ID)
);


/*------------------------------------------------------------
-- Table: T_E_CONTACT_CTC
------------------------------------------------------------*/
CREATE TABLE T_E_CONTACT_CTC(
	CTC_ID              INT IDENTITY (1,1) NOT NULL ,
	CTC_DESCRIPTION     VARCHAR (50) NOT NULL ,
	CTC_NUM_TEL         VARCHAR (10) NOT NULL ,
	CTC_NUM_FAX         VARCHAR (10) NOT NULL ,
	CTC_ADRESSE_EMAIL   VARCHAR (50) NOT NULL ,
	CTC_PRINCIPALE      bit  NOT NULL ,
	PRO_ID              INT  NOT NULL  ,
	CONSTRAINT T_E_CONTACT_CTC_PK PRIMARY KEY (CTC_ID)

	,CONSTRAINT T_E_CONTACT_CTC_T_E_PROSPECT_PRO_FK FOREIGN KEY (PRO_ID) REFERENCES T_E_PROSPECT_PRO(PRO_ID)
);


/*------------------------------------------------------------
-- Table: T_R_ADRESSE_ADR
------------------------------------------------------------*/
CREATE TABLE T_R_ADRESSE_ADR(
	ADR_ID            INT IDENTITY (1,1) NOT NULL ,
	ADR_NUM_VOIE      CHAR (5)  NOT NULL ,
	ADR_LIBELLE_RUE   VARCHAR (50) NOT NULL ,
	ADR_CODE_POSTAL   CHAR (5)  NOT NULL ,
	ADR_VILLE         VARCHAR (50) NOT NULL  ,
	CONSTRAINT T_R_ADRESSE_ADR_PK PRIMARY KEY (ADR_ID)
);


/*------------------------------------------------------------
-- Table: T_R_DOMAINE_METIER_DOM
------------------------------------------------------------*/
CREATE TABLE T_R_DOMAINE_METIER_DOM(
	DOM_ID        INT IDENTITY (1,1) NOT NULL ,
	DOM_LIBELLE   VARCHAR (50) NOT NULL  ,
	CONSTRAINT T_R_DOMAINE_METIER_DOM_PK PRIMARY KEY (DOM_ID)
);


/*------------------------------------------------------------
-- Table: T_R_METIER_MET
------------------------------------------------------------*/
CREATE TABLE T_R_METIER_MET(
	MET_ID        INT IDENTITY (1,1) NOT NULL ,
	MET_LIBELLE   VARCHAR (50) NOT NULL ,
	DOM_ID        INT  NOT NULL  ,
	CONSTRAINT T_R_METIER_MET_PK PRIMARY KEY (MET_ID)

	,CONSTRAINT T_R_METIER_MET_T_R_DOMAINE_METIER_DOM_FK FOREIGN KEY (DOM_ID) REFERENCES T_R_DOMAINE_METIER_DOM(DOM_ID)
);


/*------------------------------------------------------------
-- Table: T_R_TYPE_CONTRAT_CON
------------------------------------------------------------*/
CREATE TABLE T_R_TYPE_CONTRAT_CON(
	CON_ID        INT IDENTITY (1,1) NOT NULL ,
	CON_LIBELLE   VARCHAR (50) NOT NULL  ,
	CONSTRAINT T_R_TYPE_CONTRAT_CON_PK PRIMARY KEY (CON_ID)
);


/*------------------------------------------------------------
-- Table: T_R_STATUT_JURIDIQUE_JUR
------------------------------------------------------------*/
CREATE TABLE T_R_STATUT_JURIDIQUE_JUR(
	JUR_ID        INT IDENTITY (1,1) NOT NULL ,
	JUR_LIBELLE   VARCHAR (50) NOT NULL  ,
	CONSTRAINT T_R_STATUT_JURIDIQUE_JUR_PK PRIMARY KEY (JUR_ID)
);


/*------------------------------------------------------------
-- Table: T_E_CLIENT_CLI
------------------------------------------------------------*/
CREATE TABLE T_E_CLIENT_CLI(
	PRO_ID      INT  NOT NULL ,
	CLI_SIRET   CHAR (14)   ,
	CLI_RNA     CHAR (10)   ,
	PRO_DENOM   VARCHAR (50) NOT NULL ,
	ADR_ID      INT  NOT NULL ,
	JUR_ID      INT  NOT NULL  ,
	CONSTRAINT T_E_CLIENT_CLI_PK PRIMARY KEY (PRO_ID)

	,CONSTRAINT T_E_CLIENT_CLI_T_E_PROSPECT_PRO_FK FOREIGN KEY (PRO_ID) REFERENCES T_E_PROSPECT_PRO(PRO_ID)
	,CONSTRAINT T_E_CLIENT_CLI_T_R_ADRESSE_ADR0_FK FOREIGN KEY (ADR_ID) REFERENCES T_R_ADRESSE_ADR(ADR_ID)
	,CONSTRAINT T_E_CLIENT_CLI_T_R_STATUT_JURIDIQUE_JUR1_FK FOREIGN KEY (JUR_ID) REFERENCES T_R_STATUT_JURIDIQUE_JUR(JUR_ID)
);


/*------------------------------------------------------------
-- Table: Localisation
------------------------------------------------------------*/
CREATE TABLE Localisation(
	Identifiant   INT IDENTITY (1,1) NOT NULL  ,
	CONSTRAINT Localisation_PK PRIMARY KEY (Identifiant)
);


/*------------------------------------------------------------
-- Table: T_E_OFFRE_CASTING_CAS
------------------------------------------------------------*/
CREATE TABLE T_E_OFFRE_CASTING_CAS(
	CAS_ID                        INT IDENTITY (1,1) NOT NULL ,
	CAS_INTITULE                  VARCHAR (50) NOT NULL ,
	CAS_REFERENCE                 CHAR (8)  NOT NULL ,
	CAS_DATE_DEBUT_PUBBLICATION   DATETIME NOT NULL ,
	CAS_DUREE_DIFFUSION           TIME (2) NOT NULL ,
	CAS_DATE_DEBUT_CONTRAT        DATETIME NOT NULL ,
	CAS_NBR_POSTE                 INT  NOT NULL ,
	CAS_DESCRIPTION_POSTE         TEXT  NOT NULL ,
	CAS_DESCRIPTION_PROFIL        VARCHAR (50) NOT NULL ,
	PRO_ID                        INT  NOT NULL ,
	MET_ID                        INT  NOT NULL ,
	CON_ID                        INT  NOT NULL ,
	Identifiant                   INT  NOT NULL ,
	CTC_ID                        INT  NOT NULL  ,
	CONSTRAINT T_E_OFFRE_CASTING_CAS_PK PRIMARY KEY (CAS_ID)

	,CONSTRAINT T_E_OFFRE_CASTING_CAS_T_E_CLIENT_CLI_FK FOREIGN KEY (PRO_ID) REFERENCES T_E_CLIENT_CLI(PRO_ID)
	,CONSTRAINT T_E_OFFRE_CASTING_CAS_T_R_METIER_MET0_FK FOREIGN KEY (MET_ID) REFERENCES T_R_METIER_MET(MET_ID)
	,CONSTRAINT T_E_OFFRE_CASTING_CAS_T_R_TYPE_CONTRAT_CON1_FK FOREIGN KEY (CON_ID) REFERENCES T_R_TYPE_CONTRAT_CON(CON_ID)
	,CONSTRAINT T_E_OFFRE_CASTING_CAS_Localisation2_FK FOREIGN KEY (Identifiant) REFERENCES Localisation(Identifiant)
	,CONSTRAINT T_E_OFFRE_CASTING_CAS_T_E_CONTACT_CTC3_FK FOREIGN KEY (CTC_ID) REFERENCES T_E_CONTACT_CTC(CTC_ID)
);



