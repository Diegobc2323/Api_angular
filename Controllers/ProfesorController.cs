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
            using (ColegioEntities2 entities2 = new ColegioEntities2())
            {
                return entities2.Profesores.ToList();
            }
        }

        public Profesores Get(int id)
        {
            using (ColegioEntities2 entities2 = new ColegioEntities2())
            {
                return entities2.Profesores.FirstOrDefault(p=> p.ID == id);
            }
        }

    }
}
