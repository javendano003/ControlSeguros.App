using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ControlSeguros.App.Frontend.Pages.Auxiliar
{
    public class EditVehiculo : PageModel
    {
        private readonly ILogger<EditVehiculo> _logger;

        public EditVehiculo(ILogger<EditVehiculo> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}