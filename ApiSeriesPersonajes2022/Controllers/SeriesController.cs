using ApiSeriesPersonajes2022.Models;
using ApiSeriesPersonajes2022.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSeriesPersonajes2022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private RepositorySeries repo;

        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Serie>> Series()
        {
            return this.repo.GetSeries();
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Personaje>> Personajes()
        {
            return this.repo.GetPersonajes();
        }

        [HttpGet]
        [Route("[action]/{idserie}")]
        public ActionResult<Serie> FindSerie(int idserie)
        {
            return this.repo.FindSerie(idserie);
        }

        [HttpGet]
        [Route("[action]/{idpersonaje}")]
        public ActionResult<Personaje> FindPersonaje(int idpersonaje)
        {
            return this.repo.FindPersonaje(idpersonaje);
        }

        [HttpGet]
        [Route("[action]/{idserie}")]
        public ActionResult<List<Personaje>> PersonajesSerie(int idserie)
        {
            return this.repo.GetPersonajesSerie(idserie);
        }

        [HttpPut]
        [Route("[action]/{idpersonaje}/{idserie}")]
        public void UpdatePersonajeSerie(int idpersonaje, int idserie)
        {
            this.repo.UpdatePersonajeSerie(idpersonaje, idserie);
        }
    }
}
