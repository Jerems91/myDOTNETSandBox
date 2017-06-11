using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApi.Models {

    /// <summary>
    /// Représente un collège
    /// </summary>
    public class College {

        /// <summary>
        /// Obtient ou définit l'identifiant
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou définit le code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Obtient ou définit le libellé
        /// </summary>
        public string Libelle { get; set; }
    }
}