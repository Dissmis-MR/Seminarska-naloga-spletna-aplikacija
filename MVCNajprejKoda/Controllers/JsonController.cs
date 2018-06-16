using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SkladisceFilmov.Models;

namespace SkladisceFilmov.Controllers
{
    public class JsonController : ApiController
    {
        private FilmiContext db = new FilmiContext();

        // GET: api/Json
        public IQueryable<Film> GetFilms()
        {
            return db.Films;
        }

        
    }
}