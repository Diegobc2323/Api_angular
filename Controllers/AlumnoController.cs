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
            using (ColegioEntities2 entities2 = new ColegioEntities2())
            {
                return entities2.Alumnos.ToList();
            }
        }

        public Alumnos Get(int id)
        {
            using (ColegioEntities2 entities2 = new ColegioEntities2())
            {
                return entities2.Alumnos.FirstOrDefault(a=> a.id == id);
            }
        }

    }
}
