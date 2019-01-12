

using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Veiculos.Api.Controllers.Interface;
using Veiculos.App.Interface;

namespace Veiculos.Api.Controllers
{
    [Route("veiculos")]
    public class VeiculosController : ControllerBase, IBaseController<Veiculo>
    {

        private readonly IVeiculoApp _veiculoApp;

        public VeiculosController(IVeiculoApp veiculoApp)
        {
            _veiculoApp = veiculoApp;
        }

        [HttpDelete("veiculo/{id}")]
        public IActionResult Delete(long id)
        {
            try
            {
                _veiculoApp.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }
        }

        [HttpGet("veiculo/{id}")]
        public IActionResult Find(long id)
        {
            return Ok(_veiculoApp.Find(id));
        }

        [HttpGet("veiculos")]
        public IEnumerable List()
        {
          return  _veiculoApp.List();
        }

        [HttpPost("veiculo")]
        public IActionResult Post([FromBody] Veiculo obj)
        {
            try
            {
                return Ok(_veiculoApp.Save(obj));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }
        }

    }
}
