using RimborsoImpiegati.Core.Entity;
using RimborsoImpiegati.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoRepository
{
   public class AdoRepositoryDipendenti : IRepositoryDipendenti
    {
        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                         "Initial Catalog = AcademyI.EsercitazioneFinale;" +
                                         "Integrated Security = true";

        public List<Dipendenti> Fetch(List<Spesa> spese)
        {
            throw new NotImplementedException();
        }

        public List<Dipendenti> Fetch()
        {
            throw new NotImplementedException();
        }

        public Dipendenti GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Dipendenti> GetById()
        {
            throw new NotImplementedException();
        }

        public List<Dipendenti> GetItemsWithOutApprov()
        {
            throw new NotImplementedException();
        }
    }
}
