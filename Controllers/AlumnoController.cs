using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_angular.Controllers
{
    public class AlumnoController : ApiController
    {
        public IEnumerable<Alumnos> Get()
        {
            using (ColegioEntities3 entities = new ColegioEntities3())
            {
                return entities.Alumnos.ToList();
            }
        }

        public Alumnos Get(int id)
        {
            using (ColegioEntities3 entities3 = new ColegioEntities3())
            {
                return entities3.Alumnos.FirstOrDefault(a=> a.id == id);
            }
        }

    }
}
