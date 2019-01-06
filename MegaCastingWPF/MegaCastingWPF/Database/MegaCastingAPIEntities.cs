using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Database
{
    public class MegaCastingAPIEntities
    {
        APIObject<T_E_ADRESSE_ADR> T_E_ADRESSE_ADR;
        APIObject<T_E_CONTACT_CTC> T_E_CONTACT_CTC;
        APIObject<T_E_CONTENU_EDITORIAL_EDI> T_E_CONTENU_EDITORIAL_EDI;
        APIObject<T_E_OFFRE_CASTING_CAST> T_E_OFFRE_CASTING_CAST;
        APIObject<T_E_PROSPECT_PRO> T_E_PROSPECT_PRO;
        APIObject<T_H_CLIENT_CLI> T_H_CLIENT_CLI;
        APIObject<T_H_PARTENAIRES_PAR> T_H_PARTENAIRES_PAR;
        APIObject<T_R_CONTENU_EDITORIAL_TYPE_CET> T_R_CONTENU_EDITORIAL_TYPE_CET;
        APIObject<T_R_CONTRAT_CON> T_R_CONTRAT_CON;
        APIObject<T_R_DOMAINE_METIER_DOM> T_R_DOMAINE_METIER_DOM;
        APIObject<T_R_LOCALISATION_LOC> T_R_LOCALISATION_LOC;
        APIObject<T_R_METIER_MET> T_R_METIER_MET;
        APIObject<T_R_STATUT_JURIDIQUE_JUR> T_R_STATUT_JURIDIQUE_JUR;
        APIObject<T_S_DATABASE_ADMIN_DBA> T_S_DATABASE_ADMIN_DBA;
        APIObject<T_S_DATABASE_INFO_DBI> T_S_DATABASE_INFO_DBI;
        APIObject<T_S_UTILISATEUR_UTI> T_S_UTILISATEUR_UTI;
        APIObject<T_X_CODE_POSTAL_CPT> T_X_CODE_POSTAL_CPT;

        public MegaCastingAPIEntities()
        {
            this.T_E_ADRESSE_ADR = new APIObject<T_E_ADRESSE_ADR>("");
            this.T_E_CONTACT_CTC = new APIObject<T_E_CONTACT_CTC>("");
            this.T_E_CONTENU_EDITORIAL_EDI = new APIObject<T_E_CONTENU_EDITORIAL_EDI>("");
            this.T_E_OFFRE_CASTING_CAST = new APIObject<T_E_OFFRE_CASTING_CAST>("");
            this.T_E_PROSPECT_PRO = new APIObject<T_E_PROSPECT_PRO>("");
            this.T_H_CLIENT_CLI = new APIObject<T_H_CLIENT_CLI>("");
            this.T_H_PARTENAIRES_PAR = new APIObject<T_H_PARTENAIRES_PAR>("");
            this.T_R_CONTENU_EDITORIAL_TYPE_CET = new APIObject<T_R_CONTENU_EDITORIAL_TYPE_CET>("");
            this.T_R_CONTRAT_CON = new APIObject<T_R_CONTRAT_CON>("");
            this.T_R_DOMAINE_METIER_DOM = new APIObject<T_R_DOMAINE_METIER_DOM>("");
            this.T_R_LOCALISATION_LOC = new APIObject<T_R_LOCALISATION_LOC>("");
            this.T_R_METIER_MET = new APIObject<T_R_METIER_MET>("");
            this.T_R_STATUT_JURIDIQUE_JUR = new APIObject<T_R_STATUT_JURIDIQUE_JUR>("");
            this.T_S_DATABASE_ADMIN_DBA = new APIObject<T_S_DATABASE_ADMIN_DBA>("");
            this.T_S_DATABASE_INFO_DBI = new APIObject<T_S_DATABASE_INFO_DBI>("");
            this.T_S_UTILISATEUR_UTI = new APIObject<T_S_UTILISATEUR_UTI>("");
            this.T_X_CODE_POSTAL_CPT = new APIObject<T_X_CODE_POSTAL_CPT>("");
        }

    }
}
