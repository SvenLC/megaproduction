/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: T_S_UTILISATEUR_UTI
------------------------------------------------------------*/
CREATE TABLE T_S_UTILISATEUR_UTI(
	UTI_ID               INT IDENTITY (1,1) NOT NULL ,
	UTI_NOM              VARCHAR (50) NOT NULL ,
	UTI_PRENOM           VARCHAR (50) NOT NULL ,
	UTI_LOGIN            VARCHAR (50) NOT NULL ,
	UTI_MDP              VARCHAR (50) NOT NULL ,
	UTI_ADMINISTRATEUR   bit  NOT NULL  ,
	CONSTRAINT PK_T_S_UTILISATEUR_UTI PRIMARY KEY (UTI_ID)
);


/*------------------------------------------------------------
-- Table: T_E_PROSPECT_PRO
------------------------------------------------------------*/
CREATE TABLE T_E_PROSPECT_PRO(
	PRO_ID   INT IDENTITY (1,1) NOT NULL  ,
	CONSTRAINT PK_T_E_PROSPECT_PRO PRIMARY KEY (PRO_ID)
);


/*------------------------------------------------------------
-- Table: T_H_PARTENAIRES_PAR
------------------------------------------------------------*/
CREATE TABLE T_H_PARTENAIRES_PAR(
	PRO_ID      INT  NOT NULL ,
	PAR_LOGIN   VARCHAR (50) NOT NULL ,
	PAR_MDP     VARCHAR (50) NOT NULL  ,
	CONSTRAINT PK_T_H_PARTENAIRES_PAR PRIMARY KEY (PRO_ID)

	,CONSTRAINT FK_T_H_PARTENAIRES_PAR_T_E_PROSPECT_PRO FOREIGN KEY (PRO_ID) REFERENCES T_E_PROSPECT_PRO(PRO_ID)
);


/*------------------------------------------------------------
-- Table: T_E_CONTACT_CTC
------------------------------------------------------------*/
CREATE TABLE T_E_CONTACT_CTC(
	CTC_ID            INT IDENTITY (1,1) NOT NULL ,
	CTC_DESCRIPTION   VARCHAR (50) NOT NULL ,
	CTC_NUM_TEL       VARCHAR (14) NOT NULL ,
	CTC_NUM_FAX       VARCHAR (14) NOT NULL ,
	CTC_EMAIL         VARCHAR (50) NOT NULL ,
	CTC_PRINCIPALE    bit  NOT NULL ,
	PRO_ID            INT  NOT NULL  ,
	CONSTRAINT PK_T_E_CONTACT_CTC PRIMARY KEY (CTC_ID)

	,CONSTRAINT FK_T_E_CONTACT_CTC_T_E_PROSPECT_PRO FOREIGN KEY (PRO_ID) REFERENCES T_E_PROSPECT_PRO(PRO_ID)
);


/*------------------------------------------------------------
-- Table: T_R_LOCALISATION_LOC
------------------------------------------------------------*/
CREATE TABLE T_R_LOCALISATION_LOC(
	LOC_ID        INT IDENTITY (1,1) NOT NULL ,
	LOC_LIBELLE   VARCHAR (50) NOT NULL  ,
	CONSTRAINT PK_T_R_LOCALISATION_LOC PRIMARY KEY (LOC_ID)
);


/*------------------------------------------------------------
-- Table: T_R_DOMAINE_METIER_DOM
------------------------------------------------------------*/
CREATE TABLE T_R_DOMAINE_METIER_DOM(
	DOM_ID        INT IDENTITY (1,1) NOT NULL ,
	DOM_LIBELLE   VARCHAR (50) NOT NULL  ,
	CONSTRAINT PK_T_R_DOMAINE_METIER_DOM PRIMARY KEY (DOM_ID)
);


/*------------------------------------------------------------
-- Table: T_R_METIER_MET
------------------------------------------------------------*/
CREATE TABLE T_R_METIER_MET(
	MET_ID        INT IDENTITY (1,1) NOT NULL ,
	MET_LIBELLE   VARCHAR (50) NOT NULL ,
	DOM_ID        INT  NOT NULL  ,
	CONSTRAINT PK_T_R_METIER_MET PRIMARY KEY (MET_ID)

	,CONSTRAINT FK_T_R_METIER_MET_T_R_DOMAINE_METIER_DOM FOREIGN KEY (DOM_ID) REFERENCES T_R_DOMAINE_METIER_DOM(DOM_ID)
);


