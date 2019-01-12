using System;
using System.Collections.Generic;
using System.Text;
using Veiculos.Interfaces.Repos;
using Veiculos.Interfaces.Services;
using Veiculos.Services.Base;

namespace Veiculos.Services
{
   public class VeiculoService : BaseService<Veiculo>, IVeiculoService
    {
        private readonly IVeiculoRepo _repo;
        public VeiculoService(IVeiculoRepo repo) : base(repo)
        {
            _repo = repo;
        }

    }
}
