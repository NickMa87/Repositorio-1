using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Attribute_Decoration.Controllers
{
    public class DefaultController : Controller
    {

        [Route("")]
        [Route("Default")]
        [Route("Default/Index")]

        public ActionResult Index()
        {

            return new EmptyResult();

        }

        [Route("Default/GetRecordsById/{id}")]

        public ActionResult GetRecordsById(int id)
        {
            string str = string.Format("The id pass as parameter is :{0}", id);
            return Ok(str);
        
        }

        






    }
}
