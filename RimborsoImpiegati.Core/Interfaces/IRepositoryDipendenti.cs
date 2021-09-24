using RimborsoImpiegati.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimborsoImpiegati.Core.Interfaces
{
    public interface IRepositoryDipendenti : IRepository<Dipendenti>
    {
        public List<Dipendenti> Fetch(List<Spesa> spese);
        List<Dipendenti> GetById();
    }
}
