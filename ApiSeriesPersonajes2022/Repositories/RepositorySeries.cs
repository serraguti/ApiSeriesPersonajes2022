using ApiSeriesPersonajes2022.Data;
using ApiSeriesPersonajes2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSeriesPersonajes2022.Repositories
{
    public class RepositorySeries
    {
        private SeriesContext context;

        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        public List<Personaje> GetPersonajes()
        {
            return this.context.Personajes.ToList();
        }

        public List<Serie> GetSeries()
        {
            return this.context.Series.ToList();
        }

        public Serie FindSerie(int idserie)
        {
            return this.context.Series.SingleOrDefault(x => x.IdSerie == idserie);
        }

        public Personaje FindPersonaje(int idPersonaje)
        {
            return this.context.Personajes.SingleOrDefault
                (x => x.IdPersonaje == idPersonaje);
        }

        public List<Personaje> GetPersonajesSerie(int idserie)
        {
            var consulta = from datos in this.context.Personajes
                           where datos.IdSerie == idserie
                           select datos;
            return consulta.ToList();
        }

        public void UpdatePersonajeSerie(int idpersonaje, int idserie)
        {
            Personaje p = this.context.Personajes.SingleOrDefault
                (x => x.IdPersonaje == idpersonaje);
            p.IdSerie = idserie;
            this.context.SaveChanges();
        }
    }
}
