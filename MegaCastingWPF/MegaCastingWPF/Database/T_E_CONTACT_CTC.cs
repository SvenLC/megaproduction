//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaCastingWPF.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_E_CONTACT_CTC
    {
        public int CTC_ID { get; set; }
        public string CTC_DESCRIPTION { get; set; }
        public string CTC_NUM_TEL { get; set; }
        public string CTC_NUM_FAX { get; set; }
        public string CTC_EMAIL { get; set; }
        public bool CTC_PRINCIPALE { get; set; }
        public int PRO_ID { get; set; }
    
        public virtual T_E_PROSPECT_PRO T_E_PROSPECT_PRO { get; set; }
    }
}
