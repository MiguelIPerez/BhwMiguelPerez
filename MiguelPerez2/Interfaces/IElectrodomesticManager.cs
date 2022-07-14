using MiguelPerez2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiguelPerez2.Interfaces
{
    public interface IElectrodomesticManager
    {
        IList<Electrodomestic> GetAll();
        Task PostAsync(Electrodomestic electrodomestic);
    }
}
