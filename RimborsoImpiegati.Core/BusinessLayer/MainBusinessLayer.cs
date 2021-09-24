using RimborsoImpiegati.Core.Entity;
using RimborsoImpiegati.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimborsoImpiegati.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer1
    {
        private readonly IRepositoryDipendenti dipendentiRepo;
        private readonly IRepositorySpese speseRepo;

        public MainBusinessLayer(IRepositoryDipendenti dipendentiRepository,
            IRepositorySpese speseRepository)
        {
            dipendentiRepo = dipendentiRepository;
            speseRepo = speseRepository;
        }

        

        public void EseguiCalcoli()
        {
           
            List<Spesa> spese = new List<Spesa>();
            
            try
            {
                
                spese = speseRepo.GetItemsWithOutApprov();
               

                if (spese.Count() > 0 )
                {
                    foreach (var spesa in spese)
                    {
                        if (spesa.ContoSpesa <= 400)
                        {
                            spesa.ApprovatorE = _Approvatore.Manager;
                            spesa.Approvata = true;
                            CalcolaIlRimborso(spesa);
                        }
                        else if (spesa.ContoSpesa > 400 && spesa.ContoSpesa <= 1000)
                        {
                            spesa.ApprovatorE = _Approvatore.OperationManager;
                            spesa.Approvata = true;
                            CalcolaIlRimborso(spesa);
                        }
                        else if (spesa.ContoSpesa > 1000 && spesa.ContoSpesa <= 2500)
                        {
                            spesa.ApprovatorE = _Approvatore.Ceo;
                            spesa.Approvata = true;
                            CalcolaIlRimborso(spesa);
                        }
                        else 
                        {
                            spesa.Approvata = false;
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CalcolaIlRimborso(_Categoria CategoriA)
        {
            if (Spesa. )
        }
    }
    }
}