/*------------------------------------------------------------
-- Table: T_R_CONTRAT_CON
------------------------------------------------------------*/
CREATE TABLE T_R_CONTRAT_CON(
	CON_ID        INT IDENTITY (1,1) NOT NULL ,
	CON_LIBELLE   VARCHAR (50) NOT NULL  ,
	CONSTRAINT PK_T_R_CONTRAT_CON PRIMARY KEY (CON_ID)
);


/*------------------------------------------------------------
-- Table: T_R_STATUT_JURIDIQUE_JUR
------------------------------------------------------------*/
CREATE TABLE T_R_STATUT_JURIDIQUE_JUR(
	JUR_ID        INT IDENTITY (1,1) NOT NULL ,
	JUR_LIBELLE   VARCHAR (50) NOT NULL  ,
	CONSTRAINT PK_T_R_STATUT_JURIDIQUE_JUR PRIMARY KEY (JUR_ID)
);


/*------------------------------------------------------------
-- Table: T_E_ADRESSE_ADR
------------------------------------------------------------*/
CREATE TABLE T_E_ADRESSE_ADR(
	ADR_ID            INT IDENTITY (1,1) NOT NULL ,
	ADR_NUM_VOIE      VARCHAR (50) NOT NULL ,
	ADR_LIBELLE_RUE   VARCHAR (50) NOT NULL ,
	ADR_VILLE         VARCHAR (50) NOT NULL  ,
	CONSTRAINT PK_T_E_ADRESSE_ADR PRIMARY KEY (ADR_ID)
);


/*------------------------------------------------------------
-- Table: T_H_CLIENT_CLI
------------------------------------------------------------*/
CREATE TABLE T_H_CLIENT_CLI(
	PRO_ID      INT  NOT NULL ,
	CLI_SIRET   INT   ,
	CLI_RNA     INT   ,
	JUR_ID      INT  NOT NULL ,
	ADR_ID      INT  NOT NULL  ,
	CONSTRAINT PK_T_H_CLIENT_CLI PRIMARY KEY (PRO_ID)

	,CONSTRAINT FK_T_H_CLIENT_CLI_T_E_PROSPECT_PRO FOREIGN KEY (PRO_ID) REFERENCES T_E_PROSPECT_PRO(PRO_ID)
	,CONSTRAINT FK_T_H_CLIENT_CLI_T_R_STATUT_JURIDIQUE_JUR0 FOREIGN KEY (JUR_ID) REFERENCES T_R_STATUT_JURIDIQUE_JUR(JUR_ID)
	,CONSTRAINT FK_T_H_CLIENT_CLI_T_E_ADRESSE_ADR1 FOREIGN KEY (ADR_ID) REFERENCES T_E_ADRESSE_ADR(ADR_ID)
);


/*------------------------------------------------------------
-- Table: T_E_OFFRE_CASTING_CAST
------------------------------------------------------------*/
CREATE TABLE T_E_OFFRE_CASTING_CAST(
	CAST_ID                       INT IDENTITY (1,1) NOT NULL ,
	CAST_INTITULE                 VARCHAR (50) NOT NULL ,
	CAST_REFERENCE                VARCHAR (50) NOT NULL ,
	CAST_DATE_DEBUT_PUBLICATION   DATETIME NOT NULL ,
	CAST_DUREE_DIFFUSION          TIME (2) NOT NULL ,
	CAST_DATE_DEBUT_CONTRAT       DATETIME NOT NULL ,
	CAST_NBR_POSTE                INT  NOT NULL ,
	CAST_DESCRIPTION_POSTE        VARCHAR (50) NOT NULL ,
	CAST_DESCRIPTION_PROFIL       VARCHAR (50) NOT NULL ,
	PRO_ID                        INT  NOT NULL ,
	MET_ID                        INT  NOT NULL  ,
	CONSTRAINT PK_T_E_OFFRE_CASTING_CAST PRIMARY KEY (CAST_ID)

	,CONSTRAINT FK_T_E_OFFRE_CASTING_CAST_T_H_CLIENT_CLI FOREIGN KEY (PRO_ID) REFERENCES T_H_CLIENT_CLI(PRO_ID)
	,CONSTRAINT FK_T_E_OFFRE_CASTING_CAST_T_R_METIER_MET0 FOREIGN KEY (MET_ID) REFERENCES T_R_METIER_MET(MET_ID)
);


/*------------------------------------------------------------
-- Table: T_X_CODE_POSTAL_CPT
------------------------------------------------------------*/
CREATE TABLE T_X_CODE_POSTAL_CPT(
	CPT_ID            INT IDENTITY (1,1) NOT NULL ,
	CPT_CODE_POSTAL   CHAR (5)  NOT NULL ,
	CPT_VILLE         VARCHAR (50) NOT NULL  ,
	CONSTRAINT PK_T_X_CODE_POSTAL_CPT PRIMARY KEY (CPT_ID)
);


