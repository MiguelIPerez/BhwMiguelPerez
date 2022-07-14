using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MiguelPerez2.Interfaces;
using MiguelPerez2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiguelPerez2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IElectrodomesticManager _manager; 

        [BindProperty]
        public IList<Electrodomestic> Model { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IElectrodomesticManager manager)
        {
            _logger = logger;
            this._manager = manager;
        }

        public void OnGet()
        {
            this.Model = this._manager.GetAll().Select(x => new Electrodomestic { Description = x.Description, Name = x.Name, Quantity = x.Quantity }).ToList();
        }
    }
}
