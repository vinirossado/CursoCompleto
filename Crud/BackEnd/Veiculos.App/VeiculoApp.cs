using System;
using System.Collections.Generic;
using System.Text;
using Veiculos.app.Base;
using Veiculos.App.Interface;
using Veiculos.Interfaces.Services;

namespace Veiculos.App
{
    public class VeiculoApp : BaseApp<Veiculo>, IVeiculoApp
    {
        private readonly IVeiculoService _service;
        public VeiculoApp (IVeiculoService service) : base(service)
        {
            _service = service;
        }
    }
}
