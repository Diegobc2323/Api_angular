using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_angular.Controllers
{
    public class ProfesorController : ApiController
    {
        public IEnumerable<Profesores> Get()
        {
            using (ColegioEntities3 entities = new ColegioEntities3())
            {
                return entities.Profesores.ToList();
            }
        }

        public Profesores Get(int id)
        {
            using (ColegioEntities3 entities = new ColegioEntities3())
            {
                return entities.Profesores.FirstOrDefault(p=> p.ID == id);
            }
        }

    }
}
