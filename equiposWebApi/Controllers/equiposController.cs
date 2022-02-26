using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equiposWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace equiposWebApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly prestamosContext _context;

        public equiposController(prestamosContext miContexto)
        {
            this._context = miContexto;
        }

        ///<summary>
        ///Metodo para retornar todos los reg. de la tabla de EQUIPOS
        ///</summary>
        ///<returns></returns>
        [HttpGet]
        [Route("api/equipos")]
        public IActionResult Get()
        {
            IEnumerable<equipos> equiposList = from e in _context.equipos
                                               select e;
            if (equiposList.Count()>0)
            {
                return Ok(equiposList);
            }
            return NotFound();
        }
    }
}
