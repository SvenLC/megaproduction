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
    
    public partial class T_E_CONTENU_EDITORIAL_EDI
    {
        public int EDI_ID { get; set; }
        public string EDI_DESCRIPTION { get; set; }
        public string EDI_CONTENU { get; set; }
        public int CET_ID { get; set; }
    
        public virtual T_R_CONTENU_EDITORIAL_TYPE_CET T_R_CONTENU_EDITORIAL_TYPE_CET { get; set; }
    }
}
