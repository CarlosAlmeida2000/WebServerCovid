using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_covid.data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebServerCovid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class contagios_ecuador : Controller
    {
        private readonly ICovid _contagios;
        public contagios_ecuador(ICovid contagios)
        {
            _contagios = contagios;
        }

        /** /api/contagios_ecuador **/
        [HttpGet]
        public async Task<IActionResult> getAllProvincia()
        {
            return Ok(await this._contagios.getAllProvincia());
        }

        /** /api/contagios_ecuador/id-provincia?id={id provincia} **/
        [HttpGet("id-provincia")]
        public async Task<IActionResult> getProvincia(int id)
        {
            return Ok(await this._contagios.getProvincia(id));
        }

        /** /api/contagios_ecuador/name-provincia?provincia={nombre provincia} **/
        [HttpGet("name-provincia")]
        public async Task<IActionResult> getProvincia(string provincia)
        {
            return Ok(await this._contagios.getProvincia(provincia));
        }
    }
}
