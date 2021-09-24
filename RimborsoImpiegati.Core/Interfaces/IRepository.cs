using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimborsoImpiegati.Core.Interfaces
{
    public interface IRepository<T>
    {
        public List<T> Fetch();
        List<T> GetItemsWithOutApprov(); 
        T GetById(int id);
    }
}