/*------------------------------------------------------------
-- Table: T_R_CONTENU_EDITORIAL_TYPE_CET
------------------------------------------------------------*/
CREATE TABLE T_R_CONTENU_EDITORIAL_TYPE_CET(
	CET_ID        INT IDENTITY (1,1) NOT NULL ,
	CET_LIBELLE   VARCHAR (100) NOT NULL  ,
	CONSTRAINT PK_T_R_CONTENU_EDITORIAL_TYPE_CET PRIMARY KEY (CET_ID)
);


/*------------------------------------------------------------
-- Table: T_E_CONTENU_EDITORIAL_EDI
------------------------------------------------------------*/
CREATE TABLE T_E_CONTENU_EDITORIAL_EDI(
	EDI_ID            INT IDENTITY (1,1) NOT NULL ,
	EDI_DESCRIPTION   VARCHAR (100) NOT NULL ,
	EDI_CONTENU       TEXT  NOT NULL ,
	CET_ID            INT  NOT NULL  ,
	CONSTRAINT PK_T_E_CONTENU_EDITORIAL_EDI PRIMARY KEY (EDI_ID)

	,CONSTRAINT FK_T_E_CONTENU_EDITORIAL_EDI_T_R_CONTENU_EDITORIAL_TYPE_CET FOREIGN KEY (CET_ID) REFERENCES T_R_CONTENU_EDITORIAL_TYPE_CET(CET_ID)
);


/*------------------------------------------------------------
-- Table: T_S_DATABASE_INFO_DBI
------------------------------------------------------------*/
CREATE TABLE T_S_DATABASE_INFO_DBI(
	DBI_ID       INT IDENTITY (1,1) NOT NULL ,
	DBI_TYPE     VARCHAR (12) NOT NULL ,
	DBI_VALEUR   TEXT  NOT NULL  ,
	CONSTRAINT PK_T_S_DATABASE_INFO_DBI PRIMARY KEY (DBI_ID)
);


/*------------------------------------------------------------
-- Table: T_S_DATABASE_ADMIN_DBA
------------------------------------------------------------*/
CREATE TABLE T_S_DATABASE_ADMIN_DBA(
	DBA_ID          INT IDENTITY (1,1) NOT NULL ,
	DBA_DATEHEURE   DATETIME  NOT NULL ,
	DBA_NOM         VARCHAR (32) NOT NULL ,
	DBA_NATURE      VARCHAR (256) NOT NULL ,
	DBA_COMMANDE    VARCHAR (256) NOT NULL  ,
	CONSTRAINT PK_T_S_DATABASE_ADMIN_DBA PRIMARY KEY (DBA_ID)
);


/*------------------------------------------------------------
-- Table: T_J_SITUER_SIT
------------------------------------------------------------*/
CREATE TABLE T_J_SITUER_SIT(
	LOC_ID    INT  NOT NULL ,
	CAST_ID   INT  NOT NULL  ,
	CONSTRAINT PK_T_J_SITUER_SIT PRIMARY KEY (LOC_ID,CAST_ID)

	,CONSTRAINT FK_T_J_SITUER_SIT_T_R_LOCALISATION_LOC FOREIGN KEY (LOC_ID) REFERENCES T_R_LOCALISATION_LOC(LOC_ID)
	,CONSTRAINT FK_T_J_SITUER_SIT_T_E_OFFRE_CASTING_CAST0 FOREIGN KEY (CAST_ID) REFERENCES T_E_OFFRE_CASTING_CAST(CAST_ID)
);


/*------------------------------------------------------------
-- Table: T_J_PROPOSE_PRO
------------------------------------------------------------*/
CREATE TABLE T_J_PROPOSE_PRO(
	CON_ID    INT  NOT NULL ,
	CAST_ID   INT  NOT NULL  ,
	CONSTRAINT PK_T_J_PROPOSE_PRO PRIMARY KEY (CON_ID,CAST_ID)

	,CONSTRAINT FK_T_J_PROPOSE_PRO_T_R_CONTRAT_CON FOREIGN KEY (CON_ID) REFERENCES T_R_CONTRAT_CON(CON_ID)
	,CONSTRAINT FK_T_J_PROPOSE_PRO_T_E_OFFRE_CASTING_CAST0 FOREIGN KEY (CAST_ID) REFERENCES T_E_OFFRE_CASTING_CAST(CAST_ID)
);



