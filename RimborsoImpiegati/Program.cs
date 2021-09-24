
using AdoRepository;
using RimborsoImpiegati.AdoRepository;
using RimborsoImpiegati.Core.BusinessLayer;
using System;

namespace RimborsoImpiegati
{
    class Program
    {
        private static readonly IBusinessLayer1 bl = new MainBusinessLayer(new AdoRepositoryDipendenti(), new AdoRepositorySpese());
        
        
        static void Main(string[] args)
        {

            try
            {
                bl.EseguiCalcoli();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
