using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ColorApi.Models;
using ColorApi.Contexts;

namespace ColouApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ColorContext _context;

        public ValuesController(ColorContext context)
        {
            _context = context;
        }

        public ActionResult<IEnumerable<Color>> GetColors()
        {
            return _context.Colors;
        }

        // GET api/values
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }



    }
}
