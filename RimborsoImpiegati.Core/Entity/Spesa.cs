using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimborsoImpiegati.Core.Entity
{
    public class Spesa
    {
        public int Id { get; set; }
        public DateTime DataSpesa { get; set; }
        
        public double ContoSpesa { get; set; }
        public  _Categoria CategoriA { get; set; }
        public string Description { get; set; }
        public int IdDipendente { get; set; }
        public bool? Approvata { get; set; }
        public double? Rimborso { get; set; }
        public  _Approvatore ApprovatorE { get; set; }

        
    }



    public enum _Approvatore
    {
        Manager = 1,
        OperationManager = 2,
        Ceo = 3
    }

    public enum _Categoria
    {
        Vitto = 1,
        Alloggio = 2,
        Trasferta = 3,
        Altro = 4
    }
}
