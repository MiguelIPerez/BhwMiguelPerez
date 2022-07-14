using MiguelPerez2.Interfaces;
using MiguelPerez2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiguelPerez2.Managers
{
    public class ElectrodomesticManager : IElectrodomesticManager
    {
        private AuthDbContext dbContext;

        public ElectrodomesticManager(AuthDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IList<Electrodomestic> GetAll()
        {
            return this.dbContext.Electrodomestics.ToList();
        }

        public async Task PostAsync(Electrodomestic electrodomestic)
        {
            electrodomestic.Id = Guid.NewGuid();
            this.dbContext.Add(electrodomestic);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
