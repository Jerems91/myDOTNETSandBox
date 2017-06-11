using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TestWebApi.Models;

namespace TestWebApi.Controllers {

    /// <summary>
    /// Représente le contrôleur des données de paramétrage
    /// </summary>
    [RoutePrefix("api/parametrages")]
    public class ParametragesController : ApiController {

        /// <summary>
        /// Valorisation des collèges
        /// </summary>
        College[] colleges = new College[] {
            new College { Id = 1, Code = "CADRE", Libelle="Cadre" },
            new College { Id = 2, Code = "NON_CADRE", Libelle="Non Cadre" }
        };

        /// <summary>
        /// Valorisation des civilités
        /// </summary>
        Civilite[] civilites = new Civilite[] {
            new Civilite { Id = 1, Code = "MONSIEUR", Libelle="M." },
            new Civilite { Id = 2, Code = "MADAME", Libelle="Mme" }
        };

        /// <summary>
        /// Obtient la liste des collèges
        /// </summary>
        /// <returns></returns>
        [Route("colleges")]
        [HttpGet]
        public IEnumerable<College> GetAllColleges() {
            return colleges;
        }

        /// <summary>
        /// Obtient un collège à partir de son identifiant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("colleges/{id}")]
        [HttpGet]
        public IHttpActionResult GetCollegeById(int id) {
            var college = colleges.FirstOrDefault(c => c.Id == id);
            if (college == null) {
                return NotFound();
            }
            return Ok(college);
        }
        /// <summary>
        /// Obtient la liste des civilités
        /// </summary>
        /// <returns></returns>
        [Route("civilites")]
        [HttpGet]
        public IEnumerable<Civilite> GetAllCivilites() {
            return civilites;
        }

        /// <summary>
        /// Obtient une civilité à partir de son identifiant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("civilites/{id}")]
        [HttpGet]
        public IHttpActionResult GetCiviliteById(int id) {
            var civilite = civilites.FirstOrDefault(c => c.Id == id);
            if (civilite == null) {
                return NotFound();
            }
            return Ok(civilite);
        }
    }
}