using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCastingWPF.Model.Extends;

namespace MegaCastingWPF.Database
{
    public class MegaCastingAPIEntities
    {
        const string PATH = "https://megacastingprivateapi.azurewebsites.net";

        public APIObject<T_E_ADRESSE_ADR> T_E_ADRESSE_ADR;
        public APIObject<T_E_CONTACT_CTC> T_E_CONTACT_CTC;
        public APIObject<T_E_CONTENU_EDITORIAL_EDI> T_E_CONTENU_EDITORIAL_EDI;
        public APIObject<T_E_OFFRE_CASTING_CAST> T_E_OFFRE_CASTING_CAST;
        public APIObject<T_E_PROSPECT_PRO> T_E_PROSPECT_PRO;
        public APIObject<T_H_CLIENT_CLI> T_H_CLIENT_CLI;
        public APIObject<T_H_PARTENAIRES_PAR> T_H_PARTENAIRES_PAR;
        public APIObject<T_R_CONTENU_EDITORIAL_TYPE_CET> T_R_CONTENU_EDITORIAL_TYPE_CET;
        public APIObject<T_R_CONTRAT_CON> T_R_CONTRAT_CON;
        public APIObject<T_R_DOMAINE_METIER_DOM> T_R_DOMAINE_METIER_DOM;
        public APIObject<T_R_LOCALISATION_LOC> T_R_LOCALISATION_LOC;
        public APIObject<T_R_METIER_MET> T_R_METIER_MET;
        public APIObject<T_R_STATUT_JURIDIQUE_JUR> T_R_STATUT_JURIDIQUE_JUR;
        public APIObject<T_S_DATABASE_ADMIN_DBA> T_S_DATABASE_ADMIN_DBA;
        public APIObject<T_S_DATABASE_INFO_DBI> T_S_DATABASE_INFO_DBI;
        public APIObject<T_S_UTILISATEUR_UTI> T_S_UTILISATEUR_UTI;
        public APIObject<T_X_CODE_POSTAL_CPT> T_X_CODE_POSTAL_CPT;

        public static string token = "";

        public MegaCastingAPIEntities()
        {
            this.T_E_ADRESSE_ADR = new APIObject<T_E_ADRESSE_ADR>(PATH + "/adresses");
            this.T_E_CONTACT_CTC = new APIObject<T_E_CONTACT_CTC>(PATH + "/contacts");
            this.T_E_CONTENU_EDITORIAL_EDI = new APIObject<T_E_CONTENU_EDITORIAL_EDI>(PATH + "/contenus");
            this.T_E_OFFRE_CASTING_CAST = new APIObject<T_E_OFFRE_CASTING_CAST>(PATH + "/offreCastings");
            this.T_E_PROSPECT_PRO = new APIObject<T_E_PROSPECT_PRO>(PATH + "/prospects");
            this.T_H_CLIENT_CLI = new APIObject<T_H_CLIENT_CLI>(PATH + "/clients");
            this.T_H_PARTENAIRES_PAR = new APIObject<T_H_PARTENAIRES_PAR>(PATH + "/partenaires");
            //this.T_R_CONTENU_EDITORIAL_TYPE_CET = new APIObject<T_R_CONTENU_EDITORIAL_TYPE_CET>(PATH + "");
            this.T_R_CONTRAT_CON = new APIObject<T_R_CONTRAT_CON>(PATH + "/contrats");
            this.T_R_DOMAINE_METIER_DOM = new APIObject<T_R_DOMAINE_METIER_DOM>(PATH + "/domainemetiers");
            this.T_R_LOCALISATION_LOC = new APIObject<T_R_LOCALISATION_LOC>(PATH + "/localisations");
            this.T_R_METIER_MET = new APIObject<T_R_METIER_MET>(PATH + "/metiers");
            this.T_R_STATUT_JURIDIQUE_JUR = new APIObject<T_R_STATUT_JURIDIQUE_JUR>(PATH + "/statutjuridiques");
            //this.T_S_DATABASE_ADMIN_DBA = new APIObject<T_S_DATABASE_ADMIN_DBA>(PATH + "");
            //this.T_S_DATABASE_INFO_DBI = new APIObject<T_S_DATABASE_INFO_DBI>(PATH + "");
            this.T_S_UTILISATEUR_UTI = new APIObject<T_S_UTILISATEUR_UTI>(PATH + "/utilisateurs");
            //this.T_X_CODE_POSTAL_CPT = new APIObject<T_X_CODE_POSTAL_CPT>(PATH + "");
        }

    }
}
