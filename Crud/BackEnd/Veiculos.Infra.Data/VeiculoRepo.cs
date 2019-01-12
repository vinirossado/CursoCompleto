using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Veiculos.Infra.Data.Base;
using Veiculos.Infra.Data.Context;
using Veiculos.Interfaces.Repos;

namespace Veiculos.Infra.Data
{
   public class VeiculoRepo : BaseRepo<Veiculo>, IVeiculoRepo
    {
        private readonly DbContextOptions<DataContext> _options;
        public VeiculoRepo(DbContextOptions<DataContext> options) : base(options)
        {
            _options = options;
        }
    }
}
